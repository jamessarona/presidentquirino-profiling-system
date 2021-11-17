using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresidentQuirino
{
    public partial class frmBarangay : Form
    {
        DBConnect dbcon = new DBConnect();
        StringFormat strFormat = new StringFormat();
        Template template;
        string  id, name;

        public frmBarangay(Template template)
        {
            InitializeComponent();
            lblTitle.Text = "Create Barangay";
            this.template = template;
        }

        public frmBarangay(Template template, string id, string name)
        {
            InitializeComponent();
            lblTitle.Text = "Update Barangay";
            this.template = template;

            //SET VALUES
            this.id = id;
            this.name = name;
            txtName.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            template.setStatus("Cancel");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                txtName.Clear();
                txtName.Focus();
                MessageBox.Show("Barangay Name is required!", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                string barangay = strFormat.formatter(txtName.Text);
                template.setStatus("Save");
                template.setValue(barangay);
                if (id == null && name == null)
                {
                    template.setAction("Create");
                    dbcon.InsertBarangay(barangay);
                }
                else
                {
                    template.setAction("Update");
                    dbcon.UpdateBarangay(id, barangay);
                }

                this.Close();
            }
        }
    }
}
