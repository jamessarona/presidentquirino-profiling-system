
namespace PresidentQuirino
{
    partial class frmOverview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPopulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPayment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLocationExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBarangay = new System.Windows.Forms.ComboBox();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.lblInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocationExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPopulation
            // 
            this.chartPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartPopulation.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartPopulation.Legends.Add(legend1);
            this.chartPopulation.Location = new System.Drawing.Point(4, 563);
            this.chartPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.chartPopulation.Name = "chartPopulation";
            this.chartPopulation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPopulation.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(87)))), ((int)(((byte)(87))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(166)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Barangay Leader";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Family Leader";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Family Member";
            this.chartPopulation.Series.Add(series1);
            this.chartPopulation.Series.Add(series2);
            this.chartPopulation.Series.Add(series3);
            this.chartPopulation.Size = new System.Drawing.Size(954, 488);
            this.chartPopulation.TabIndex = 1;
            this.chartPopulation.TabStop = false;
            this.chartPopulation.Text = "chart1";
            title1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Database Population";
            this.chartPopulation.Titles.Add(title1);
            // 
            // chartPayment
            // 
            this.chartPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartPayment.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartPayment.Legends.Add(legend2);
            this.chartPayment.Location = new System.Drawing.Point(966, 563);
            this.chartPayment.Margin = new System.Windows.Forms.Padding(4);
            this.chartPayment.Name = "chartPayment";
            this.chartPayment.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPayment.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))))};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPayment.Series.Add(series4);
            this.chartPayment.Size = new System.Drawing.Size(954, 488);
            this.chartPayment.TabIndex = 2;
            this.chartPayment.TabStop = false;
            this.chartPayment.Text = "chart1";
            title2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Payment";
            this.chartPayment.Titles.Add(title2);
            // 
            // chartLocationExpenses
            // 
            this.chartLocationExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chartLocationExpenses.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartLocationExpenses.Legends.Add(legend3);
            this.chartLocationExpenses.Location = new System.Drawing.Point(966, 67);
            this.chartLocationExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.chartLocationExpenses.Name = "chartLocationExpenses";
            this.chartLocationExpenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartLocationExpenses.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))))};
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Barangay Leader";
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Family Leader";
            series7.ChartArea = "ChartArea1";
            series7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Family Member";
            this.chartLocationExpenses.Series.Add(series5);
            this.chartLocationExpenses.Series.Add(series6);
            this.chartLocationExpenses.Series.Add(series7);
            this.chartLocationExpenses.Size = new System.Drawing.Size(954, 488);
            this.chartLocationExpenses.TabIndex = 7;
            this.chartLocationExpenses.TabStop = false;
            this.chartLocationExpenses.Text = "chart1";
            title3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Expenses per Barangay";
            this.chartLocationExpenses.Titles.Add(title3);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(4, 67);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))))};
            series8.ChartArea = "ChartArea1";
            series8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Barangay Leader";
            series9.ChartArea = "ChartArea1";
            series9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Family Leader";
            series10.ChartArea = "ChartArea1";
            series10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            series10.IsValueShownAsLabel = true;
            series10.Legend = "Legend1";
            series10.Name = "Family Member";
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(954, 488);
            this.chart1.TabIndex = 8;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Expenses";
            this.chart1.Titles.Add(title4);
            this.chart1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.cmbBarangay);
            this.panel1.Controls.Add(this.lblBarangay);
            this.panel1.Location = new System.Drawing.Point(966, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 55);
            this.panel1.TabIndex = 6;
            // 
            // cmbBarangay
            // 
            this.cmbBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarangay.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarangay.FormattingEnabled = true;
            this.cmbBarangay.Location = new System.Drawing.Point(155, 11);
            this.cmbBarangay.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBarangay.Name = "cmbBarangay";
            this.cmbBarangay.Size = new System.Drawing.Size(336, 35);
            this.cmbBarangay.TabIndex = 3;
            this.cmbBarangay.TabStop = false;
            this.cmbBarangay.SelectedIndexChanged += new System.EventHandler(this.cmbBarangay_SelectedIndexChanged);
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarangay.Location = new System.Drawing.Point(1, 15);
            this.lblBarangay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(102, 22);
            this.lblBarangay.TabIndex = 4;
            this.lblBarangay.Text = "Barangay";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartLocationExpenses, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartPopulation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartPayment, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 1055);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.cmbDate);
            this.panel2.Controls.Add(this.lblInterval);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 55);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.cmbDate.Location = new System.Drawing.Point(128, 11);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(336, 35);
            this.cmbDate.TabIndex = 3;
            this.cmbDate.TabStop = false;
            this.cmbDate.SelectedIndexChanged += new System.EventHandler(this.cmbDate_SelectedIndexChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(4, 15);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(81, 22);
            this.lblInterval.TabIndex = 4;
            this.lblInterval.Text = "Interval";
            // 
            // frmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOverview";
            this.Text = "frmMasterList";
            ((System.ComponentModel.ISupportInitialize)(this.chartPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocationExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopulation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLocationExpenses;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBarangay;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label lblInterval;
    }
}