
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
    public partial class frmBarangayLeader : Form
    {
        DBConnect dbcon = new DBConnect();
        StringFormat strFormat = new StringFormat();
        Template template;
        List<string>[] barangay_list;
        string barangay_leader_id;

        public frmBarangayLeader(Template template, int selectedIndex, List<string>[] barangay_list)
        {
            InitializeComponent();
            this.barangay_list = barangay_list;
            this.template = template;
            template.setAction("Create");
            lblTitle.Text = "Create Barangay Leader";

            foreach (string barangay_name in barangay_list[1])
            {
                cmbBarangay.Items.Add(barangay_name);
            }
            dtpBirthdate.Value = DateTime.Now.AddYears(-18);
            cmbBarangay.SelectedIndex = selectedIndex;

        }
        public frmBarangayLeader(Template template, string barangay_leader_id, int selectedIndex, List<string>[] barangay_list)
        {
            InitializeComponent();
            this.barangay_list = barangay_list;
            this.barangay_leader_id = barangay_leader_id;
            this.template = template;
            template.setAction("Update");
            lblTitle.Text = "Update Barangay Leader";

            foreach (string barangay_name in barangay_list[1])
            {
                cmbBarangay.Items.Add(barangay_name);
            }

            cmbBarangay.SelectedIndex = selectedIndex;

            List<string> barangay_leader_details = new List<string>();

            barangay_leader_details = dbcon.SelectPersonDetail("brgy_leader", barangay_leader_id);

            txtFirstname.Text = barangay_leader_details[1];
            txtMiddlename.Text = barangay_leader_details[3];
            txtLastname.Text = barangay_leader_details[2];
            txtSuffix.Text = barangay_leader_details[4];
            txtPrecinctNo.Text = barangay_leader_details[5];
            txtContactNo.Text = barangay_leader_details[6];
            dtpBirthdate.Text = barangay_leader_details[7];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean fn = string.IsNullOrWhiteSpace(txtFirstname.Text),
                    ln = string.IsNullOrWhiteSpace(txtLastname.Text),
                    cn = string.IsNullOrWhiteSpace(txtContactNo.Text);
            if (fn || ln)
            {
                MessageBox.Show("MISSING! " + (ln? " Lastname" : "") + (fn ? ", Firstname" : ""), "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cn)
                {
                    submitForm();
                }
                else
                {
                    if (txtContactNo.Text.Length != 11)
                    {
                        MessageBox.Show("Contact number is incorrect", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        submitForm();
                    }
                } 
            } 
        }

        //Add Person
        private void submitForm()
        {
            string firstname = strFormat.formatter(txtFirstname.Text);
            string middlename = strFormat.formatter(txtMiddlename.Text);
            string lastname = strFormat.formatter(txtLastname.Text);
            string suffix = strFormat.formatter(txtSuffix.Text);
            string precintNo = txtPrecinctNo.Text.ToUpper();
            string birthdate = dtpBirthdate.Text.Replace('/', '-');

            string _ = middlename.CompareTo("") != 0 ? middlename.Substring(0, 1) + ". " : "";
            string value = $"{lastname}, {firstname} {_}{suffix}{precintNo}";

            template.setValue(value);
            template.setStatus("Save");

            int bl_count = 0;
            int fl_count = 0;
            int fm_count = 0;

            //Validates if name already exist
            if (barangay_leader_id == null) //create
                bl_count = dbcon.PersonValidation("bl", lastname, firstname, middlename, suffix);
            else //update
                bl_count = dbcon.PersonValidation("bl", lastname, firstname, middlename, suffix, barangay_leader_id);
            fl_count = dbcon.PersonValidation("fl", lastname, firstname, middlename, suffix);
            fm_count = dbcon.PersonValidation("fm", lastname, firstname, middlename, suffix);

            if (bl_count > 0)
            {
                MessageBox.Show("Person already exists in Barangay Leader", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fl_count > 0)
            {
                MessageBox.Show("Person already exists in Family Leader", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (fm_count > 0)
            {
                MessageBox.Show("Person already exists in Family Member", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (barangay_leader_id == null)
                {
                    dbcon.InsertBarangayLeader(barangay_list[0][cmbBarangay.SelectedIndex], lastname, firstname, middlename, suffix, precintNo, txtContactNo.Text, birthdate);
                    this.Close();
                }
                else
                {
                    dbcon.UpdateBarangayLeader(barangay_list[0][cmbBarangay.SelectedIndex], barangay_leader_id, lastname, firstname, middlename, suffix, precintNo, txtContactNo.Text, birthdate);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            template.setStatus("Cancel");
            this.Close();
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
