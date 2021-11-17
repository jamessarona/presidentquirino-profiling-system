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
    public partial class frmSearch : Form
    {
        DBConnect dbcon = new DBConnect();
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listRecords.Items.Clear();

            if (chkBarangayLeader.Checked)
            {
                List<string>[] barangay_leader_list = dbcon.SelectBarangayLeaderFilterLite(txtSearch.Text);
                for (int i = 0; i < barangay_leader_list[0].Count; i++)
                {
                    ListViewItem item = new ListViewItem(barangay_leader_list[0][i]);
                    item.SubItems.Add(barangay_leader_list[1][i]);
                    listRecords.Items.Add(item);
                }
            }

            if (chkFamilyLeader.Checked)
            {
                List<string>[] family_leader_list = dbcon.SelectFamilyLeaderFilterLite(txtSearch.Text);
                for (int i = 0; i < family_leader_list[0].Count; i++)
                {
                    ListViewItem item = new ListViewItem(family_leader_list[0][i]);
                    item.SubItems.Add(family_leader_list[1][i]);
                    item.SubItems.Add(family_leader_list[2][i]);
                    listRecords.Items.Add(item);
                }
            }

            if (chkFamilyMember.Checked)
            {
                List<string>[] family_member_list = dbcon.SelectFamilyMemberFilterLite(txtSearch.Text);
                for (int i = 0; i < family_member_list[0].Count; i++)
                {
                    ListViewItem item = new ListViewItem(family_member_list[0][i]);
                    item.SubItems.Add(family_member_list[1][i]);
                    item.SubItems.Add(family_member_list[2][i]);
                    item.SubItems.Add(family_member_list[3][i]);
                    listRecords.Items.Add(item);
                }
            }   
        }
    }
}
