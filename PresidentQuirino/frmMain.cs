using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace PresidentQuirino
{
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMain(List<string> auth_result)
        {
            InitializeComponent();
             
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 49);
            pnlMenu.Controls.Add(leftBorderBtn); 
        }


        private void ActiveButton(object btnSender, Color customColor)
        {
            if (btnSender != null)
            {
                DisableButton();
                currentBtn = (IconButton)btnSender;
                currentBtn.BackColor = Color.FromArgb(57, 60, 67);
                currentBtn.ForeColor = customColor;
                currentBtn.IconColor = customColor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorderBtn.BackColor = customColor;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true; 
                leftBorderBtn.BringToFront();
                
                icnCurrentIcon.IconChar = currentBtn.IconChar;
                icnCurrentIcon.IconColor = customColor;
                icnCurrentIcon.Text = currentBtn.Text; 
                icnCurrentIcon.IconSize = 39;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(32, 34, 37);
                currentBtn.ForeColor = Color.FromArgb(139,143,148);
                currentBtn.IconColor = Color.FromArgb(139, 143, 148);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;

            }
        }
        
        public void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childform);
            pnlDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void Reset(Color customColor)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icnCurrentIcon.IconChar = IconChar.Home;
            icnCurrentIcon.IconColor = Color.FromArgb(239, 239, 239);
            icnCurrentIcon.Text = "Home";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                Reset(Color.FromArgb(57,60,67));
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(239, 239, 239));
            OpenChildForm(new frmEncode());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(239, 239, 239));
            OpenChildForm(new frmOverview());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(239, 239, 239));
            OpenChildForm(new frmSearch());
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Template template = new Template();

            frmLogout frmLogout = new frmLogout(template);
            frmLogout.ShowDialog();
            switch (template.getValue())
            {
                case "Yes":
                    this.Hide();
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.ShowDialog();
                    break;
            }
        }
    }
}
