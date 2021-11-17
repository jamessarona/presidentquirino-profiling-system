
namespace PresidentQuirino
{
    partial class frmSearch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkBarangayLeader = new System.Windows.Forms.CheckBox();
            this.chkFamilyLeader = new System.Windows.Forms.CheckBox();
            this.chkFamilyMember = new System.Windows.Forms.CheckBox();
            this.chkUnpaid = new System.Windows.Forms.CheckBox();
            this.chkPartial = new System.Windows.Forms.CheckBox();
            this.chkFull = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listRecords = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 31);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkBarangayLeader
            // 
            this.chkBarangayLeader.AutoSize = true;
            this.chkBarangayLeader.Checked = true;
            this.chkBarangayLeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBarangayLeader.Location = new System.Drawing.Point(17, 29);
            this.chkBarangayLeader.Name = "chkBarangayLeader";
            this.chkBarangayLeader.Size = new System.Drawing.Size(155, 24);
            this.chkBarangayLeader.TabIndex = 2;
            this.chkBarangayLeader.Text = "Barangay Leader";
            this.chkBarangayLeader.UseVisualStyleBackColor = true;
            // 
            // chkFamilyLeader
            // 
            this.chkFamilyLeader.AutoSize = true;
            this.chkFamilyLeader.Checked = true;
            this.chkFamilyLeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFamilyLeader.Location = new System.Drawing.Point(224, 29);
            this.chkFamilyLeader.Name = "chkFamilyLeader";
            this.chkFamilyLeader.Size = new System.Drawing.Size(128, 24);
            this.chkFamilyLeader.TabIndex = 3;
            this.chkFamilyLeader.Text = "Family Leader";
            this.chkFamilyLeader.UseVisualStyleBackColor = true;
            // 
            // chkFamilyMember
            // 
            this.chkFamilyMember.AutoSize = true;
            this.chkFamilyMember.Checked = true;
            this.chkFamilyMember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFamilyMember.Location = new System.Drawing.Point(406, 29);
            this.chkFamilyMember.Name = "chkFamilyMember";
            this.chkFamilyMember.Size = new System.Drawing.Size(139, 24);
            this.chkFamilyMember.TabIndex = 4;
            this.chkFamilyMember.Text = "Family Member";
            this.chkFamilyMember.UseVisualStyleBackColor = true;
            // 
            // chkUnpaid
            // 
            this.chkUnpaid.AutoSize = true;
            this.chkUnpaid.Checked = true;
            this.chkUnpaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnpaid.Location = new System.Drawing.Point(163, 25);
            this.chkUnpaid.Name = "chkUnpaid";
            this.chkUnpaid.Size = new System.Drawing.Size(81, 24);
            this.chkUnpaid.TabIndex = 7;
            this.chkUnpaid.Text = "Unpaid";
            this.chkUnpaid.UseVisualStyleBackColor = true;
            // 
            // chkPartial
            // 
            this.chkPartial.AutoSize = true;
            this.chkPartial.Checked = true;
            this.chkPartial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPartial.Location = new System.Drawing.Point(84, 25);
            this.chkPartial.Name = "chkPartial";
            this.chkPartial.Size = new System.Drawing.Size(73, 24);
            this.chkPartial.TabIndex = 6;
            this.chkPartial.Text = "Partial";
            this.chkPartial.UseVisualStyleBackColor = true;
            // 
            // chkFull
            // 
            this.chkFull.AutoSize = true;
            this.chkFull.Checked = true;
            this.chkFull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFull.Location = new System.Drawing.Point(28, 25);
            this.chkFull.Name = "chkFull";
            this.chkFull.Size = new System.Drawing.Size(50, 24);
            this.chkFull.TabIndex = 5;
            this.chkFull.Text = "Full";
            this.chkFull.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUnpaid);
            this.groupBox1.Controls.Add(this.chkFull);
            this.groupBox1.Controls.Add(this.chkPartial);
            this.groupBox1.Location = new System.Drawing.Point(675, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFamilyMember);
            this.groupBox2.Controls.Add(this.chkBarangayLeader);
            this.groupBox2.Controls.Add(this.chkFamilyLeader);
            this.groupBox2.Location = new System.Drawing.Point(8, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 67);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listRecords, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1155, 687);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 115);
            this.panel1.TabIndex = 11;
            // 
            // listRecords
            // 
            this.listRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listRecords.HideSelection = false;
            this.listRecords.Location = new System.Drawing.Point(3, 124);
            this.listRecords.Name = "listRecords";
            this.listRecords.Size = new System.Drawing.Size(1149, 560);
            this.listRecords.TabIndex = 12;
            this.listRecords.UseCompatibleStateImageBehavior = false;
            this.listRecords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barangay";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Barangay Leader";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Family Leader";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Family Member";
            this.columnHeader4.Width = 200;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkBarangayLeader;
        private System.Windows.Forms.CheckBox chkFamilyLeader;
        private System.Windows.Forms.CheckBox chkFamilyMember;
        private System.Windows.Forms.CheckBox chkUnpaid;
        private System.Windows.Forms.CheckBox chkPartial;
        private System.Windows.Forms.CheckBox chkFull;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listRecords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}