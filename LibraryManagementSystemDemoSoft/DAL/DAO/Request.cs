using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemDemoSoft.DAL.DAO
{
    class Request
    {
        public int ID { get; set; }
        public string ReqReaderID { get; set; }
        public string ReqBookID { get; set; }
        public string Status { get; set; }
        public string BookName { get; set; }
       
        public DateTime Return_Date { get; set; }

        public float Fee { get; set; }
    }
}
