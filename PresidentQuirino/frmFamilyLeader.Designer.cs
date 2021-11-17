
namespace PresidentQuirino
{
    partial class frmFamilyLeader
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.cmbBarangayLeader = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecinctNo = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(438, 528);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(574, 528);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(572, 349);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(167, 22);
            this.lblContactNo.TabIndex = 71;
            this.lblContactNo.Text = "Contact Number";
            this.lblContactNo.Click += new System.EventHandler(this.lblContactNo_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContactNo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(576, 376);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(272, 36);
            this.txtContactNo.TabIndex = 6;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // cmbBarangayLeader
            // 
            this.cmbBarangayLeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBarangayLeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBarangayLeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarangayLeader.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarangayLeader.FormattingEnabled = true;
            this.cmbBarangayLeader.Location = new System.Drawing.Point(278, 456);
            this.cmbBarangayLeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBarangayLeader.Name = "cmbBarangayLeader";
            this.cmbBarangayLeader.Size = new System.Drawing.Size(569, 35);
            this.cmbBarangayLeader.TabIndex = 7;
            this.cmbBarangayLeader.SelectedIndexChanged += new System.EventHandler(this.cmbBarangayLeader_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(345, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(433, 41);
            this.lblTitle.TabIndex = 70;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(277, 428);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(172, 22);
            this.lblProcess.TabIndex = 69;
            this.lblProcess.Text = "Barangay Leader";
            this.lblProcess.Click += new System.EventHandler(this.lblProcess_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 68;
            this.label5.Text = "Precinct Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Suffix";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "Middlename";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 65;
            this.label2.Text = "Firstname *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Lastname *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrecinctNo
            // 
            this.txtPrecinctNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecinctNo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecinctNo.Location = new System.Drawing.Point(279, 376);
            this.txtPrecinctNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecinctNo.Name = "txtPrecinctNo";
            this.txtPrecinctNo.Size = new System.Drawing.Size(272, 36);
            this.txtPrecinctNo.TabIndex = 5;
            this.txtPrecinctNo.TextChanged += new System.EventHandler(this.txtPrecinctNo_TextChanged);
            // 
            // txtSuffix
            // 
            this.txtSuffix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSuffix.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuffix.Location = new System.Drawing.Point(577, 213);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(147, 36);
            this.txtSuffix.TabIndex = 3;
            this.txtSuffix.TextChanged += new System.EventHandler(this.txtSuffix_TextChanged);
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiddlename.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(279, 213);
            this.txtMiddlename.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(272, 36);
            this.txtMiddlename.TabIndex = 2;
            this.txtMiddlename.TextChanged += new System.EventHandler(this.txtMiddlename_TextChanged);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(576, 136);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(272, 36);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(279, 136);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(272, 36);
            this.txtLastname.TabIndex = 0;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(278, 264);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(99, 22);
            this.lblBirthdate.TabIndex = 90;
            this.lblBirthdate.Text = "Birth date";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthdate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(279, 291);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(273, 36);
            this.dtpBirthdate.TabIndex = 4;
            this.dtpBirthdate.Value = new System.DateTime(2021, 10, 28, 0, 0, 0, 0);
            // 
            // frmFamilyLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 676);
            this.ControlBox = false;
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.cmbBarangayLeader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecinctNo);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFamilyLeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.ComboBox cmbBarangayLeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecinctNo;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
    }
}