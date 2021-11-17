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
	public partial class frmEncode : Form
	{
		DBConnect dbcon = new DBConnect();
		List<string>[] barangay_list, barangay_leader_list, family_leader_list, family_member_list;

		public frmEncode()
		{
			InitializeComponent();
			cmbBarangay_Load();
		}

		/*THIS BLOCK IS RESPONSIBLE FOR BARANGAY */

		private void cmbBarangay_Load()
		{
			cmbBarangay.Items.Clear();
			barangay_list = dbcon.SelectBarangay();

			foreach (string barangay_name in barangay_list[1])
			{
				cmbBarangay.Items.Add(barangay_name);
			}

			if (cmbBarangay.Items.Count > 0)
			{
				cmbBarangay.SelectedIndex = 0;
			}
		}

		private void btnBarangayCreate_Click(object sender, EventArgs e)
		{
			Template template = new Template();
			Form frmBarangay = new frmBarangay(template);
			frmBarangay.ShowDialog();
			cmbBarangay_Load();
			if (template.getStatus().CompareTo("Save") == 0) //Save button is pressed
            {
				if (template.getAction().CompareTo("Create") == 0) //Create new barangay
                {
					cmbBarangay.SelectedIndex = cmbBarangay.Items.IndexOf(template.getValue());
                }
            }
		}

		private void btnBarangayUpdate_Click(object sender, EventArgs e)
		{
			if (cmbBarangay.SelectedItem == null)
			{
				MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Template template = new Template();
				Form frmBarangay = new frmBarangay(template, barangay_list[0][cmbBarangay.SelectedIndex], barangay_list[1][cmbBarangay.SelectedIndex]);
				frmBarangay.ShowDialog();
				cmbBarangay_Load();
				if (template.getStatus().CompareTo("Save") == 0) //Save button is pressed
				{
					if (template.getAction().CompareTo("Update") == 0) //Update old barangay
					{
						cmbBarangay.SelectedIndex = cmbBarangay.Items.IndexOf(template.getValue());
					}
				}
			}
		}

		private void btnBarangayDelete_Click(object sender, EventArgs e)
		{
			if (cmbBarangay.SelectedItem == null)
			{
				MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				int count = dbcon.CountBarangayLeader(barangay_list[0][cmbBarangay.SelectedIndex]);
				if(count > 0)
                {
					MessageBox.Show($"{barangay_list[1][cmbBarangay.SelectedIndex]} contains {count} barangay leader.", "Invalid Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
                {
					DialogResult dialogResult = MessageBox.Show($"Do you want to delete Barangay {cmbBarangay.SelectedItem}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (dialogResult == DialogResult.Yes)
					{
						dbcon.DeleteBarangay(barangay_list[0][cmbBarangay.SelectedIndex]);
						cmbBarangay_Load();
					}
				}
			}
		}

		private void cmbBarangay_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBarangayLeader_Load(1);
		}

		/*THIS BLOCK IS RESPONSIBLE FOR BARANGAY LEADER */

		private void chkBL_CheckedChanged(object sender, EventArgs e)
		{
			listBarangayLeader_Load(1);
		}

		private void listBarangayLeader_Load(int p)
		{
			listBarangayLeader.Items.Clear();
			listFamilyLeader.Items.Clear();
			listFamilyMember.Items.Clear();
			try
			{
				if (p == 1)
					barangay_leader_list = dbcon.SelectBarangayLeader(barangay_list[0][cmbBarangay.SelectedIndex]);
				else
					barangay_leader_list = dbcon.SelectBarangayLeaderFilter(barangay_list[0][cmbBarangay.SelectedIndex], txtBoxBarangayLeaderSearch.Text);

				for (int i = 0; i < barangay_leader_list[0].Count; i++)
				{
					
					int count = dbcon.CountPayment(barangay_leader_list[0][i], "BL");
					if (chkBL_full.Checked && count >= 3)
                    {
						ListViewItem item = new ListViewItem((i + 1).ToString());
						item.SubItems.Add(barangay_leader_list[1][i]);
						item.SubItems.Add(barangay_leader_list[2][i]);
						item.SubItems.Add(barangay_leader_list[3][i]);
						item.SubItems.Add($"FULL({count})");
						listBarangayLeader.Items.Add(item);
					}
                    else if (chkBL_partial.Checked && (count == 1 || count == 2))
                    {
						ListViewItem item = new ListViewItem((i + 1).ToString());
						item.SubItems.Add(barangay_leader_list[1][i]);
						item.SubItems.Add(barangay_leader_list[2][i]);
						item.SubItems.Add(barangay_leader_list[3][i]);
						item.SubItems.Add($"PARTIAL({count})");
						listBarangayLeader.Items.Add(item);
					}
                    else if (chkBL_unpaid.Checked && count == 0)
					{
						ListViewItem item = new ListViewItem((i + 1).ToString());
						item.SubItems.Add(barangay_leader_list[1][i]);
						item.SubItems.Add(barangay_leader_list[2][i]);
						item.SubItems.Add(barangay_leader_list[3][i]);
						item.SubItems.Add("UNPAID(0)");
						listBarangayLeader.Items.Add(item);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void btnBarangayLeaderSearch_Click(object sender, EventArgs e)
		{
			listBarangayLeader_Load(2);
		}

		private void btnBarangayLeaderCreate_Click(object sender, EventArgs e)
		{
			if (cmbBarangay.SelectedItem == null)
			{
				MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Template template = new Template();
				Form frmBarangayLeader = new frmBarangayLeader(template, cmbBarangay.SelectedIndex, barangay_list);
				frmBarangayLeader.ShowDialog();
				listBarangayLeader_Load(1);
                if (template.getStatus().CompareTo("Save") == 0) //Save button is pressed
                {
                    if (template.getAction().CompareTo("Create") == 0) //Create new barangay leader
                    {
						for (int i = 0; i < listBarangayLeader.Items.Count; i++)
                        {
							string _ = listBarangayLeader.Items[i].SubItems[1].Text + listBarangayLeader.Items[i].SubItems[2].Text;
							if (template.getValue().CompareTo(_) == 0)
							{
								listBarangayLeader.Items[i].Selected = true;
								listBarangayLeader.EnsureVisible(i);
								break;
							}
						}
                    }
                }
            }
		}

		private void btnBarangayLeaderUpdate_Click(object sender, EventArgs e)
		{
			if (cmbBarangay.SelectedIndex == -1)
			{
				MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (listBarangayLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Barangay Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Template template = new Template();
				string barangay_leader_id = barangay_leader_list[0][listBarangayLeader.SelectedIndices[0]];
				Form frmBarangayLeader = new frmBarangayLeader(template, barangay_leader_id, cmbBarangay.SelectedIndex, barangay_list);
				frmBarangayLeader.ShowDialog();
				listBarangayLeader_Load(1);
				if (template.getStatus().CompareTo("Save") == 0) //Save button is pressed
				{
					if (template.getAction().CompareTo("Update") == 0) //Create new barangay leader
					{
						for (int i = 0; i < listBarangayLeader.Items.Count; i++)
						{
							string _ = listBarangayLeader.Items[i].SubItems[1].Text + listBarangayLeader.Items[i].SubItems[2].Text;
							if (template.getValue().CompareTo(_) == 0)
							{
								listBarangayLeader.Items[i].Selected = true;
								listBarangayLeader.EnsureVisible(i);
								break;
							}
						}
					}
				}
			}
			 
		}

		private void btnBarangayLeaderDelete_Click(object sender, EventArgs e)
		{
			if (listBarangayLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Barangay Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				int count = dbcon.CountFamilyLeader(barangay_leader_list[0][listBarangayLeader.SelectedIndices[0]]);
				if (count > 0)
				{
					MessageBox.Show($"{barangay_leader_list[1][listBarangayLeader.SelectedIndices[0]]} contains {count} family leader.", "Invalid Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
                else
                {
					ListViewItem item = listBarangayLeader.SelectedItems[0]; 
					DialogResult dialogResult = MessageBox.Show($"Do you want to delete {item.SubItems[1].Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (dialogResult == DialogResult.Yes)
					{
						dbcon.DeletePayments(barangay_leader_list[0][listBarangayLeader.SelectedIndices[0]], "BL");
						dbcon.DeleteBarangayLeader(barangay_leader_list[0][listBarangayLeader.SelectedIndices[0]]);
						listBarangayLeader_Load(1);
					}
				}
			}
		}

		private void btnBarangayLeaderPayment_Click(object sender, EventArgs e)
		{
			if (listBarangayLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Barangay Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
            {
				Template template = new Template();
				string value = listBarangayLeader.SelectedItems[0].SubItems[1].Text + listBarangayLeader.SelectedItems[0].SubItems[2].Text;
				template.setValue(value);
				ListViewItem item = listBarangayLeader.SelectedItems[0];
				Form frmPayment = new frmPayment(item, barangay_leader_list[0][listBarangayLeader.SelectedIndices[0]], "BL", template);
				frmPayment.ShowDialog();
				listBarangayLeader_Load(1);
				for (int i = 0; i < listBarangayLeader.Items.Count; i++)
				{
					string _ = listBarangayLeader.Items[i].SubItems[1].Text + listBarangayLeader.Items[i].SubItems[2].Text;
					if (template.getValue().CompareTo(_) == 0)
					{
						listBarangayLeader.Items[i].Selected = true;
						listBarangayLeader.EnsureVisible(i);
						break;
					}
				}
			}
		}

		private void listBarangayLeader_SelectedIndexChanged(object sender, EventArgs e)
		{
			listFamilyLeader_Load(1);
		}

		//THIS BLOCK IS RESPONSIBLE FOR FAMILY LEADER

		private void chkFL_CheckedChanged(object sender, EventArgs e)
		{
			listFamilyLeader_Load(1);
		}

		private void listFamilyLeader_Load(int p)
        {
            listFamilyLeader.Items.Clear();
			listFamilyMember.Items.Clear();
            try
            {
                if (barangay_leader_list != null)
                {
					string barangay_leader_id = barangay_leader_list[0][listBarangayLeader.SelectedIndices[0]];
					if (p == 1)
						family_leader_list = dbcon.SelectFamilyLeader(barangay_leader_id);
					else
						family_leader_list = dbcon.SelectFamilyLeaderFilter(barangay_leader_id, txtFamilyLeaderSearch.Text);
					for (int i = 0; i < family_leader_list[0].Count; i++)
					{
						int count = dbcon.CountPayment(family_leader_list[0][i], "FL");
						if (chkFL_full.Checked && count >= 3)
						{
							ListViewItem item = new ListViewItem((i + 1).ToString());
							item.SubItems.Add(family_leader_list[1][i]);
							item.SubItems.Add(family_leader_list[2][i]);
							item.SubItems.Add(family_leader_list[3][i]);
							item.SubItems.Add($"FULL({count})");
							listFamilyLeader.Items.Add(item);
						}
						else if (chkFL_partial.Checked && (count == 1 || count == 2))
						{
							ListViewItem item = new ListViewItem((i + 1).ToString());
							item.SubItems.Add(family_leader_list[1][i]);
							item.SubItems.Add(family_leader_list[2][i]);
							item.SubItems.Add(family_leader_list[3][i]);
							item.SubItems.Add($"PARTIAL({count})");
							listFamilyLeader.Items.Add(item);
						}
						else if (chkFL_unpaid.Checked && count == 0)
						{
							ListViewItem item = new ListViewItem((i + 1).ToString());
							item.SubItems.Add(family_leader_list[1][i]);
							item.SubItems.Add(family_leader_list[2][i]);
							item.SubItems.Add(family_leader_list[3][i]);
							item.SubItems.Add("UNPAID(0)");
							listFamilyLeader.Items.Add(item);
						}
					}
				}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

		private void btnFamilyLeaderSearch_Click(object sender, EventArgs e)
		{
			listFamilyLeader_Load(2);
		}

        private void btnFamilyLeaderCreate_Click(object sender, EventArgs e)
        {
            if (cmbBarangay.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (listBarangayLeader.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please Select a Barangay Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
				Template template = new Template();
                Form frmFamilyLeader = new frmFamilyLeader(template, listBarangayLeader.SelectedIndices[0], barangay_leader_list);
				frmFamilyLeader.ShowDialog();
                listFamilyLeader_Load(1);
				if (template.getStatus().CompareTo("Save") == 0) //Save button is pressed
				{
					if (template.getAction().CompareTo("Create") == 0) //Create new barangay leader
					{
						for (int i = 0; i < listFamilyLeader.Items.Count; i++)
						{
							string _ = listFamilyLeader.Items[i].SubItems[1].Text + listFamilyLeader.Items[i].SubItems[2].Text;
							if (template.getValue().CompareTo(_) == 0)
							{
								listFamilyLeader.Items[i].Selected = true;
								listFamilyLeader.EnsureVisible(i);
								break;
							}
						}
					}
				}
			}


        }

        private void btnFamilyLeaderUpdate_Click(object sender, EventArgs e)
        {

            if (cmbBarangay.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (listBarangayLeader.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please Select a Barangay Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
			else if (listFamilyLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Family Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
            {
				Template template = new Template();
                string family_leader_id = family_leader_list[0][listFamilyLeader.SelectedIndices[0]];
                Form frmFamilyLeader = new frmFamilyLeader(template, family_leader_id, listBarangayLeader.SelectedIndices[0], barangay_leader_list);
                frmFamilyLeader.ShowDialog();
                listFamilyLeader_Load(1);
				if (template.getStatus().CompareTo("Save") == 0) //Create new barangay leader
				{
					if (template.getAction().CompareTo("Update") == 0) //Create new barangay leader
					{
						for (int i = 0; i < listFamilyLeader.Items.Count; i++)
						{
							string _ = listFamilyLeader.Items[i].SubItems[1].Text + listFamilyLeader.Items[i].SubItems[2].Text;
							if (template.getValue().CompareTo(_) == 0)
							{
								listFamilyLeader.Items[i].Selected = true;
								listFamilyLeader.EnsureVisible(i);
								break;
							}
						}
					}
				}
			}
        }

        private void btnFamilyLeaderDelete_Click(object sender, EventArgs e)
        {
            if (listFamilyLeader.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please Select a Family Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
				int count = dbcon.CountFamilyMember(family_leader_list[0][listFamilyLeader.SelectedIndices[0]]);
				if(count > 0)
                {
					MessageBox.Show($"{family_leader_list[1][listFamilyLeader.SelectedIndices[0]]} contains {count} family member.", "Invalid Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					ListViewItem item = listFamilyLeader.SelectedItems[0];
					DialogResult dialogResult = MessageBox.Show($"Do you want to delete {item.SubItems[1].Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (dialogResult == DialogResult.Yes)
					{
						dbcon.DeletePayments(family_leader_list[0][listFamilyLeader.SelectedIndices[0]], "FL");
						dbcon.DeleteFamilyLeader(family_leader_list[0][listFamilyLeader.SelectedIndices[0]]);
						listFamilyLeader_Load(1);
					}
				} 
			}
        }

		private void btnFamilyLeaderPayment_Click(object sender, EventArgs e)
		{
			if (listFamilyLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Family Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Template template = new Template();
				string value = listFamilyLeader.SelectedItems[0].SubItems[1].Text + listFamilyLeader.SelectedItems[0].SubItems[2].Text;
				template.setValue(value);
				ListViewItem item = listFamilyLeader.SelectedItems[0];
				Form frmPayment = new frmPayment(item, family_leader_list[0][listFamilyLeader.SelectedIndices[0]], "FL", template);
				frmPayment.ShowDialog();
				listFamilyLeader_Load(1);
				for (int i = 0; i < listFamilyLeader.Items.Count; i++)
				{
					string _ = listFamilyLeader.Items[i].SubItems[1].Text + listFamilyLeader.Items[i].SubItems[2].Text;
					if (template.getValue().CompareTo(_) == 0)
					{
						listFamilyLeader.Items[i].Selected = true;
						listFamilyLeader.EnsureVisible(i);
						break;
					}
				}
			}
		}

		private void listFamilyLeader_SelectedIndexChanged(object sender, EventArgs e)
		{
			listFamilyMember_Load(1);
		}

		//THIS BLOCK IS RESPONSIBLE FOR FAMILY MEMBER

		private void chkFM_CheckedChanged(object sender, EventArgs e)
		{
			listFamilyMember_Load(1);
		}

		private void listFamilyMember_Load(int p)
        {
            listFamilyMember.Items.Clear();
            try
            {
                if (family_leader_list != null)
                {
					string family_leader_id = family_leader_list[0][listFamilyLeader.SelectedIndices[0]];
					if (p == 1)
						family_member_list = dbcon.SelectFamilyMember(family_leader_id);
					else
						family_member_list = dbcon.SelectFamilyMemberFilter(family_leader_id, txtFamilyMemberSearch.Text);
					for (int i = 0; i < family_member_list[0].Count; i++)
					{

						int count = dbcon.CountPayment(family_member_list[0][i], "FM");
						if (chkFM_full.Checked && count >= 1)
						{
							ListViewItem item = new ListViewItem((i + 1).ToString());
							item.SubItems.Add(family_member_list[1][i]);
							item.SubItems.Add(family_member_list[2][i]);
							item.SubItems.Add(family_member_list[3][i]);
							item.SubItems.Add($"FULL({count})");
							listFamilyMember.Items.Add(item);
						}
						if (chkFM_unpaid.Checked && count == 0)
						{
							ListViewItem item = new ListViewItem((i + 1).ToString());
							item.SubItems.Add(family_member_list[1][i]);
							item.SubItems.Add(family_member_list[2][i]);
							item.SubItems.Add(family_member_list[3][i]);
							item.SubItems.Add("UNPAID(0)");
							listFamilyMember.Items.Add(item);
						}
					}
				}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnFamilyMemberSearch_Click(object sender, EventArgs e)
		{
			listFamilyMember_Load(2);
		}

        private void button8_Click(object sender, EventArgs e)
        {
			if (listFamilyMember.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Family Member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Template template = new Template();
				string value = listFamilyMember.SelectedItems[0].SubItems[1].Text + listFamilyMember.SelectedItems[0].SubItems[2].Text;
				template.setValue(value);
				ListViewItem item = listFamilyMember.SelectedItems[0];
				Form frmPayment = new frmPayment(item, family_member_list[0][listFamilyMember.SelectedIndices[0]], "FM", template);
				frmPayment.ShowDialog();
				listFamilyMember_Load(1);
				for (int i = 0; i < listFamilyMember.Items.Count; i++)
				{
					string _ = listFamilyMember.Items[i].SubItems[1].Text + listFamilyMember.Items[i].SubItems[2].Text;
					if (template.getValue().CompareTo(_) == 0)
					{
						listFamilyMember.Items[i].Selected = true;
						listFamilyMember.EnsureVisible(i);
						break;
					}
				}
			}
		}

        private void listBarangayLeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			Form frmPersonProfile = new frmPersonProfile(barangay_leader_list[0][listBarangayLeader.SelectedIndices[0]], "brgy_leader");
			frmPersonProfile.ShowDialog();
        }

        private void listFamilyLeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			Form frmPersonProfile = new frmPersonProfile(family_leader_list[0][listFamilyLeader.SelectedIndices[0]], "fam_leader");
			frmPersonProfile.ShowDialog();
		}

        private void listFamilyMember_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			Form frmPersonProfile = new frmPersonProfile(family_member_list[0][listFamilyMember.SelectedIndices[0]], "fam_member");
			frmPersonProfile.ShowDialog();
		}

        private void btnFamilyMemberCreate_Click(object sender, EventArgs e)
		{
			if (cmbBarangay.SelectedItem == null)
			{
				MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (listBarangayLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Barangay Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (listFamilyLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Family Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Template template = new Template();
				Form frmFamilyMember = new frmFamilyMember(template, listFamilyLeader.SelectedIndices[0], family_leader_list);
				frmFamilyMember.ShowDialog();
				listFamilyMember_Load(1);
				if (template.getStatus().CompareTo("Save") == 0) //Save button is pressed
				{
					if (template.getAction().CompareTo("Create") == 0) //Create new barangay leader
					{
						for (int i = 0; i < listFamilyMember.Items.Count; i++)
						{
							string _ = listFamilyMember.Items[i].SubItems[1].Text + listFamilyMember.Items[i].SubItems[2].Text;
							if (template.getValue().CompareTo(_) == 0)
							{
								listFamilyMember.Items[i].Selected = true;
								listFamilyMember.EnsureVisible(i);
								break;
							}
						}
					}
				}
			}
		}

		private void btnFamilyMemberUpdate_Click(object sender, EventArgs e)
		{
			if (cmbBarangay.SelectedIndex == -1)
			{
				MessageBox.Show("Please Select a Barangay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (listBarangayLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Barangay Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (listFamilyLeader.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Family Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (listFamilyMember.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Family Member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Template template = new Template();
				string family_member_id = family_member_list[0][listFamilyMember.SelectedIndices[0]];
				Form frmFamilyMember = new frmFamilyMember(template, family_member_id, listFamilyLeader.SelectedIndices[0], family_leader_list);
				frmFamilyMember.ShowDialog();
				listFamilyMember_Load(1);
				if (template.getStatus().CompareTo("Save") == 0) //Save button is pressed
				{
					if (template.getAction().CompareTo("Update") == 0) //Create new barangay leader
					{
						for (int i = 0; i < listFamilyMember.Items.Count; i++)
						{
							string _ = listFamilyMember.Items[i].SubItems[1].Text + listFamilyMember.Items[i].SubItems[2].Text;
							if (template.getValue().CompareTo(_) == 0)
							{
								listFamilyMember.Items[i].Selected = true;
								listFamilyMember.EnsureVisible(i);
								break;
							}
						}
					}
				}
			}
		}

		private void btnFamilyMemberDelete_Click(object sender, EventArgs e)
		{
			if (listFamilyMember.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Select a Family Member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				ListViewItem item = listFamilyMember.SelectedItems[0];
				DialogResult dialogResult = MessageBox.Show($"Do you want to delete {item.SubItems[1].Text}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (dialogResult == DialogResult.Yes)
				{
					dbcon.DeletePayments(family_member_list[0][listFamilyMember.SelectedIndices[0]], "FM");
					dbcon.DeleteFamilyMember(family_member_list[0][listFamilyMember.SelectedIndices[0]]);
					listFamilyMember_Load(1);
				}
			}
		}
	}
}
