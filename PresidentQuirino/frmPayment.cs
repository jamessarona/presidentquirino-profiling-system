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
    public partial class frmPayment : Form
    {
        string id, position;
        List<string>[] payment_list;
        DBConnect dbcon = new DBConnect();
        Template template;
        
        public frmPayment(ListViewItem item, string id, string position, Template template)
        {
            InitializeComponent();
            dtpDate.Text = DateTime.Now.ToString();
            string a = item.SubItems[0].Text, //id
                   b = item.SubItems[1].Text, //name
                   c = item.SubItems[2].Text, //precinct #
                   d = item.SubItems[3].Text; //contact #
            ListViewItem person = new ListViewItem(a);
            person.SubItems.Add(b);
            person.SubItems.Add(c);
            person.SubItems.Add(d);
            listPerson.Items.Add(person);

            this.id = id;
            this.position = position;
            this.template = template;
            nudAmount.Value = position == "FM" ? 500 : 1000;
            listPayment_Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDate.Text) || string.IsNullOrWhiteSpace(nudAmount.Text))
            {
                MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string date = dtpDate.Text.Replace('/', '-');
                string amount = String.Format("{0:F02}", Convert.ToDecimal(nudAmount.Value));
                Console.WriteLine(amount);
                dbcon.InsertPayment(id, position, date, amount);
                listPayment_Load();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listPayment.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please Select a Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ListViewItem item = listPayment.SelectedItems[0];
                DialogResult dialogResult = MessageBox.Show($"Do you want to delete Payment ({item.SubItems[0].Text})?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    dbcon.DeletePayment(payment_list[0][listPayment.SelectedIndices[0]]);
                    listPayment_Load();
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listPayment_Load()
        {
            listPayment.Items.Clear();
            payment_list = dbcon.SelectPayment(id, position);

            for (int i = 0; i < payment_list[0].Count; i++)
            {

                ListViewItem payment = new ListViewItem((i + 1).ToString());
                payment.SubItems.Add(payment_list[1][i]);
                payment.SubItems.Add($"\u20b1 {String.Format("{0:n}", Convert.ToDecimal(payment_list[2][i]))}");
                listPayment.Items.Add(payment);
            }
        }
    }
}
