using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemDemoSoft.DAL.DAO;

namespace LibraryManagementSystemDemoSoft.DAL.Gateway
{
    class BookGateway : BaseGateway
    {
        public bool CheckIfExist(DAO.Book aBook)
        {
            Connection.Open();
            string query = "SELECT * FROM book WHERE book_id = '" + aBook.BookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            while (bReader.Read())
            {
                Connection.Close();
                return true;
            }

            Connection.Close();
            return false;

        }

        public bool SaveThisReader(DAO.Book aBook)
        {
            Connection.Open();
            string query = "INSERT INTO book (book_id , book_name, copy) VALUES ('" + aBook.BookID + "','" + aBook.BookName + "','" + aBook.Copy + "')";
            SqlCommand command = new SqlCommand(query, Connection);

            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;

        }

        public List<Book> LoadBookGridView()
        {
            Connection.Open();
            string query = "SELECT * FROM book";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            List<Book> bookList = new List<Book>();
            while (bReader.Read())
            {
                Book aBook = new Book();
                aBook.BookID = bReader["book_id"].ToString();
                aBook.BookName = bReader["book_name"].ToString();
                aBook.Copy = (int)bReader["copy"];

                bookList.Add(aBook);
            }

            Connection.Close();
            return bookList;
        }


        public bool UpdateBookQuantityForApprove(Request aRequest)
        {
            Connection.Open();
            string query = "UPDATE book SET copy = copy - 1 WHERE book_id = '" + aRequest.ReqBookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateBookQuantityForReturn(Request cRequest)
        {
            Connection.Open();
            string query = "UPDATE book SET copy = copy + 1 WHERE book_id = '" + cRequest.ReqBookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public int CheckIfCopyExist(Request aRequest)
        {
            Connection.Open();
            string query = "SELECT copy FROM book WHERE book_id = '" + aRequest.ReqBookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            int copy = 0;
            while (bReader.Read())
            {
                copy = (int)bReader["copy"];
            }

            Connection.Close();
            return copy;
        }
    }
}
