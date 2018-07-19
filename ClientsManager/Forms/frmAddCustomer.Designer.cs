namespace ClientsManager.Forms
{
    partial class frmAddCustomer
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.lblCaseId = new System.Windows.Forms.Label();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtCaseID = new System.Windows.Forms.TextBox();
            this.txtBusiness = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(275, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblBusiness
            // 
            this.lblBusiness.AutoSize = true;
            this.lblBusiness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBusiness.Location = new System.Drawing.Point(24, 88);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(49, 13);
            this.lblBusiness.TabIndex = 10;
            this.lblBusiness.Text = "Business";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(24, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhone1.Location = new System.Drawing.Point(356, 26);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(47, 13);
            this.lblPhone1.TabIndex = 2;
            this.lblPhone1.Text = "Phone 1";
            // 
            // lblCaseId
            // 
            this.lblCaseId.AutoSize = true;
            this.lblCaseId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCaseId.Location = new System.Drawing.Point(685, 26);
            this.lblCaseId.Name = "lblCaseId";
            this.lblCaseId.Size = new System.Drawing.Size(45, 13);
            this.lblCaseId.TabIndex = 8;
            this.lblCaseId.Text = "Case ID";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhone2.Location = new System.Drawing.Point(524, 26);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(47, 13);
            this.lblPhone2.TabIndex = 4;
            this.lblPhone2.Text = "Phone 2";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblID.Location = new System.Drawing.Point(192, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID Number";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(27, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(195, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(140, 20);
            this.txtID.TabIndex = 17;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(359, 42);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(140, 20);
            this.txtPhone1.TabIndex = 18;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(527, 42);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(140, 20);
            this.txtPhone2.TabIndex = 19;
            // 
            // txtCaseID
            // 
            this.txtCaseID.Location = new System.Drawing.Point(688, 42);
            this.txtCaseID.Name = "txtCaseID";
            this.txtCaseID.Size = new System.Drawing.Size(140, 20);
            this.txtCaseID.TabIndex = 20;
            // 
            // txtBusiness
            // 
            this.txtBusiness.Location = new System.Drawing.Point(27, 105);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.Size = new System.Drawing.Size(223, 20);
            this.txtBusiness.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(276, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 11);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Required";
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBusiness);
            this.Controls.Add(this.txtCaseID);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBusiness);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPhone2);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.lblCaseId);
            this.KeyPreview = true;
            this.Name = "frmAddCustomer";
            this.Text = "Add New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.Label lblCaseId;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtCaseID;
        private System.Windows.Forms.TextBox txtBusiness;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
    }
}