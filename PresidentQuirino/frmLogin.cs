﻿using System;
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
    public partial class frmLogin : Form
    {
        DBConnect dbcon = new DBConnect();
        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icnPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<string> auth_result = dbcon.LoginAuth(txtUsername.Text, txtPassword.Text);
            if (auth_result.Count > 0)
            {
                this.Hide();
                frmMain frmMain = new frmMain(auth_result);
                frmMain.ShowDialog();
            }
            else
            {
                lblAuthMessage.Text = "Incorrect Username or Password";
            }
        }
    }
}
