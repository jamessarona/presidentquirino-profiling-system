
namespace PresidentQuirino
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnEncode = new FontAwesome.Sharp.IconButton();
            this.btnSignout = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnMasterList = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.icnCurrentIcon = new FontAwesome.Sharp.IconButton();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlMenu.Controls.Add(this.btnEncode);
            this.pnlMenu.Controls.Add(this.btnSignout);
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnMasterList);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 1041);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnEncode
            // 
            this.btnEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncode.FlatAppearance.BorderSize = 0;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(148)))));
            this.btnEncode.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnEncode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(148)))));
            this.btnEncode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEncode.IconSize = 32;
            this.btnEncode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.Location = new System.Drawing.Point(0, 260);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnEncode.Size = new System.Drawing.Size(220, 60);
            this.btnEncode.TabIndex = 5;
            this.btnEncode.TabStop = false;
            this.btnEncode.Text = "Encode";
            this.btnEncode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.Red;
            this.btnSignout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSignout.IconColor = System.Drawing.Color.Red;
            this.btnSignout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignout.IconSize = 32;
            this.btnSignout.Location = new System.Drawing.Point(0, 981);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnSignout.Size = new System.Drawing.Size(220, 60);
            this.btnSignout.TabIndex = 4;
            this.btnSignout.TabStop = false;
            this.btnSignout.Text = "Signout";
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(148)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(148)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 200);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnSearch.Size = new System.Drawing.Size(220, 60);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnMasterList
            // 
            this.btnMasterList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterList.FlatAppearance.BorderSize = 0;
            this.btnMasterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(148)))));
            this.btnMasterList.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnMasterList.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(148)))));
            this.btnMasterList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMasterList.IconSize = 32;
            this.btnMasterList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterList.Location = new System.Drawing.Point(0, 140);
            this.btnMasterList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasterList.Name = "btnMasterList";
            this.btnMasterList.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnMasterList.Size = new System.Drawing.Size(220, 60);
            this.btnMasterList.TabIndex = 2;
            this.btnMasterList.TabStop = false;
            this.btnMasterList.Text = "Overview";
            this.btnMasterList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMasterList.UseVisualStyleBackColor = true;
            this.btnMasterList.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 140);
            this.pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 16);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(196, 102);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlTitleBar.Controls.Add(this.icnCurrentIcon);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1704, 75);
            this.pnlTitleBar.TabIndex = 3;
            // 
            // icnCurrentIcon
            // 
            this.icnCurrentIcon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.icnCurrentIcon.Enabled = false;
            this.icnCurrentIcon.FlatAppearance.BorderSize = 0;
            this.icnCurrentIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnCurrentIcon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnCurrentIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.icnCurrentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icnCurrentIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.icnCurrentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnCurrentIcon.IconSize = 39;
            this.icnCurrentIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnCurrentIcon.Location = new System.Drawing.Point(5, 11);
            this.icnCurrentIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icnCurrentIcon.Name = "icnCurrentIcon";
            this.icnCurrentIcon.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.icnCurrentIcon.Size = new System.Drawing.Size(396, 60);
            this.icnCurrentIcon.TabIndex = 5;
            this.icnCurrentIcon.Text = "Home";
            this.icnCurrentIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnCurrentIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnCurrentIcon.UseVisualStyleBackColor = true;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 75);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1704, 966);
            this.pnlDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 330);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(143, 95);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.iconButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1917, 1037);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "President Quirino";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnMasterList;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnSignout;
        private FontAwesome.Sharp.IconButton icnCurrentIcon;
        private FontAwesome.Sharp.IconButton btnEncode;
    }
}