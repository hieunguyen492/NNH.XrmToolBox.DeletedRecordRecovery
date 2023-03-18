using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using NNH.XrmToolBox.DeleteRecordRecovery.Helpers;
using NNH.XrmToolBox.DeleteRecordRecovery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace NNH.XrmToolBox.DeleteRecordRecovery
{
    public partial class DeleteRecordRecovery : PluginControlBase
    {
        #region Variables
        private Settings mySettings;

        private const string DATETIMEFORMAT = "yyyy-MM-dd HH:mm";

        /// <summary>
        /// The entity metadata list
        /// </summary>
        private List<EntityMetadata> entityMetadataList;

        /// <summary>
        /// Dynamics 365 entities' data list
        /// </summary>
        private List<Tuple<int, string, string, string>> entityList;

        /// <summary>
        /// Dynamics 365 users' data list
        /// </summary>
        private List<Tuple<Guid, bool, string>> displayUserList;

        /// <summary>
        /// Deleted audit history data
        /// </summary>
        private List<AuditHistories> deletedData;
        #endregion


        public DeleteRecordRecovery()
        {
            InitializeComponent();

            ReadOnlyCollection<TimeZoneInfo> tzCollection;
            tzCollection = TimeZoneInfo.GetSystemTimeZones();
            cbTimezone.DataSource = tzCollection;
            var currentTZItem = TimeZoneInfo.Local;
            if (currentTZItem != null)
            {
                cbTimezone.SelectedIndex = tzCollection.IndexOf(currentTZItem);
            }

            dtpFrom.Value = DateTime.Now.Date;
            dtpTo.Value = DateTime.Now;
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void txtSearchEntity_Enter(object sender, EventArgs e)
        {
            if (txtSearchEntity.Text == "Enter entity schema name or display name...")
            {
                txtSearchEntity.Text = "";
                txtSearchEntity.ForeColor = Color.Black;
            }
        }

        private void txtSearchEntity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchEntity.Text))
            {
                txtSearchEntity.Text = "Enter entity schema name or display name...";
                txtSearchEntity.ForeColor = Color.DarkGray;
            }
            else
            {
                FilterEntitiesDDL();
            }
        }

        private void txtSearchUser_Enter(object sender, EventArgs e)
        {
            if (txtSearchUser.Text == "Enter user name...")
            {
                txtSearchUser.Text = "";
                txtSearchUser.ForeColor = Color.Black;
            }
        }

        private void txtSearchUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchUser.Text))
            {
                txtSearchUser.Text = "Enter user name...";
                txtSearchUser.ForeColor = Color.DarkGray;
            }
            else
            {
                FilterUsersDDL();
            }
        }

        private void tsbLoadEntityAndUser_Click(object sender, EventArgs e)
        {
            entityList = new List<Tuple<int, string, string, string>>();
            entityMetadataList = new List<EntityMetadata>();

            ExecuteMethod(WhoAmI);

            if (Service == null)
            {
                return;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading entities with auditing enabled...",
                Work = (w, ev) =>
                {
                    RetrieveAllEntitiesRequest metaDataRequest = new RetrieveAllEntitiesRequest();
                    metaDataRequest.EntityFilters = EntityFilters.Attributes;

                    var metaDataResponse = (RetrieveAllEntitiesResponse)Service.Execute(metaDataRequest);

                    var entities = metaDataResponse.EntityMetadata;
                    foreach (var item in entities)
                    {
                        if (item.IsAuditEnabled.Value)
                        {
                            entityList.Add(new Tuple<int, string, string, string>(item.ObjectTypeCode.Value, item.DisplayName.UserLocalizedLabel.Label, item.PrimaryNameAttribute, string.Concat(item.DisplayName.UserLocalizedLabel.Label, "　　　[", item.LogicalName, "]")));
                            entityMetadataList.Add(item);
                        }
                    }

                    ev.Result = entityList.OrderBy(x => (x.Item2)).ToList();
                },
                ProgressChanged = ev =>
                {
                    // If progress has to be notified to user, use the following method:
                    SetWorkingMessage("Loading entities with auditing enabled...");
                },
                PostWorkCallBack = ev =>
                {
                    cbEntity.DataSource = ev.Result;
                    cbEntity.DisplayMember = "Item4";
                    cbEntity.ValueMember = "Item1";
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading users...",
                Work = (w, ev) =>
                {
                    displayUserList = new List<Tuple<Guid, bool, string>>();

                    FetchExpression query = new FetchExpression(FetchXMLResources.GetAllUsersXML);
                    var queryResult = Service.RetrieveMultiple(query);
                    displayUserList.Add(new Tuple<Guid, bool, string>(Guid.Empty, false, "!All Users"));
                    foreach (var item in queryResult.Entities)
                    {
                        var uName = item.Attributes["fullname"] != null ? item.Attributes["fullname"].ToString() : string.Empty;
                        var isDisabled = item.Attributes["isdisabled"] != null ? (bool)item.Attributes["isdisabled"] : false;
                        displayUserList.Add(new Tuple<Guid, bool, string>(item.Id, isDisabled, uName));
                    }
                    if (chkDisabledUsers.Checked)
                    {
                        ev.Result = displayUserList.OrderBy(x => (x.Item3)).ToList();
                    }
                    else
                    {
                        ev.Result = displayUserList.Where(p => p.Item2 == false).OrderBy(x => (x.Item3)).ToList();
                    }

                },
                ProgressChanged = ev =>
                {
                    // If progress has to be notified to user, use the following method:
                    SetWorkingMessage("Loading users...");
                },
                PostWorkCallBack = ev =>
                {
                    cbUser.DataSource = ev.Result;
                    cbUser.DisplayMember = "Item3";
                    cbUser.ValueMember = "Item1";
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }


        private void chkDisabledUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (displayUserList == null || !displayUserList.Any())
            {
                return;
            }
            if (chkDisabledUsers.Checked)
            {
                cbUser.DataSource = displayUserList.OrderBy(x => (x.Item3)).ToList();
            }
            else
            {
                cbUser.DataSource = displayUserList.Where(p => p.Item2 == false).OrderBy(x => (x.Item3)).ToList();
            }
            cbUser.DisplayMember = "Item3";
            cbUser.ValueMember = "Item1";
        }

        private void txtSearchEntity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterEntitiesDDL();
            }
        }

        /// <summary>
        /// Filter entities combobox by the search text box
        /// </summary>
        private void FilterEntitiesDDL()
        {
            if (entityList == null || entityList.Count == 0)
                return;
            string filterText = txtSearchEntity.Text.Trim().ToLower();
            if (filterText.Length > 0)
            {
                //ddlEntities.DataSou
                var filterItems = entityList.Where(p => p.Item4.Contains(filterText));
                cbEntity.DataSource = filterItems.OrderBy(x => (x.Item2)).ToList();
            }
            else
            {
                cbEntity.DataSource = entityList.OrderBy(x => (x.Item2)).ToList();
            }
            cbEntity.DisplayMember = "Item4";
            cbEntity.ValueMember = "Item1";
        }

        private void txtSearchUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterUsersDDL();
            }
        }

        /// <summary>
        /// Filter users combobox by the search text box
        /// </summary>
        private void FilterUsersDDL()
        {
            if (displayUserList == null || displayUserList.Count == 0)
                return;

            string filterText = this.txtSearchUser.Text.Trim().ToLower();
            if (filterText.Length > 0)
            {
                //ddlEntities.DataSou
                var filterItems = displayUserList.Where(p => p.Item3.Contains(filterText));
                cbUser.DataSource = filterItems.OrderBy(x => (x.Item3)).ToList();
            }
            else
            {
                cbUser.DataSource = displayUserList.OrderBy(x => (x.Item3)).ToList();
            }
            cbUser.DisplayMember = "Item3";
            cbUser.ValueMember = "Item1";
        }

        private void tsbShowData_Click(object sender, EventArgs e)
        {
            if (IsValidWhenShowData())
            {
                Guid selectedUser = (Guid)cbUser.SelectedValue;
                var selectedEntityValue = cbEntity.SelectedValue;
                Tuple<int, string, string, string> selectedEntity = (Tuple<int, string, string, string>)cbEntity.SelectedItem;
                var currentTimeZone = (TimeZoneInfo)cbTimezone.SelectedItem;
                var dateFrom = TimeZoneInfo.ConvertTimeToUtc(dtpFrom.Value);
                var dateTo = TimeZoneInfo.ConvertTimeToUtc(dtpTo.Value);

                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Loading deleted records...",
                    Work = (w, ev) =>
                    {
                        deletedData = new List<AuditHistories>();
                        FetchExpression query = null;
                        string auditFetchXml;
                        if (selectedUser == Guid.Empty)
                        {
                            auditFetchXml = string.Format(ConnectionDetail.OrganizationMajorVersion < 8 ?
                                FetchXMLResources.GetDeletedRecordsXML.Replace("regardingobject", "object") :
                                FetchXMLResources.GetDeletedRecordsXML,
                                dateFrom.ToString(Constants.Constants.UTC_DATE_FORMAT),
                                dateTo.ToString(Constants.Constants.UTC_DATE_FORMAT),
                                selectedEntityValue);
                        }
                        else
                        {
                            auditFetchXml = string.Format(ConnectionDetail.OrganizationMajorVersion < 8 ?
                                FetchXMLResources.GetDeletedRecordsByUserXML.Replace("regardingobject", "object") :
                                FetchXMLResources.GetDeletedRecordsByUserXML,
                                dateFrom.ToString(Constants.Constants.UTC_DATE_FORMAT),
                                dateTo.ToString(Constants.Constants.UTC_DATE_FORMAT),
                                selectedEntityValue,
                                selectedUser);
                        }
                        query = new FetchExpression(auditFetchXml);
                        var queryResult = Service.RetrieveMultiple(query);
                        foreach (Entity item in queryResult.Entities)
                        {
                            RetrieveAuditDetailsRequest auditDetailRequest = new RetrieveAuditDetailsRequest();
                            auditDetailRequest.AuditId = item.Id;
                            RetrieveAuditDetailsResponse response = (RetrieveAuditDetailsResponse)Service.Execute(auditDetailRequest);
                            AttributeAuditDetail attributeDetail = (AttributeAuditDetail)response.AuditDetail;
                            EntityMetadata metadata = entityMetadataList.FirstOrDefault(x => (x.ObjectTypeCode == selectedEntity.Item1));
                            AuditHistories auditItem = new AuditHistories()
                            {
                                AuditId = item.Id,
                                DeletedBy = ((EntityReference)item["userid"]).Name,
                                DeletionDate = (DateTime)item["createdon"],
                                Entity = ((EntityReference)item["objectid"]).LogicalName,
                                RecordId = ((EntityReference)item["objectid"]).Id,
                                AuditDetail = attributeDetail,
                                Metadata = metadata
                            };

                            if (auditItem.DeletionDate.Kind == DateTimeKind.Utc)
                            {
                                auditItem.DeletionDate = TimeZoneInfo.ConvertTime(auditItem.DeletionDate, TimeZoneInfo.Utc, currentTimeZone);
                            }

                            if (selectedEntity.Item3 != null && attributeDetail.OldValue.Contains(selectedEntity.Item3))
                            {
                                auditItem.Name = attributeDetail.OldValue[selectedEntity.Item3].ToString();
                            }

                            deletedData.Add(auditItem);
                        }

                        ev.Result = deletedData.OrderByDescending(x => x.DeletionDate).ToList();
                    },
                    ProgressChanged = ev =>
                    {
                        // If progress has to be notified to user, use the following method:
                        SetWorkingMessage("Loading deleted records...");
                    },
                    PostWorkCallBack = ev =>
                    {
                        dgvDeletedData.DataSource = ev.Result;
                    },
                    AsyncArgument = null,
                    IsCancelable = true,
                    MessageWidth = 340,
                    MessageHeight = 150
                });

            }
        }


        private void dgvDeletedData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                AuditHistories audit = (AuditHistories)dgvDeletedData.Rows[e.RowIndex].DataBoundItem;
                ShowData(audit.AuditDetail, audit.Metadata);
            }
            else if (e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgvDeletedData.Rows[e.RowIndex].Cells[0];
                if (checkBoxCell.Value == null)
                {
                    checkBoxCell.Value = true;
                }
                else
                {
                    checkBoxCell.Value = !((bool)checkBoxCell.Value);
                }
            }
        }

        private void ShowData(AttributeAuditDetail auditDetail, EntityMetadata metadata)
        {
            List<DeletedFields> result = new List<DeletedFields>();

            foreach (var item in auditDetail.OldValue.Attributes)
            {
                var metadataAttrib = metadata.Attributes.Where(x => (x.SchemaName.ToLower() == item.Key.ToLower())).ToList();
                if (metadataAttrib.Count > 0)
                {
                    result.Add(new DeletedFields()
                    {
                        FieldName = metadataAttrib[0].DisplayName.UserLocalizedLabel.Label,
                        Value = GetFormattedValue(item.Value)
                    });
                }
            }

            dgvDetailData.DataSource = result;
        }

        private object GetFormattedValue(object input)
        {
            object result = input;

            if (input != null)
            {
                if (input.GetType() == typeof(EntityReference))
                {
                    result = ((EntityReference)input).Name;
                }
                else if (input.GetType() == typeof(OptionSetValue))
                {
                    result = ((OptionSetValue)input).Value;
                }
            }

            return result;
        }

        private void cbTimezone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentTimeZone = (TimeZoneInfo)cbTimezone.SelectedItem;
            var timeZoneText = currentTimeZone.BaseUtcOffset.Hours > 0 ? "+" : "-";
            timeZoneText += currentTimeZone.BaseUtcOffset.ToString(@"hh\:mm");


            var dateFromUtcText = ((DateTime)dtpFrom.Value).ToString(DATETIMEFORMAT) + " " + timeZoneText;
            var dateFromUtc = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Parse(dateFromUtcText), "UTC");
            dtpFrom.Value = TimeZoneInfo.ConvertTimeFromUtc(dateFromUtc, currentTimeZone);


            var dateToUtcText = ((DateTime)dtpTo.Value).ToString(DATETIMEFORMAT) + " " + timeZoneText;
            var dateToUtc = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Parse(dateToUtcText), "UTC");
            dtpTo.Value = TimeZoneInfo.ConvertTimeFromUtc(dateToUtc, currentTimeZone);
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            if (IsValidWhenExportData())
            {
                ExcelDocument excelGenerator = null;

                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Exporting deleted records...",
                    Work = (w, ev) =>
                    {
                        excelGenerator = new ExcelDocument();
                        excelGenerator.AuditHistoryList = deletedData;
                        excelGenerator.Worker = w;
                        excelGenerator.Generate(Service);
                    },
                    ProgressChanged = ev =>
                    {
                        // If progress has to be notified to user, use the following method:
                        SetWorkingMessage("Generating data...");
                    },
                    PostWorkCallBack = evt =>
                    {
                        if (evt.Error != null)
                        {
                            MessageBox.Show(this, "An error occured while generating document: " + evt.Error.ToString(), "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SaveFileDialog saveExcelFileDialog = new SaveFileDialog();

                            // Set the file filter and default file name
                            saveExcelFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls";
                            saveExcelFileDialog.FileName = "";
                            // Show the dialog to the user and get the result
                            DialogResult result = saveExcelFileDialog.ShowDialog();

                            // Check if the user selected a file and clicked the "OK" button
                            if (result == DialogResult.OK)
                            {
                                // Get the selected file path
                                string filePath = saveExcelFileDialog.FileName;

                                // Use the file path to save the Excel file with the chosen file name
                                excelGenerator.SaveDocument(filePath);

                                // Open file after saving
                                if (DialogResult.Yes == MessageBox.Show(this, "Do you want to open generated excel file?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    Process.Start(filePath);
                                }
                            }
                        }

                    },
                    AsyncArgument = null,
                    IsCancelable = true,
                    MessageWidth = 340,
                    MessageHeight = 150
                });
            }
        }

        #region Validation Methods

        /// <summary>
        /// Check the input data is valid when click show data button
        /// </summary>
        /// <returns>true if the input is valid; otherwise,</returns>
        private bool IsValidWhenShowData()
        {
            bool result = true;

            if (cbEntity.SelectedIndex == -1)
            {
                result = false;
                MessageBox.Show("Select entity from the list");
            }

            if (cbUser.SelectedIndex == -1)
            {
                result = false;
                MessageBox.Show("Select user from the list");
            }

            if (dtpFrom.Value > dtpTo.Value)
            {
                result = false;
                MessageBox.Show("From date should be less than to date");
            }

            return result;
        }

        /// <summary>
        /// Check the input data is valid when click export data button
        /// </summary>
        /// <returns></returns>
        private bool IsValidWhenExportData()
        {

            if (deletedData == null || !deletedData.Any())
            {
                MessageBox.Show("No data available for export. Please click the 「Show deleted data」 button to get the data first.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check the CRM connection
        /// </summary>
        private void WhoAmI()
        {
            Service.Execute(new WhoAmIRequest());
        }

        #endregion

    }
}