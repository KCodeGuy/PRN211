using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // member.Email.Equals() && member.Password.Equals(txtPassword.Text)


            if (txtEmail.Text.Equals("admin@fstore.com") && txtPassword.Text.Equals("admin@@") )
            {
                this.Hide();
                frmMain mDIParent = new frmMain
                {
                    
                };
                mDIParent.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your Email or Password is incorrect");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}