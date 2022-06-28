using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL_Qlysieuthi
{
    public class DBConnection
    {
       protected SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QLSieuthi"].ToString());
    }
}
