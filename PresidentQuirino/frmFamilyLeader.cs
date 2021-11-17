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
    public partial class frmFamilyLeader : Form
    {
        DBConnect dbcon = new DBConnect();
        StringFormat strFormat = new StringFormat();
        Template template = new Template();
        List<string>[] barangay_leader_list;
        string family_leader_id;

        public frmFamilyLeader(Template template, int selectedIndex, List<string>[] barangay_leader_list)
        {
            InitializeComponent();
            this.barangay_leader_list = barangay_leader_list;
            this.template = template;
            lblTitle.Text = "Create Family Leader";
            template.setAction("Create");
            foreach (string barangay_leader_name in barangay_leader_list[1])
            {
                cmbBarangayLeader.Items.Add(barangay_leader_name);
            }
            dtpBirthdate.Value = DateTime.Now.AddYears(-18);
            cmbBarangayLeader.SelectedIndex = selectedIndex;
        }

        public frmFamilyLeader(Template template, string family_leader_id, int selectedIndex, List<string>[] barangay_leader_list)
        {
            InitializeComponent();
            this.barangay_leader_list = barangay_leader_list;
            this.family_leader_id = family_leader_id;
            this.template = template;
            lblTitle.Text = "Update Family Leader";
            template.setAction("Update");

            foreach (string field in barangay_leader_list[1])
            {
                cmbBarangayLeader.Items.Add(field);
            }

            cmbBarangayLeader.SelectedIndex = selectedIndex;

            List<string> family_leader_details = dbcon.SelectPersonDetail("fam_leader", family_leader_id);

            txtFirstname.Text = family_leader_details[1];
            txtMiddlename.Text = family_leader_details[3];
            txtLastname.Text = family_leader_details[2];
            txtSuffix.Text = family_leader_details[4];
            txtPrecinctNo.Text = family_leader_details[5];
            txtContactNo.Text = family_leader_details[6];
            dtpBirthdate.Text = family_leader_details[7];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean fn = string.IsNullOrWhiteSpace(txtFirstname.Text),
                    ln = string.IsNullOrWhiteSpace(txtLastname.Text),
                    cn = string.IsNullOrWhiteSpace(txtContactNo.Text);
            if (fn || ln)
            {
                MessageBox.Show("MISSING! " + (ln ? " Lastname" : "") + (fn ? ", Firstname" : ""), "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void submitForm()
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
            bl_count = dbcon.PersonValidation("bl", lastname, firstname, middlename, suffix);
            fl_count = dbcon.PersonValidation("fl", lastname, firstname, middlename, suffix);
            fm_count = dbcon.PersonValidation("fm", lastname, firstname, middlename, suffix);

            
            bl_count = dbcon.PersonValidation("bl", lastname, firstname, middlename, suffix);
            if (family_leader_id == null) //create
                fl_count = dbcon.PersonValidation("fl", lastname, firstname, middlename, suffix);
            else
                fl_count = dbcon.PersonValidation("fl", lastname, firstname, middlename, suffix, family_leader_id);
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
            //insert or update the person
            else
            {
                if (family_leader_id == null)
                {

                    dbcon.InsertFamilyLeader(barangay_leader_list[0][cmbBarangayLeader.SelectedIndex].ToString(), lastname, firstname, middlename, suffix, precintNo, txtContactNo.Text, birthdate);
                    this.Close();
                }
                else
                {
                    dbcon.UpdateFamilyLeader(barangay_leader_list[0][cmbBarangayLeader.SelectedIndex].ToString(), family_leader_id, lastname, firstname, middlename, suffix, precintNo, txtContactNo.Text, birthdate);
                    this.Close();
                }
            }
             
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            template.setStatus("Cancel");
            this.Close();
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lblContactNo_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBarangayLeader_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblProcess_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecinctNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuffix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
