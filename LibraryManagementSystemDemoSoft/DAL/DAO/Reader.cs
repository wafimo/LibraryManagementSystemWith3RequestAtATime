using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemDemoSoft.DAL.Gateway;

namespace LibraryManagementSystemDemoSoft.DAL.DAO
{
    class Reader : BaseGateway
    {
        public int ID { get; set; }  
        public string ReaderID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
