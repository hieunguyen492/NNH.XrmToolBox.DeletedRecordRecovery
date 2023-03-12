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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbLoadEntityAndUser = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShowData = new System.Windows.Forms.ToolStripButton();
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
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridRecordName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gridRecordEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRecordDeletedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRecordDeletedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRecordGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDetailData = new System.Windows.Forms.DataGridView();
            this.gridDetailField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDetailValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbSetting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.gbEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletedRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadEntityAndUser,
            this.tssSeparator1,
            this.tsbShowData});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1251, 25);
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
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.gbSetting);
            this.gbSearch.Controls.Add(this.groupBox3);
            this.gbSearch.Controls.Add(this.gbUsers);
            this.gbSearch.Controls.Add(this.gbEntity);
            this.gbSearch.Location = new System.Drawing.Point(5, 29);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1208, 173);
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
            this.chkKeepGuid.TabIndex = 1;
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
            this.chkReAssign.TabIndex = 0;
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
            this.cbTimezone.TabIndex = 7;
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
            this.dtpTo.TabIndex = 2;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(7, 18);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(176, 19);
            this.dtpFrom.TabIndex = 1;
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
            this.txtSearchUser.TabIndex = 0;
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
            this.cbEntity.TabIndex = 1;
            // 
            // txtSearchEntity
            // 
            this.txtSearchEntity.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchEntity.Location = new System.Drawing.Point(8, 18);
            this.txtSearchEntity.Name = "txtSearchEntity";
            this.txtSearchEntity.Size = new System.Drawing.Size(236, 19);
            this.txtSearchEntity.TabIndex = 0;
            this.txtSearchEntity.Text = "Enter entity schema name or display name...";
            this.txtSearchEntity.Enter += new System.EventHandler(this.txtSearchEntity_Enter);
            this.txtSearchEntity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchEntity_KeyUp);
            this.txtSearchEntity.Leave += new System.EventHandler(this.txtSearchEntity_Leave);
            // 
            // dgvDeletedData
            // 
            this.dgvDeletedData.AllowUserToAddRows = false;
            this.dgvDeletedData.AllowUserToDeleteRows = false;
            this.dgvDeletedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDeletedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.gridRecordName,
            this.gridRecordEntityName,
            this.gridRecordDeletedDate,
            this.gridRecordDeletedBy,
            this.gridRecordGuid});
            this.dgvDeletedData.Location = new System.Drawing.Point(5, 209);
            this.dgvDeletedData.Name = "dgvDeletedData";
            this.dgvDeletedData.ReadOnly = true;
            this.dgvDeletedData.RowTemplate.Height = 21;
            this.dgvDeletedData.Size = new System.Drawing.Size(562, 400);
            this.dgvDeletedData.TabIndex = 6;
            this.dgvDeletedData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeletedData_CellClick);
            // 
            // Select
            // 
            this.Select.FillWeight = 25F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // gridRecordName
            // 
            this.gridRecordName.DataPropertyName = "Name";
            this.gridRecordName.HeaderText = "Record Name";
            this.gridRecordName.Name = "gridRecordName";
            this.gridRecordName.ReadOnly = true;
            // 
            // gridRecordEntityName
            // 
            this.gridRecordEntityName.DataPropertyName = "Entity";
            this.gridRecordEntityName.HeaderText = "Entity";
            this.gridRecordEntityName.Name = "gridRecordEntityName";
            this.gridRecordEntityName.ReadOnly = true;
            // 
            // gridRecordDeletedDate
            // 
            this.gridRecordDeletedDate.DataPropertyName = "DeletionDate";
            dataGridViewCellStyle1.Format = "yyyy/MM/dd HH:mm:ss";
            dataGridViewCellStyle1.NullValue = null;
            this.gridRecordDeletedDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridRecordDeletedDate.HeaderText = "Deleted Date";
            this.gridRecordDeletedDate.Name = "gridRecordDeletedDate";
            this.gridRecordDeletedDate.ReadOnly = true;
            // 
            // gridRecordDeletedBy
            // 
            this.gridRecordDeletedBy.DataPropertyName = "DeletedBy";
            this.gridRecordDeletedBy.HeaderText = "Deleted By";
            this.gridRecordDeletedBy.Name = "gridRecordDeletedBy";
            this.gridRecordDeletedBy.ReadOnly = true;
            // 
            // gridRecordGuid
            // 
            this.gridRecordGuid.DataPropertyName = "RecordId";
            this.gridRecordGuid.HeaderText = "Record ID";
            this.gridRecordGuid.Name = "gridRecordGuid";
            this.gridRecordGuid.ReadOnly = true;
            // 
            // deletedRecordBindingSource
            // 
            this.deletedRecordBindingSource.DataSource = typeof(NNH.XrmToolBox.DeleteRecordRecovery.Models.AuditHistories);
            // 
            // dgvDetailData
            // 
            this.dgvDetailData.AllowUserToAddRows = false;
            this.dgvDetailData.AllowUserToDeleteRows = false;
            this.dgvDetailData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridDetailField,
            this.gridDetailValue});
            this.dgvDetailData.Location = new System.Drawing.Point(574, 209);
            this.dgvDetailData.Name = "dgvDetailData";
            this.dgvDetailData.ReadOnly = true;
            this.dgvDetailData.RowTemplate.Height = 21;
            this.dgvDetailData.Size = new System.Drawing.Size(660, 400);
            this.dgvDetailData.TabIndex = 7;
            // 
            // gridDetailField
            // 
            this.gridDetailField.HeaderText = "Field";
            this.gridDetailField.Name = "gridDetailField";
            this.gridDetailField.ReadOnly = true;
            // 
            // gridDetailValue
            // 
            this.gridDetailValue.HeaderText = "Value";
            this.gridDetailValue.Name = "gridDetailValue";
            this.gridDetailValue.ReadOnly = true;
            // 
            // DeleteRecordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDetailData);
            this.Controls.Add(this.dgvDeletedData);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "DeleteRecordRecovery";
            this.Size = new System.Drawing.Size(1251, 612);
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
        private System.Windows.Forms.DataGridView dgvDeletedData;
        private System.Windows.Forms.DataGridView dgvDetailData;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDetailField;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDetailValue;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.CheckBox chkKeepGuid;
        private System.Windows.Forms.CheckBox chkReAssign;
        private System.Windows.Forms.BindingSource deletedRecordBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewLinkColumn gridRecordName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridRecordEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridRecordDeletedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridRecordDeletedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridRecordGuid;
    }
}
