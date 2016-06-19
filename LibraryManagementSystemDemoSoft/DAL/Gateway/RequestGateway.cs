using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemDemoSoft.DAL.DAO;

namespace LibraryManagementSystemDemoSoft.DAL.Gateway
{
    internal class RequestGateway : BaseGateway
    {

        public bool CheckIfThisReqExist(Request aRequest)
        {
            Connection.Open();
            string query = "SELECT * FROM temp_req WHERE book_id = '" + aRequest.ReqBookID + "' and reader_id = '" +
                           aRequest.ReqReaderID + "'";
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

        public bool SaveToTemporaryReq(Request aRequest)
        {
            Connection.Open();
            string query = "INSERT INTO temp_req (reader_id , book_id, status) VALUES ('" + aRequest.ReqReaderID + "','" +
                           aRequest.ReqBookID + "' , 'requested')";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public int RequstedItem(Request aRequest)
        {
            Connection.Open();
            string query = "SELECT COUNT(reader_id) FROM temp_req WHERE reader_id = '" + aRequest.ReqReaderID +
                           "' and status = 'requested'";
            SqlCommand command = new SqlCommand(query, Connection);

            int count = (int)command.ExecuteScalar();
            Connection.Close();
            return count;
        }

        public List<Request> LoadTemporaryRequestedBookGridView(string readerID)
        {
            Connection.Open();
            string query = "SELECT * FROM temp_req WHERE reader_id = '" + readerID + "' and status = 'requested'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            List<Request> requestList = new List<Request>();
            while (bReader.Read())
            {
                Request request = new Request();
                request.ReqReaderID = bReader["reader_id"].ToString();
                request.ReqBookID = bReader["book_id"].ToString();
                request.Status = bReader["status"].ToString();
                requestList.Add(request);
            }
            Connection.Close();
            return requestList;
        }

        public bool ClearThisBookFromTempReq(string bookID, string readerID)
        {
            Connection.Open();
            string query = "DELETE FROM temp_req WHERE book_id = '" + bookID + "' and reader_id = '" + readerID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public string CheckIfThisReqApproved(Request aRequest)
        {
            Connection.Open();
            string query = "SELECT * FROM temp_req WHERE book_id = '" + aRequest.ReqBookID + "' and reader_id = '" +
                           aRequest.ReqReaderID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            string status = "";

            while (bReader.Read())
            {

                status = bReader["status"].ToString();
            }

            Connection.Close();
            return status;
        }

        public List<Request> LoadRequestListForAdminGridView()
        {
            Connection.Open();
            string query = "SELECT * FROM temp_req WHERE status = 'requested'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            List<Request> requestList = new List<Request>();
            while (bReader.Read())
            {
                Request request = new Request();
                request.ReqReaderID = bReader["reader_id"].ToString();
                request.ReqBookID = bReader["book_id"].ToString();
                request.Status = bReader["status"].ToString();
                requestList.Add(request);
            }
            Connection.Close();
            return requestList;
        }

        public bool ApproveThisrequest(Request aRequest)
        {
            Connection.Open();
            string query = "UPDATE temp_req SET status = 'approved' WHERE reader_id = '" + aRequest.ReqReaderID +
                           "' and book_id = '" + aRequest.ReqBookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public int ApprovedItem(Request aRequest)
        {
            Connection.Open();
            string query = "SELECT COUNT(reader_id) FROM temp_req WHERE reader_id = '" + aRequest.ReqReaderID +
                           "' and status = 'approved'";
            SqlCommand command = new SqlCommand(query, Connection);

            int count = (int)command.ExecuteScalar();
            Connection.Close();
            return count;
        }

        public List<Request> LoadApprovedBoolGridView(string readerID)
        {
            Connection.Open();
            string query = "SELECT temp_req.book_id, book.book_name, request.returning_date  FROM book INNER JOIN request ON request.request_book_id = book.book_id INNER JOIN temp_req ON temp_req.book_id = book.book_id WHERE temp_req.reader_id = '" + readerID + "' and temp_req.status = 'approved'";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            List<Request> approveList = new List<Request>();
            while (bReader.Read())
            {
                Request request = new Request();
                request.ReqBookID = bReader["book_id"].ToString();
                request.BookName = bReader["book_name"].ToString();
                request.Return_Date = (DateTime)bReader["returning_date"];

                approveList.Add(request);
            }
            Connection.Close();
            return approveList;
        }

        public bool DenyThisrequest(Request aRequest)
        {
            Connection.Open();
            string query = "DELETE FROM temp_req WHERE reader_id = '" + aRequest.ReqReaderID + "' and book_id = '" +
                           aRequest.ReqBookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }



        public bool UpdateReturningDate(Request aRequest)
        {
            Connection.Open();
            string query = "INSERT INTO request (request_reader_id ,request_book_id, returning_date) VALUES ('" + aRequest.ReqReaderID + "','" +
                           aRequest.ReqBookID + "' , '" + DateTime.Today.AddDays(3).ToShortDateString() + "')";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public DateTime TakeReturnDate(Request cRequest)
        {
            Connection.Open();
            string query = "SELECT returning_date FROM request WHERE request_reader_id = '" + cRequest.ReqReaderID + "' and request_book_id = '" + cRequest.ReqBookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            DateTime holder = new DateTime();
            while (bReader.Read())
            {
                holder = (DateTime)bReader["returning_date"];
            }
            Connection.Close();

            return holder;
        }

        public bool ReturnThisBook(Request cRequest)
        {
            Connection.Open();
            string query = "UPDATE temp_req SET status = 'returned' WHERE reader_id = '" + cRequest.ReqReaderID +
                           "' and book_id = '" + cRequest.ReqBookID + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateFee(Request cRequest)
        {
            Connection.Open();
            string query = "INSERT INTO fee (reader_id, book_id, amount) VALUES ('"+cRequest.ReqReaderID+"','"+cRequest.ReqBookID+"','"+cRequest.Fee+"')" ;
            SqlCommand command = new SqlCommand(query, Connection);
            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }
    }
}
