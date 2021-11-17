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
    public partial class frmFamilyMember : Form
    {
        DBConnect dbcon = new DBConnect();
        StringFormat strFormat = new StringFormat();
        Template template;
        List<string>[] family_leader_list;
        string family_member_id;
        public frmFamilyMember(Template template, int selectedIndex, List<string>[] family_leader_list)
        {
            InitializeComponent();
            this.family_leader_list = family_leader_list;
            this.template = template;
            template.setAction("Create");
            lblTitle.Text = "Create Family Member";

            foreach (string field in family_leader_list[1])
            {
                cmbFamilyLeader.Items.Add(field);
            }
            dtpBirthdate.Value = DateTime.Now.AddYears(-18);
            cmbFamilyLeader.SelectedIndex = selectedIndex;
        }

        public frmFamilyMember(Template template, string family_member_id, int selectedIndex, List<string>[] family_leader_list)
        {
            InitializeComponent();
            this.family_leader_list = family_leader_list;
            this.family_member_id = family_member_id;
            this.template = template;
            template.setAction("Update");
            lblTitle.Text = "Update Family Member";

            foreach (string family_leader_name in family_leader_list[1])
            {
                cmbFamilyLeader.Items.Add(family_leader_name);
            }

            cmbFamilyLeader.SelectedIndex = selectedIndex;

            List<string> family_member_details = dbcon.SelectPersonDetail("fam_member", family_member_id);

            txtFirstname.Text = family_member_details[1];
            txtMiddlename.Text = family_member_details[3];
            txtLastname.Text = family_member_details[2];
            txtSuffix.Text = family_member_details[4];
            txtPrecinctNo.Text = family_member_details[5];
            txtContactNo.Text = family_member_details[6];
            dtpBirthdate.Text = family_member_details[7];
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            template.setStatus("Cancel");
            this.Close();
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
            bl_count = dbcon.PersonValidation("bl", lastname, firstname, middlename, suffix);
            fl_count = dbcon.PersonValidation("fl", lastname, firstname, middlename, suffix);
            if (family_member_id == null) //create
                fm_count = dbcon.PersonValidation("fm", lastname, firstname, middlename, suffix);
            else
                fm_count = dbcon.PersonValidation("fm", lastname, firstname, middlename, suffix, family_member_id);
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
                if (family_member_id == null)
                {
                    dbcon.InsertFamilyMember(family_leader_list[0][cmbFamilyLeader.SelectedIndex].ToString(), lastname, firstname, middlename, suffix, precintNo, txtContactNo.Text, birthdate);
                    this.Close();
                }
                else
                {
                    dbcon.UpdateFamilyMember(family_leader_list[0][cmbFamilyLeader.SelectedIndex].ToString(), family_member_id, lastname, firstname, middlename, suffix, precintNo, txtContactNo.Text, birthdate);
                    this.Close();
                }
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
