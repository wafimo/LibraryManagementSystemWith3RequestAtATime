﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemDemoSoft.DAL.Gateway
{
    public class BaseGateway
    {
        public SqlConnection Connection= new SqlConnection(ConfigurationManager.ConnectionStrings["LMS"].ConnectionString);
    }
}
