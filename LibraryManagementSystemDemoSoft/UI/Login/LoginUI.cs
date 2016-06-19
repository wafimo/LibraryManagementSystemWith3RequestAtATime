using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystemDemoSoft.UI.Login;

namespace LibraryManagementSystemDemoSoft
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Hide();
            AdminLoginUI aAdminLoginUi = new AdminLoginUI();
            aAdminLoginUi.Show();
        }

        private void readerButton_Click(object sender, EventArgs e)
        {
            Hide();
            ReaderLoginUI aReaderLoginUi = new ReaderLoginUI();
            aReaderLoginUi.Show();
        }
    }
}
