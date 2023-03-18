using Microsoft.Xrm.Sdk;
using NNH.XrmToolBox.DeleteRecordRecovery.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace NNH.XrmToolBox.DeleteRecordRecovery.Helpers
{
    internal class ExcelDocument
    {
        #region Variables
        /// <summary>
        /// Generation Settings
        /// </summary>
        private List<AuditHistories> audits;

        /// <summary>
        /// Excel workbook
        /// </summary>
        private readonly ExcelPackage innerWorkBook;

        /// <summary>
        /// Indicates if the header row of attributes is already added
        /// </summary>
        private bool attributesHeaderAdded;

        /// <summary>
        /// Line number where to write
        /// </summary>
        private int lineNumber = 1;

        private BackgroundWorker worker;

        #endregion Variables

        #region Properties
        public List<AuditHistories> AuditHistoryList
        {
            get { return audits; }
            set { audits = value; }
        }

        public BackgroundWorker Worker
        {
            set
            {
                worker = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of class ExcelDocument
        /// </summary>
        public ExcelDocument()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            innerWorkBook = new ExcelPackage();
            lineNumber = 1;
        }

        #endregion Constructor

        

        public void Generate(IOrganizationService service)
        {
            if (audits == null || !audits.Any())
            {
                return;
            }
            ExcelWorksheet summarySheet = null;
            summarySheet = AddWorkSheet("Deleted records");
            int processed = 0;
            foreach (var audit in audits.OrderBy(p => p.DeletionDate))
            {
                ReportProgress(processed * 100 / audits.Count, string.Format("Exporting data '{0}'...", audit.Name));
                AddAuditHistoryToWorksheet(summarySheet, audit);
                summarySheet.Cells[summarySheet.Dimension.Address].AutoFitColumns();
                processed++;
            }
        }

        /// <summary>
        /// Add a new worksheet
        /// </summary>
        /// <param name="logicalName">Logical name of the entity</param>
        /// <returns></returns>
        public ExcelWorksheet AddWorkSheet(string displayName)
        {
            string name = displayName;
            name = name
                .Replace(":", " ")
                .Replace("\\", " ")
                .Replace("/", " ")
                .Replace("?", " ")
                .Replace("*", " ")
                .Replace("[", " ")
                .Replace("]", " ");

            if (name.Length > 31)
                name = name.Substring(0, 31);

            attributesHeaderAdded = false;

            ExcelWorksheet sheet = null;
            int i = 1;
            do
            {
                try
                {
                    sheet = innerWorkBook.Workbook.Worksheets.Add(name);
                }
                catch (Exception)
                {
                    name = name.Substring(0, name.Length - 2) + "_" + i;
                    i++;
                }
            } while (sheet == null);

            return sheet;
        }

        /// <summary>
        /// Add audit history data to worksheet
        /// </summary>
        /// <param name="sheet">Worksheet where to write</param>
        /// <param name="data"></param>
        public void AddAuditHistoryToWorksheet(ExcelWorksheet sheet, AuditHistories auditData)
        {
            if (auditData == null)
            {
                return;
            }
            var y = 1;
            if (!attributesHeaderAdded)
            {
                InsertAttributeHeader(sheet, lineNumber, y);
                attributesHeaderAdded = true;
                lineNumber++;
            }

            InsertAttributeData(sheet, auditData, lineNumber, y);

            lineNumber++;

        }

        /// <summary>
        /// Saves the current workbook
        /// </summary>
        /// <param name="path">Path where to save the document</param>
        public void SaveDocument(string path)
        {
            innerWorkBook.File = new FileInfo(path);
            innerWorkBook.Save();
        }

        #region Private Methods
        /// <summary>
        /// Adds row header for attribute list
        /// </summary>
        /// <param name="sheet">Worksheet where to write</param>
        /// <param name="x">Row number</param>
        /// <param name="y">Cell number</param>
        private void InsertAttributeHeader(ExcelWorksheet sheet, int x, int y)
        {
            // Write the header
            sheet.Cells[x, y].Value = "Audit Id";
            y++;

            sheet.Cells[x, y].Value = "Entity Name";
            y++;

            sheet.Cells[x, y].Value = "Record Id";
            y++;

            sheet.Cells[x, y].Value = "Record Name";
            y++;

            sheet.Cells[x, y].Value = "Deleted On";
            y++;

            sheet.Cells[x, y].Value = "Deleted By";
            y++;

            for (int i = 1; i <= y + 1; i++)
            {
                sheet.Cells[x, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells[x, i].Style.Fill.BackgroundColor.SetColor(Color.PowderBlue);
                sheet.Cells[x, i].Style.Font.Bold = true;
            }
        }

        /// <summary>
        /// Adds row header for attribute list
        /// </summary>
        /// <param name="sheet">Worksheet where to write</param>
        /// <param name="x">Row number</param>
        /// <param name="y">Cell number</param>
        private void InsertAttributeData(ExcelWorksheet sheet, AuditHistories audit, int x, int y)
        {
            // Write the header
            sheet.Cells[x, y].Value = audit.AuditId.ToString();
            y++;

            sheet.Cells[x, y].Value = audit.Entity;
            y++;

            sheet.Cells[x, y].Value = audit.RecordId.ToString();
            y++;

            sheet.Cells[x, y].Value = audit.Name;
            y++;

            sheet.Cells[x, y].Value = audit.DeletionDate.ToString("yyyy-MM-dd HH:mm:ss");
            y++;

            sheet.Cells[x, y].Value = audit.DeletedBy;
            y++;
        }


        private void ReportProgress(int percentage, string message)
        {
            if (worker.WorkerReportsProgress)
            {
                worker.ReportProgress(percentage, message);
            }
        }
        #endregion
    }
}
