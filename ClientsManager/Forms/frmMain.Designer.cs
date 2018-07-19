namespace ClientsManager.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblName = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbPhone1 = new System.Windows.Forms.ComboBox();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.cmbPhone2 = new System.Windows.Forms.ComboBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbCaseID = new System.Windows.Forms.ComboBox();
            this.lblCaseId = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFileDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.gbxFiles = new System.Windows.Forms.GroupBox();
            this.gbxBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbEmail = new System.Windows.Forms.ComboBox();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.cmbBusiness = new System.Windows.Forms.ComboBox();
            this.gbxFullInfo = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxFiles.SuspendLayout();
            this.gbxBasicInfo.SuspendLayout();
            this.gbxFullInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // cmbName
            // 
            this.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbName.FormattingEnabled = true;
            resources.ApplyResources(this.cmbName, "cmbName");
            this.cmbName.Name = "cmbName";
            this.cmbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbName_KeyUp);
            // 
            // cmbPhone1
            // 
            this.cmbPhone1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPhone1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPhone1.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhone1, "cmbPhone1");
            this.cmbPhone1.Name = "cmbPhone1";
            // 
            // lblPhone1
            // 
            resources.ApplyResources(this.lblPhone1, "lblPhone1");
            this.lblPhone1.Name = "lblPhone1";
            // 
            // cmbPhone2
            // 
            this.cmbPhone2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPhone2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPhone2.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPhone2, "cmbPhone2");
            this.cmbPhone2.Name = "cmbPhone2";
            // 
            // lblPhone2
            // 
            resources.ApplyResources(this.lblPhone2, "lblPhone2");
            this.lblPhone2.Name = "lblPhone2";
            // 
            // cmbID
            // 
            this.cmbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbID.FormattingEnabled = true;
            resources.ApplyResources(this.cmbID, "cmbID");
            this.cmbID.Name = "cmbID";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // cmbCaseID
            // 
            this.cmbCaseID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCaseID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCaseID.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCaseID, "cmbCaseID");
            this.cmbCaseID.Name = "cmbCaseID";
            // 
            // lblCaseId
            // 
            resources.ApplyResources(this.lblCaseId, "lblCaseId");
            this.lblCaseId.Name = "lblCaseId";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDatabaseToolStripMenuItem,
            this.openDatabaseToolStripMenuItem,
            this.saveDatabaseAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.accountSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newDatabaseToolStripMenuItem
            // 
            this.newDatabaseToolStripMenuItem.Name = "newDatabaseToolStripMenuItem";
            resources.ApplyResources(this.newDatabaseToolStripMenuItem, "newDatabaseToolStripMenuItem");
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            resources.ApplyResources(this.openDatabaseToolStripMenuItem, "openDatabaseToolStripMenuItem");
            // 
            // saveDatabaseAsToolStripMenuItem
            // 
            this.saveDatabaseAsToolStripMenuItem.Name = "saveDatabaseAsToolStripMenuItem";
            resources.ApplyResources(this.saveDatabaseAsToolStripMenuItem, "saveDatabaseAsToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            resources.ApplyResources(this.accountSettingsToolStripMenuItem, "accountSettingsToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSearchToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // advancedSearchToolStripMenuItem
            // 
            this.advancedSearchToolStripMenuItem.Name = "advancedSearchToolStripMenuItem";
            resources.ApplyResources(this.advancedSearchToolStripMenuItem, "advancedSearchToolStripMenuItem");
            this.advancedSearchToolStripMenuItem.Click += new System.EventHandler(this.advancedSearchToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.updatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            resources.ApplyResources(this.updatesToolStripMenuItem, "updatesToolStripMenuItem");
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFileName,
            this.clmFileDescription,
            this.clmDateAdded});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.TabStop = false;
            // 
            // clmFileName
            // 
            this.clmFileName.FillWeight = 15F;
            resources.ApplyResources(this.clmFileName, "clmFileName");
            this.clmFileName.Name = "clmFileName";
            // 
            // clmFileDescription
            // 
            this.clmFileDescription.FillWeight = 70F;
            resources.ApplyResources(this.clmFileDescription, "clmFileDescription");
            this.clmFileDescription.Name = "clmFileDescription";
            // 
            // clmDateAdded
            // 
            this.clmDateAdded.FillWeight = 15F;
            resources.ApplyResources(this.clmDateAdded, "clmDateAdded");
            this.clmDateAdded.Name = "clmDateAdded";
            // 
            // btnAddFile
            // 
            resources.ApplyResources(this.btnAddFile, "btnAddFile");
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // gbxFiles
            // 
            resources.ApplyResources(this.gbxFiles, "gbxFiles");
            this.gbxFiles.Controls.Add(this.btnAddFile);
            this.gbxFiles.Controls.Add(this.dataGridView1);
            this.gbxFiles.Name = "gbxFiles";
            this.gbxFiles.TabStop = false;
            // 
            // gbxBasicInfo
            // 
            resources.ApplyResources(this.gbxBasicInfo, "gbxBasicInfo");
            this.gbxBasicInfo.Controls.Add(this.lblEmail);
            this.gbxBasicInfo.Controls.Add(this.cmbEmail);
            this.gbxBasicInfo.Controls.Add(this.lblBusiness);
            this.gbxBasicInfo.Controls.Add(this.cmbBusiness);
            this.gbxBasicInfo.Controls.Add(this.lblName);
            this.gbxBasicInfo.Controls.Add(this.cmbName);
            this.gbxBasicInfo.Controls.Add(this.cmbCaseID);
            this.gbxBasicInfo.Controls.Add(this.lblPhone1);
            this.gbxBasicInfo.Controls.Add(this.lblCaseId);
            this.gbxBasicInfo.Controls.Add(this.cmbPhone1);
            this.gbxBasicInfo.Controls.Add(this.cmbID);
            this.gbxBasicInfo.Controls.Add(this.lblPhone2);
            this.gbxBasicInfo.Controls.Add(this.lblID);
            this.gbxBasicInfo.Controls.Add(this.cmbPhone2);
            this.gbxBasicInfo.Name = "gbxBasicInfo";
            this.gbxBasicInfo.TabStop = false;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // cmbEmail
            // 
            this.cmbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmail.FormattingEnabled = true;
            resources.ApplyResources(this.cmbEmail, "cmbEmail");
            this.cmbEmail.Name = "cmbEmail";
            // 
            // lblBusiness
            // 
            resources.ApplyResources(this.lblBusiness, "lblBusiness");
            this.lblBusiness.Name = "lblBusiness";
            // 
            // cmbBusiness
            // 
            this.cmbBusiness.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBusiness.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBusiness.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBusiness, "cmbBusiness");
            this.cmbBusiness.Name = "cmbBusiness";
            // 
            // gbxFullInfo
            // 
            resources.ApplyResources(this.gbxFullInfo, "gbxFullInfo");
            this.gbxFullInfo.Controls.Add(this.dataGridView2);
            this.gbxFullInfo.Name = "gbxFullInfo";
            this.gbxFullInfo.TabStop = false;
            // 
            // dataGridView2
            // 
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 15F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 70F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 15F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFullInfo);
            this.Controls.Add(this.gbxBasicInfo);
            this.Controls.Add(this.gbxFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxFiles.ResumeLayout(false);
            this.gbxBasicInfo.ResumeLayout(false);
            this.gbxBasicInfo.PerformLayout();
            this.gbxFullInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.ComboBox cmbPhone1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.ComboBox cmbPhone2;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbCaseID;
        private System.Windows.Forms.Label lblCaseId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFileDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateAdded;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.GroupBox gbxFiles;
        private System.Windows.Forms.GroupBox gbxBasicInfo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbEmail;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.ComboBox cmbBusiness;
        private System.Windows.Forms.GroupBox gbxFullInfo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

