namespace PresidentQuirino
{
    partial class frmPayment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.listPayment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPerson = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(132, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(433, 41);
            this.lblTitle.TabIndex = 70;
            this.lblTitle.Text = "Payment Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(506, 645);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(117, 43);
            this.btnDone.TabIndex = 5;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // listPayment
            // 
            this.listPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPayment.FullRowSelect = true;
            this.listPayment.HideSelection = false;
            this.listPayment.Location = new System.Drawing.Point(47, 323);
            this.listPayment.Margin = new System.Windows.Forms.Padding(4);
            this.listPayment.MultiSelect = false;
            this.listPayment.Name = "listPayment";
            this.listPayment.Size = new System.Drawing.Size(601, 302);
            this.listPayment.TabIndex = 4;
            this.listPayment.TabStop = false;
            this.listPayment.UseCompatibleStateImageBehavior = false;
            this.listPayment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "date";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "amount";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 180;
            // 
            // listPerson
            // 
            this.listPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listPerson.Enabled = false;
            this.listPerson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPerson.FullRowSelect = true;
            this.listPerson.GridLines = true;
            this.listPerson.HideSelection = false;
            this.listPerson.Location = new System.Drawing.Point(47, 86);
            this.listPerson.Margin = new System.Windows.Forms.Padding(4);
            this.listPerson.MultiSelect = false;
            this.listPerson.Name = "listPerson";
            this.listPerson.Size = new System.Drawing.Size(601, 84);
            this.listPerson.TabIndex = 72;
            this.listPerson.TabStop = false;
            this.listPerson.UseCompatibleStateImageBehavior = false;
            this.listPerson.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id";
            this.columnHeader4.Width = 35;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "name";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "precinct #";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "contact #";
            this.columnHeader7.Width = 115;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(47, 189);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(270, 36);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2021, 10, 28, 0, 0, 0, 0);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(43, 235);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 22);
            this.lblAmount.TabIndex = 75;
            this.lblAmount.Text = "Amount";
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(511, 264);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 35);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(372, 263);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.AutoSize = true;
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(47, 263);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(248, 36);
            this.nudAmount.TabIndex = 1;
            this.nudAmount.Tag = "";
            this.nudAmount.ThousandsSeparator = true;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 716);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.listPerson);
            this.Controls.Add(this.listPayment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListView listPayment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listPerson;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}