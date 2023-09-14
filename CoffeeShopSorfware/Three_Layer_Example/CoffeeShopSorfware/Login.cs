using CoffeeShopSorfware.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopSorfware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get input data by user from textbox. 
            string username = txtUsename.Text;
            string password = txtPassword.Text;
            // checking by login function.
            if(login(username, password)) {
                MainLayout ml = new MainLayout();
                this.Hide();
                ml.ShowDialog();
                this.Show();
            }else {
                MessageBox.Show("Wrong username or password!!!", "Login Message");
            }
            
        }

        private bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }


        private void btnCanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit the program?", "Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void heading_Click(object sender, EventArgs e)
        {

        }
    }
}
