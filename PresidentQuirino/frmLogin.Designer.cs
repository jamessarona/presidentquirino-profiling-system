
namespace PresidentQuirino
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAuthMessage = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.icnPassword = new FontAwesome.Sharp.IconButton();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.icnUser = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 530);
            this.panel1.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "President Quirino";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(53, 190);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(182, 34);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Welcome to";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresidentQuirino.Properties.Resources.president_quirino_logo;
            this.pictureBox1.Location = new System.Drawing.Point(117, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblAuthMessage);
            this.panel2.Controls.Add(this.pnlPassword);
            this.panel2.Controls.Add(this.pnlUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(355, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 530);
            this.panel2.TabIndex = 80;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(19, 316);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnExit.Location = new System.Drawing.Point(173, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAuthMessage
            // 
            this.lblAuthMessage.AutoSize = true;
            this.lblAuthMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthMessage.ForeColor = System.Drawing.Color.Red;
            this.lblAuthMessage.Location = new System.Drawing.Point(28, 288);
            this.lblAuthMessage.Name = "lblAuthMessage";
            this.lblAuthMessage.Size = new System.Drawing.Size(0, 19);
            this.lblAuthMessage.TabIndex = 10;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Controls.Add(this.icnPassword);
            this.pnlPassword.Location = new System.Drawing.Point(6, 240);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(498, 45);
            this.pnlPassword.TabIndex = 89;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(53, 9);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(440, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // icnPassword
            // 
            this.icnPassword.BackColor = System.Drawing.Color.White;
            this.icnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnPassword.FlatAppearance.BorderSize = 0;
            this.icnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.icnPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.icnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnPassword.IconSize = 28;
            this.icnPassword.Location = new System.Drawing.Point(19, 5);
            this.icnPassword.Name = "icnPassword";
            this.icnPassword.Size = new System.Drawing.Size(28, 36);
            this.icnPassword.TabIndex = 0;
            this.icnPassword.TabStop = false;
            this.icnPassword.UseVisualStyleBackColor = false;
            this.icnPassword.Click += new System.EventHandler(this.icnPassword_Click);
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.White;
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Controls.Add(this.icnUser);
            this.pnlUsername.Location = new System.Drawing.Point(6, 189);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(498, 45);
            this.pnlUsername.TabIndex = 41;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(53, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(440, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // icnUser
            // 
            this.icnUser.BackColor = System.Drawing.Color.White;
            this.icnUser.FlatAppearance.BorderSize = 0;
            this.icnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.icnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnUser.IconSize = 28;
            this.icnUser.Location = new System.Drawing.Point(19, 9);
            this.icnUser.Name = "icnUser";
            this.icnUser.Size = new System.Drawing.Size(28, 30);
            this.icnUser.TabIndex = 0;
            this.icnUser.TabStop = false;
            this.icnUser.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(38, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login to your account";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.Location = new System.Drawing.Point(454, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Profiling System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(878, 530);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton icnPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private FontAwesome.Sharp.IconButton icnUser;
        private System.Windows.Forms.Label lblAuthMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
    }
}