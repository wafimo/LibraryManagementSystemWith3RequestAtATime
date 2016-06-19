using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemDemoSoft.UI.Admin;

namespace LibraryManagementSystemDemoSoft.UI.Login
{
    public partial class AdminLoginUI : Form
    {
        public AdminLoginUI()
        {
            InitializeComponent();
        }

        private void AdminLoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            LoginUI aUi = new LoginUI();
            aUi.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (adminIdTextBox.Text != "" && passwordTextBox.Text !="")
            {
                if (adminIdTextBox.Text == "admin" && passwordTextBox.Text == "admin")
                {
                    Hide();
                    AdminUI aAdminUi = new AdminUI();
                    aAdminUi.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all the field");
            }
        }
    }
}
