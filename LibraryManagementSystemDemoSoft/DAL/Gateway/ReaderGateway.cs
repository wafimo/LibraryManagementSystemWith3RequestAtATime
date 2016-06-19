using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemDemoSoft.DAL.DAO;

namespace LibraryManagementSystemDemoSoft.DAL.Gateway
{
    class ReaderGateway : BaseGateway
    {
        public bool CheckIfExist(DAO.Reader aReader)
        {
            Connection.Open();
            string query = "SELECT * FROM reader WHERE reader_id = '" + aReader.ReaderID + "'";
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


        public bool SaveThisReader(Reader aReader)
        {
            Connection.Open();
            string query = "INSERT INTO reader (reader_id , name, password) VALUES ('" + aReader.ReaderID + "','" + aReader.Name + "','" + aReader.Password + "')";
            SqlCommand command = new SqlCommand(query, Connection);

            int affectedRow = command.ExecuteNonQuery();
            Connection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool PermitToLogin(Reader aReader)
        {
            Connection.Open();
            string query = "SELECT * FROM reader WHERE reader_id ='" + aReader.ReaderID + "' and password = '" + aReader.Password + "'";
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

        public List<Reader> LoadReaderGridView()
        {
            Connection.Open();
            string query = "SELECT * FROM reader";
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader bReader = command.ExecuteReader();

            List<Reader> readerList = new List<Reader>();
            while (bReader.Read())
            {
                Reader reader = new Reader();
                reader.ReaderID = bReader["reader_id"].ToString();
                reader.Name = bReader["name"].ToString();
                reader.Password = bReader["password"].ToString();

                readerList.Add(reader);
            }

            Connection.Close();
            return readerList;
        }

        public string LoadReaderInfo(string readerID)
        {
            Connection.Open();
            string query = "SELECT name FROM reader WHERE reader_id = '"+readerID+"'";
            SqlCommand command = new SqlCommand(query,Connection);
            SqlDataReader bReader = command.ExecuteReader();
            string name="";
            while (bReader.Read())
            {
                name = bReader["name"].ToString();
            }
            return name;
        }
    }
}
