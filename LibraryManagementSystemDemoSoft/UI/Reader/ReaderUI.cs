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

namespace LibraryManagementSystemDemoSoft.UI
{
    public partial class ReaderUI : Form
    {
        public ReaderUI(string readerID)
        {
            InitializeComponent();
            label4.Text = DateTime.Today.ToLongDateString();
            readerIDTextBox.Text = readerID;
            LoadReaderInfo();
            LoadBookGridView();
            LoadTempReqGridView();
            LoadApprovedBoolGridView();
        }

        private void LoadApprovedBoolGridView()
        {
            RequestManager aRequestManager = new RequestManager();

            List<Request> approveList = new List<Request>();
            approveList = aRequestManager.LoadApprovedBoolGridView(readerIDTextBox.Text);
            int serialNumber = 1;
            approvedBookListGridView.Rows.Clear();
            foreach (var approve in approveList)
            {
                approvedBookListGridView.Rows.Add(serialNumber, approve.ReqBookID, approve.BookName, approve.Return_Date.ToShortDateString());
                serialNumber++;
            }
        }

        private void LoadReaderInfo()
        {
            ReaderManager aReaderManager = new ReaderManager();
            readerNameTextBox.Text = aReaderManager.LoadReaderInfo(readerIDTextBox.Text);
        }

        private void ReaderUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            LoginUI aUi = new LoginUI();
            aUi.Show();
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

        public void AddBookToGridButton_Click(object sender, EventArgs e)
        {
            if (requestedBookID.Text != "")
            {
                RequestManager aRequestManager = new RequestManager();
                Request aRequest = new Request();
                aRequest.ReqReaderID = readerIDTextBox.Text;
                aRequest.ReqBookID = requestedBookID.Text;

                MessageBox.Show(aRequestManager.SaveToTemporaryReq(aRequest));
                
                LoadTempReqGridView();
                requestedBookID.Clear();
            }
            else
            {
                MessageBox.Show("Empty Request field. Please Enter Book Id to continue");
            }
        }

        private void LoadTempReqGridView()
        {
            RequestManager aRequestManager = new RequestManager();

            List<Request> requestList = new List<Request>();
            requestList = aRequestManager.LoadTemporaryRequestedBookGridView(readerIDTextBox.Text);
            int serialNumber = 1;
            temporaryRequestedBookGridView.Rows.Clear();
            foreach (var request in requestList)
            {
                temporaryRequestedBookGridView.Rows.Add(serialNumber, request.ReqBookID, request.Status);
                serialNumber++;
            }
        }

        private void bookListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = bookListGridView.Rows[e.RowIndex];
            requestedBookID.Text = row.Cells[1].Value.ToString();
        }

        private void clearRequestedBookButton_Click(object sender, EventArgs e)
        {
            RequestManager aRequestManager = new RequestManager();
            MessageBox.Show(aRequestManager.ClearThisBookFromTempReq(clearRequestedBookTextBox.Text, readerIDTextBox.Text));
            LoadTempReqGridView();
            clearRequestedBookTextBox.Clear();
        }

        private void temporaryRequestedBookGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = temporaryRequestedBookGridView.Rows[e.RowIndex];
            clearRequestedBookTextBox.Text = row.Cells[1].Value.ToString();
        }



        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if (returnBookIDTextBox.Text != "")
            {
                RequestManager aRequestManager = new RequestManager();
                Request cRequest = new Request();
                cRequest.ReqReaderID = readerIDTextBox.Text;
                cRequest.ReqBookID = returnBookIDTextBox.Text;
                if (feeTextBox.Text == "")
                {
                    cRequest.Fee = 0;
                }
                else
                {
                    cRequest.Fee = Convert.ToInt32(feeTextBox.Text);
                }

                MessageBox.Show(aRequestManager.ReturnThisBook(cRequest));

                LoadApprovedBoolGridView();
                LoadBookGridView();
            }
            else
            {
                MessageBox.Show("empty field");
            }
        }

        private void approvedBookListGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = approvedBookListGridView.Rows[e.RowIndex];
            returnBookIDTextBox.Text = row.Cells[1].Value.ToString();
        }
    }
}
