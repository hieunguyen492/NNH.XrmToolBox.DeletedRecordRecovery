namespace NNH.XrmToolBox.DeleteRecordRecovery
{
    partial class DeleteRecordRecovery
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRecordRecovery));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbLoadEntityAndUser = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShowData = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbRestore = new System.Windows.Forms.ToolStripButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.chkKeepGuid = new System.Windows.Forms.CheckBox();
            this.chkReAssign = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimezone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.chkDisabledUsers = new System.Windows.Forms.CheckBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.gbEntity = new System.Windows.Forms.GroupBox();
            this.cbEntity = new System.Windows.Forms.ComboBox();
            this.txtSearchEntity = new System.Windows.Forms.TextBox();
            this.dgvDeletedData = new System.Windows.Forms.DataGridView();
            this.deletedRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDetailData = new System.Windows.Forms.DataGridView();
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.auditIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metadataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.entityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletionDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbSetting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.gbEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletedRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadEntityAndUser,
            this.tssSeparator1,
            this.tsbShowData,
            this.tsbExport,
            this.tsbRestore});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1261, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbLoadEntityAndUser
            // 
            this.tsbLoadEntityAndUser.Image = global::NNH.XrmToolBox.DeleteRecordRecovery.Properties.Resources.entities;
            this.tsbLoadEntityAndUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLoadEntityAndUser.Name = "tsbLoadEntityAndUser";
            this.tsbLoadEntityAndUser.Size = new System.Drawing.Size(147, 22);
            this.tsbLoadEntityAndUser.Text = "Load entities and users";
            this.tsbLoadEntityAndUser.Click += new System.EventHandler(this.tsbLoadEntityAndUser_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbShowData
            // 
            this.tsbShowData.Image = global::NNH.XrmToolBox.DeleteRecordRecovery.Properties.Resources.search;
            this.tsbShowData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbShowData.Name = "tsbShowData";
            this.tsbShowData.Size = new System.Drawing.Size(124, 22);
            this.tsbShowData.Text = "Show deleted data";
            this.tsbShowData.Click += new System.EventHandler(this.tsbShowData_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::NNH.XrmToolBox.DeleteRecordRecovery.Properties.Resources.icons8_export_excel_16;
            this.tsbExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(129, 22);
            this.tsbExport.Text = "Export deleted data";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbRestore
            // 
            this.tsbRestore.Image = global::NNH.XrmToolBox.DeleteRecordRecovery.Properties.Resources.icons8_forward_arrow_16;
            this.tsbRestore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRestore.Name = "tsbRestore";
            this.tsbRestore.Size = new System.Drawing.Size(108, 22);
            this.tsbRestore.Text = "Restore records";
            this.tsbRestore.Click += new System.EventHandler(this.tsbRestore_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.AutoSize = true;
            this.gbSearch.Controls.Add(this.gbSetting);
            this.gbSearch.Controls.Add(this.groupBox3);
            this.gbSearch.Controls.Add(this.gbUsers);
            this.gbSearch.Controls.Add(this.gbEntity);
            this.gbSearch.Location = new System.Drawing.Point(5, 29);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1238, 185);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.chkKeepGuid);
            this.gbSetting.Controls.Add(this.chkReAssign);
            this.gbSetting.Location = new System.Drawing.Point(6, 98);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(519, 69);
            this.gbSetting.TabIndex = 3;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Recover Settings";
            // 
            // chkKeepGuid
            // 
            this.chkKeepGuid.AutoSize = true;
            this.chkKeepGuid.Checked = true;
            this.chkKeepGuid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepGuid.Location = new System.Drawing.Point(7, 42);
            this.chkKeepGuid.Name = "chkKeepGuid";
            this.chkKeepGuid.Size = new System.Drawing.Size(189, 16);
            this.chkKeepGuid.TabIndex = 4;
            this.chkKeepGuid.Text = "Keep Record Id when recovering";
            this.chkKeepGuid.UseVisualStyleBackColor = true;
            // 
            // chkReAssign
            // 
            this.chkReAssign.AutoSize = true;
            this.chkReAssign.Checked = true;
            this.chkReAssign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReAssign.Location = new System.Drawing.Point(8, 19);
            this.chkReAssign.Name = "chkReAssign";
            this.chkReAssign.Size = new System.Drawing.Size(386, 16);
            this.chkReAssign.TabIndex = 3;
            this.chkReAssign.Text = "If the record owner is disabled user then assigning to the recover user";
            this.chkReAssign.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbTimezone);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpTo);
            this.groupBox3.Controls.Add(this.dtpFrom);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 74);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter date range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "～";
            // 
            // cbTimezone
            // 
            this.cbTimezone.FormattingEnabled = true;
            this.cbTimezone.Location = new System.Drawing.Point(85, 47);
            this.cbTimezone.Name = "cbTimezone";
            this.cbTimezone.Size = new System.Drawing.Size(333, 20);
            this.cbTimezone.TabIndex = 2;
            this.cbTimezone.SelectedIndexChanged += new System.EventHandler(this.cbTimezone_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time zone:";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(243, 18);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(176, 19);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(7, 18);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(176, 19);
            this.dtpFrom.TabIndex = 0;
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.chkDisabledUsers);
            this.gbUsers.Controls.Add(this.cbUser);
            this.gbUsers.Controls.Add(this.txtSearchUser);
            this.gbUsers.Location = new System.Drawing.Point(553, 87);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(636, 79);
            this.gbUsers.TabIndex = 1;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Filter user:";
            // 
            // chkDisabledUsers
            // 
            this.chkDisabledUsers.AutoSize = true;
            this.chkDisabledUsers.Location = new System.Drawing.Point(7, 50);
            this.chkDisabledUsers.Name = "chkDisabledUsers";
            this.chkDisabledUsers.Size = new System.Drawing.Size(138, 16);
            this.chkDisabledUsers.TabIndex = 9;
            this.chkDisabledUsers.Text = "Include disabled users";
            this.chkDisabledUsers.UseVisualStyleBackColor = true;
            this.chkDisabledUsers.CheckedChanged += new System.EventHandler(this.chkDisabledUsers_CheckedChanged);
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(250, 18);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(371, 20);
            this.cbUser.TabIndex = 1;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchUser.Location = new System.Drawing.Point(8, 18);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(236, 19);
            this.txtSearchUser.TabIndex = 7;
            this.txtSearchUser.Text = "Enter user name...";
            this.txtSearchUser.Enter += new System.EventHandler(this.txtSearchUser_Enter);
            this.txtSearchUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchUser_KeyUp);
            this.txtSearchUser.Leave += new System.EventHandler(this.txtSearchUser_Leave);
            // 
            // gbEntity
            // 
            this.gbEntity.Controls.Add(this.cbEntity);
            this.gbEntity.Controls.Add(this.txtSearchEntity);
            this.gbEntity.Location = new System.Drawing.Point(553, 18);
            this.gbEntity.Name = "gbEntity";
            this.gbEntity.Size = new System.Drawing.Size(636, 60);
            this.gbEntity.TabIndex = 0;
            this.gbEntity.TabStop = false;
            this.gbEntity.Text = "Filter entity:";
            // 
            // cbEntity
            // 
            this.cbEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntity.FormattingEnabled = true;
            this.cbEntity.Location = new System.Drawing.Point(250, 18);
            this.cbEntity.Name = "cbEntity";
            this.cbEntity.Size = new System.Drawing.Size(371, 20);
            this.cbEntity.TabIndex = 6;
            // 
            // txtSearchEntity
            // 
            this.txtSearchEntity.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchEntity.Location = new System.Drawing.Point(8, 18);
            this.txtSearchEntity.Name = "txtSearchEntity";
            this.txtSearchEntity.Size = new System.Drawing.Size(236, 19);
            this.txtSearchEntity.TabIndex = 5;
            this.txtSearchEntity.Text = "Enter entity schema name or display name...";
            this.txtSearchEntity.Enter += new System.EventHandler(this.txtSearchEntity_Enter);
            this.txtSearchEntity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchEntity_KeyUp);
            this.txtSearchEntity.Leave += new System.EventHandler(this.txtSearchEntity_Leave);
            // 
            // dgvDeletedData
            // 
            this.dgvDeletedData.AllowUserToAddRows = false;
            this.dgvDeletedData.AllowUserToDeleteRows = false;
            this.dgvDeletedData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeletedData.AutoGenerateColumns = false;
            this.dgvDeletedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDeletedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.entityDataGridViewTextBoxColumn1,
            this.deletionDateDataGridViewTextBoxColumn1,
            this.deletedByDataGridViewTextBoxColumn1,
            this.recordIdDataGridViewTextBoxColumn1});
            this.dgvDeletedData.DataSource = this.deletedRecordBindingSource;
            this.dgvDeletedData.Location = new System.Drawing.Point(0, 0);
            this.dgvDeletedData.Name = "dgvDeletedData";
            this.dgvDeletedData.ReadOnly = true;
            this.dgvDeletedData.RowTemplate.Height = 21;
            this.dgvDeletedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDeletedData.Size = new System.Drawing.Size(547, 437);
            this.dgvDeletedData.TabIndex = 6;
            this.dgvDeletedData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeletedData_CellClick);
            // 
            // deletedRecordBindingSource
            // 
            this.deletedRecordBindingSource.DataSource = typeof(NNH.XrmToolBox.DeleteRecordRecovery.Models.AuditHistories);
            // 
            // dgvDetailData
            // 
            this.dgvDetailData.AllowUserToAddRows = false;
            this.dgvDetailData.AllowUserToDeleteRows = false;
            this.dgvDetailData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailData.AutoGenerateColumns = false;
            this.dgvDetailData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldNameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgvDetailData.DataSource = this.detailBindingSource;
            this.dgvDetailData.Location = new System.Drawing.Point(-1, 0);
            this.dgvDetailData.Name = "dgvDetailData";
            this.dgvDetailData.ReadOnly = true;
            this.dgvDetailData.RowTemplate.Height = 21;
            this.dgvDetailData.Size = new System.Drawing.Size(682, 434);
            this.dgvDetailData.TabIndex = 7;
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            this.fieldNameDataGridViewTextBoxColumn.DataPropertyName = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            this.fieldNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 150F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataSource = typeof(NNH.XrmToolBox.DeleteRecordRecovery.Models.DeletedFields);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(5, 220);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDeletedData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetailData);
            this.splitContainer1.Size = new System.Drawing.Size(1238, 437);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 6;
            // 
            // auditIdDataGridViewTextBoxColumn
            // 
            this.auditIdDataGridViewTextBoxColumn.DataPropertyName = "AuditId";
            this.auditIdDataGridViewTextBoxColumn.HeaderText = "AuditId";
            this.auditIdDataGridViewTextBoxColumn.Name = "auditIdDataGridViewTextBoxColumn";
            this.auditIdDataGridViewTextBoxColumn.Width = 22;
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            this.recordIdDataGridViewTextBoxColumn.Width = 22;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 21;
            // 
            // entityDataGridViewTextBoxColumn
            // 
            this.entityDataGridViewTextBoxColumn.DataPropertyName = "Entity";
            this.entityDataGridViewTextBoxColumn.HeaderText = "Entity";
            this.entityDataGridViewTextBoxColumn.Name = "entityDataGridViewTextBoxColumn";
            this.entityDataGridViewTextBoxColumn.Width = 22;
            // 
            // metadataDataGridViewTextBoxColumn
            // 
            this.metadataDataGridViewTextBoxColumn.DataPropertyName = "Metadata";
            this.metadataDataGridViewTextBoxColumn.HeaderText = "Metadata";
            this.metadataDataGridViewTextBoxColumn.Name = "metadataDataGridViewTextBoxColumn";
            this.metadataDataGridViewTextBoxColumn.Width = 22;
            // 
            // deletionDateDataGridViewTextBoxColumn
            // 
            this.deletionDateDataGridViewTextBoxColumn.DataPropertyName = "DeletionDate";
            this.deletionDateDataGridViewTextBoxColumn.HeaderText = "DeletionDate";
            this.deletionDateDataGridViewTextBoxColumn.Name = "deletionDateDataGridViewTextBoxColumn";
            this.deletionDateDataGridViewTextBoxColumn.Width = 22;
            // 
            // deletedByDataGridViewTextBoxColumn
            // 
            this.deletedByDataGridViewTextBoxColumn.DataPropertyName = "DeletedBy";
            this.deletedByDataGridViewTextBoxColumn.HeaderText = "DeletedBy";
            this.deletedByDataGridViewTextBoxColumn.Name = "deletedByDataGridViewTextBoxColumn";
            this.deletedByDataGridViewTextBoxColumn.Width = 21;
            // 
            // auditDetailDataGridViewTextBoxColumn
            // 
            this.auditDetailDataGridViewTextBoxColumn.DataPropertyName = "AuditDetail";
            this.auditDetailDataGridViewTextBoxColumn.HeaderText = "AuditDetail";
            this.auditDetailDataGridViewTextBoxColumn.Name = "auditDetailDataGridViewTextBoxColumn";
            this.auditDetailDataGridViewTextBoxColumn.Width = 22;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 133.3157F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Record Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // entityDataGridViewTextBoxColumn1
            // 
            this.entityDataGridViewTextBoxColumn1.DataPropertyName = "Entity";
            this.entityDataGridViewTextBoxColumn1.HeaderText = "Entity";
            this.entityDataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.entityDataGridViewTextBoxColumn1.Name = "entityDataGridViewTextBoxColumn1";
            this.entityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // deletionDateDataGridViewTextBoxColumn1
            // 
            this.deletionDateDataGridViewTextBoxColumn1.DataPropertyName = "DeletionDate";
            dataGridViewCellStyle1.Format = "yyyy/MM/dd HH:mm:ss";
            dataGridViewCellStyle1.NullValue = null;
            this.deletionDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.deletionDateDataGridViewTextBoxColumn1.HeaderText = "Deleted Date";
            this.deletionDateDataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.deletionDateDataGridViewTextBoxColumn1.Name = "deletionDateDataGridViewTextBoxColumn1";
            this.deletionDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // deletedByDataGridViewTextBoxColumn1
            // 
            this.deletedByDataGridViewTextBoxColumn1.DataPropertyName = "DeletedBy";
            this.deletedByDataGridViewTextBoxColumn1.HeaderText = "Deleted By";
            this.deletedByDataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.deletedByDataGridViewTextBoxColumn1.Name = "deletedByDataGridViewTextBoxColumn1";
            this.deletedByDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // recordIdDataGridViewTextBoxColumn1
            // 
            this.recordIdDataGridViewTextBoxColumn1.DataPropertyName = "RecordId";
            this.recordIdDataGridViewTextBoxColumn1.FillWeight = 150F;
            this.recordIdDataGridViewTextBoxColumn1.HeaderText = "Record Id";
            this.recordIdDataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.recordIdDataGridViewTextBoxColumn1.Name = "recordIdDataGridViewTextBoxColumn1";
            this.recordIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DeleteRecordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "DeleteRecordRecovery";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1261, 660);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.gbEntity.ResumeLayout(false);
            this.gbEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletedRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbLoadEntityAndUser;
        private System.Windows.Forms.ToolStripButton tsbShowData;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox gbEntity;
        private System.Windows.Forms.ComboBox cbEntity;
        private System.Windows.Forms.TextBox txtSearchEntity;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimezone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.CheckBox chkDisabledUsers;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.CheckBox chkKeepGuid;
        private System.Windows.Forms.CheckBox chkReAssign;
        private System.Windows.Forms.BindingSource deletedRecordBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDetailData;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metadataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private System.Windows.Forms.DataGridView dgvDeletedData;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbRestore;
        private System.Windows.Forms.DataGridViewLinkColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletionDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn1;
    }
}
