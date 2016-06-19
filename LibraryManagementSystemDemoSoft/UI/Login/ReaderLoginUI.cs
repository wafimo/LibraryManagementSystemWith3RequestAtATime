using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemDemoSoft.BLL;
using LibraryManagementSystemDemoSoft.DAL.DAO;

namespace LibraryManagementSystemDemoSoft.UI.Login
{
    public partial class ReaderLoginUI : Form
    {
        public ReaderLoginUI()
        {
            InitializeComponent();
        }

       

        private void readerLoginButton_Click(object sender, EventArgs e)
        {
            if (readerIdTextBox.Text != "" && readerPasswordTextBox.Text != "")
            {
                Reader aReader = new Reader();
                aReader.ReaderID = readerIdTextBox.Text;
                aReader.Password = readerPasswordTextBox.Text;

                ReaderManager aReaderManager = new ReaderManager();

                if (aReaderManager.PermitToLogin(aReader))
                {
                    Hide();
                    ReaderUI aUi = new ReaderUI(readerIdTextBox.Text);
                    aUi.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Reader ID or Password");
                }
            }
            else
            {
                MessageBox.Show("please insert reader id and password");
            }
        }

        private void ReaderLoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            LoginUI aUi = new LoginUI();
            aUi.Show();
        }
    }
}
