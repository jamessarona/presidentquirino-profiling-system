using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentQuirino
{
    public partial class frmOverview : Form
    {
        List<string> barangay;
        List<string> position = new List<string> { "bl", "fl", "fm" };
        DBConnect dbcon = new DBConnect();

        public frmOverview()
        {
            InitializeComponent();
            this.barangay = dbcon.SelectBarangay()[1];
            foreach (string b in barangay) 
                cmbBarangay.Items.Add(b);
            if (cmbBarangay.Items.Count > 0)
                cmbBarangay.SelectedIndex = 0;

            cmbDate.SelectedIndex = 0;
            chartPopulation_Load();
        }

        private void chartPopulation_Load()
        {
            chartPopulation.Series[0].Points.Clear();
            chartPopulation.Series[1].Points.Clear();
            chartPopulation.Series[2].Points.Clear();
            foreach (string b in barangay)
            {
                foreach (string p in position)
                {
                    List<int> population = dbcon.CountPopulation(p, b);
                    int count = population.Sum();
                    switch (p)
                    {
                        case "bl":
                            chartPopulation.Series["Barangay Leader"].Points.AddXY(b, count);
                            break;
                        case "fl":
                            chartPopulation.Series["Family Leader"].Points.AddXY(b, count);
                            break;
                        case "fm":
                            chartPopulation.Series["Family Member"].Points.AddXY(b, count);
                            break;
                    }
                }
            }
        }

        private void chartLocationExpenses_Load()
        {
            foreach (string p in position)
            {
                double sum = dbcon.SumPaymentAmount(cmbBarangay.Text, p);
                switch (p)
                {
                    case "bl":
                        chartLocationExpenses.Series["Barangay Leader"].Points.AddXY("", sum);
                        break;
                    case "fl":
                        chartLocationExpenses.Series["Family Leader"].Points.AddXY("", sum);
                        break;
                    case "fm":
                        chartLocationExpenses.Series["Family Member"].Points.AddXY("", sum);
                        break;
                }
            }
        }

        private void chartPayment_Load()
        {
            int paid = 0, partial = 0, unpaid = 0;
            string cmbBarangaySelectedItem = cmbBarangay.Text;
            foreach (string p in position)
            {
                List<int> population = dbcon.CountPositionPayment(p, cmbBarangaySelectedItem);
                foreach (int i in population)
                {
                    switch (p)
                    {
                        case "bl":
                        case "fl":
                            if (i >= 3)
                                paid += 1;
                            else if (i == 1 || i == 2)
                                partial += 1;
                            else
                                unpaid += 1;
                            break;
                        case "fm":
                            if (i >= 1)
                                paid += 1;
                            else
                                unpaid += 1;
                            break;
                    }
                }
            }

            chartPayment.Series["Series1"].Points.AddXY("FULL", paid);
            chartPayment.Series["Series1"].Points.AddXY("PARTIAL", partial);
            chartPayment.Series["Series1"].Points.AddXY("UNPAID", unpaid);
        }

        private void btnPopulationLoad_Click(object sender, EventArgs e)
        {
            chartPopulation_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartPayment_Load();
        }

        private void cmbBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartPayment.Series[0].Points.Clear();
            chartLocationExpenses.Series[0].Points.Clear();
            chartLocationExpenses.Series[1].Points.Clear();
            chartLocationExpenses.Series[2].Points.Clear();
            chartPayment_Load();
            chartLocationExpenses_Load();
            chartLocationExpenses.ChartAreas[0].AxisX.Title = cmbBarangay.Text;
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
