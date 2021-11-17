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
    public partial class frmPersonProfile : Form
    {
        DBConnect dbcon = new DBConnect();
        StringFormat strFormat = new StringFormat();
        List<string> selected_person_details, barangay_details, 
                        barangay_leader_details, family_leader_details;
        int family_leader_count, family_member_count;
        public frmPersonProfile(string id, string table)
        {
            InitializeComponent();

            selected_person_details = dbcon.SelectPersonDetail(table, id);

            lblLastname.Text = selected_person_details[2].ToUpper() + ",";
            lblFirstname.Text = selected_person_details[1].ToUpper();
            lblMiddlename.Text = selected_person_details[3].ToUpper();
            lblSuffix.Text = selected_person_details[4].ToUpper();
            lblBirthday.Text = selected_person_details[7];
            lblContact.Text = selected_person_details[6];
            lblPrecinct.Text = selected_person_details[5];

            if(table.CompareTo("brgy_leader") == 0)
            {
                barangay_details = dbcon.GetLeaderName(table, id);

                family_leader_count = dbcon.CountSubordinates("1", "fam_leader", id);
                family_member_count = dbcon.CountSubordinates("0", "fam_member", id);
                 
                lblBarangay.Text += ": " + barangay_details[1];
                lblBarangayLeader.Text += ": " + selected_person_details[1] + " " + (selected_person_details[3] != "" ? (selected_person_details[3] + " ") : "") + selected_person_details[2] + " " + selected_person_details[4];
                lblFamilyLeader.Text += ": " + strFormat.NumberToWords(family_leader_count) + "(" + family_leader_count + ") subordinate" + (family_leader_count > 1 ? "s" : "") + " exist";
                lblFamilyMember.Text += ": " + strFormat.NumberToWords(family_member_count) + "(" + family_member_count + ") subordinate" + (family_member_count > 1 ? "s" : "") + " exist";

            }
            else if(table.CompareTo("fam_leader") == 0)
            {
                barangay_leader_details = dbcon.GetLeaderName(table, id);
                barangay_details = dbcon.GetLeaderName("brgy_leader", barangay_leader_details[0]);

                family_member_count = dbcon.CountSubordinates("1", "fam_member", id);

                lblBarangay.Text += ": " + barangay_details[1];
                lblBarangayLeader.Text += ": " + barangay_leader_details[1];
                lblFamilyLeader.Text += ": " + selected_person_details[1] + " " + (selected_person_details[3] != "" ? (selected_person_details[3] + " ") : "") + selected_person_details[2] + " " + selected_person_details[4];
                lblFamilyMember.Text += ": " + strFormat.NumberToWords(family_member_count) + "(" + family_member_count + ") subordinate" + (family_member_count > 1 ? "s" : "") + " exist";
            }
            else
            {
                family_leader_details = dbcon.GetLeaderName(table, id);
                barangay_leader_details = dbcon.GetLeaderName("fam_leader", family_leader_details[0]);
                barangay_details = dbcon.GetLeaderName("brgy_leader", barangay_leader_details[0]);

                lblBarangay.Text += ": " + barangay_details[1];
                lblBarangayLeader.Text += ": " + barangay_leader_details[1];
                lblFamilyLeader.Text += ": " + family_leader_details[1];
                lblFamilyMember.Text += ": " + selected_person_details[1] + " " + (selected_person_details[3] != "" ? (selected_person_details[3] + " ") : "") + selected_person_details[2] + " " + selected_person_details[4];
            }
        }
    }
}
