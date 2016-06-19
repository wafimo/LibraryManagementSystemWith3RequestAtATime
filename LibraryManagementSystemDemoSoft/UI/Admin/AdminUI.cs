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

namespace LibraryManagementSystemDemoSoft.UI.Admin
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
            LoadBookGridView();
            LoadReaderGridView();
            LoadRequestListForAdminGridView();
        }

        private void LoadRequestListForAdminGridView()
        {

            RequestManager aRequestManager = new RequestManager();

            List<Request> requestList = new List<Request>();
            requestList = aRequestManager.LoadRequestListForAdminGridView();
            int serialNumber = 1;
            requestListForAdminGridView.Rows.Clear();
            foreach (var request in requestList)
            {
                requestListForAdminGridView.Rows.Add(serialNumber,request.ReqReaderID, request.ReqBookID, request.Status);
                serialNumber++;
            }
        }

        private void saveReaderButton_Click(object sender, EventArgs e)
        {

            if (readerIDTextBox.Text != "" && readerNameTextBox.Text != "" && readerPasswordTextBox.Text != "")
            {
                Reader aReader = new Reader();
                aReader.ReaderID = readerIDTextBox.Text;
                aReader.Name = readerNameTextBox.Text;
                aReader.Password = readerPasswordTextBox.Text;

                ReaderManager aReaderManager = new ReaderManager();

                MessageBox.Show(aReaderManager.SaveThisReader(aReader));
                LoadReaderGridView();

                readerIDTextBox.Clear();
                readerNameTextBox.Clear();
                readerPasswordTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Fill up all the required field");
            }
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            if (bookNameTextBox.Text != "" && bookCopyTextBox.Text != "")
            {
                Book aBook = new Book();
                aBook.BookName = bookNameTextBox.Text;
                aBook.Copy = Convert.ToInt32(bookCopyTextBox.Text);
                aBook.BookID = bookIDTextBox.Text;

                BookManager aBookManager = new BookManager();

                MessageBox.Show(aBookManager.SaveThisBook(aBook));
                LoadBookGridView();

                bookIDTextBox.Clear();
                bookCopyTextBox.Clear();
                bookNameTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Fill up the required field");
            }
        }

        private void AdminUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            LoginUI aUi = new LoginUI();
            aUi.Show();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            LoadReaderGridView();
            LoadBookGridView();
        }

        private void LoadBookGridView()
        {
            BookManager aBookManager = new BookManager();
            List<Book> bookList = new List<Book>();
            bookList = aBookManager.LoadBookGridView();
            int serialNumber = 1;
            bookListGridView.Rows.Clear();
            foreach (var book in bookList)
            {
                bookListGridView.Rows.Add(serialNumber, book.BookID, book.BookName, book.Copy);
                serialNumber++;
            }
        }

        private void LoadReaderGridView()
        {
            ReaderManager aReaderManager = new ReaderManager();
            List<Reader> readerList = new List<Reader>();
            readerList = aReaderManager.LoadReaderGridView();
            int serialNumber = 1;
            readerListDataGridView.Rows.Clear();
            foreach (var reader in readerList)
            {
                readerListDataGridView.Rows.Add(serialNumber, reader.ReaderID, reader.Name, reader.Password);
                serialNumber++;
            }
        }

        private void requestListForAdminGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = requestListForAdminGridView.Rows[e.RowIndex];
            requestedReaderIDTextBox.Text = row.Cells[1].Value.ToString();
            requestedBookIDTextBox.Text = row.Cells[2].Value.ToString();
        }

        private void approveRequestButton_Click(object sender, EventArgs e)
        {
            Request aRequest = new Request();
            aRequest.ReqReaderID = requestedReaderIDTextBox.Text;
            aRequest.ReqBookID = requestedBookIDTextBox.Text;
            RequestManager aRequestManager = new RequestManager();

            MessageBox.Show(aRequestManager.ApproveThisrequest(aRequest));
            LoadRequestListForAdminGridView();
        }

        private void denyRequestButton_Click(object sender, EventArgs e)
        {
            Request aRequest = new Request();
            aRequest.ReqReaderID = requestedReaderIDTextBox.Text;
            aRequest.ReqBookID = requestedBookIDTextBox.Text;
            RequestManager aRequestManager = new RequestManager();

            MessageBox.Show(aRequestManager.DenyThisrequest(aRequest));
            LoadRequestListForAdminGridView();
        }
    }
}
