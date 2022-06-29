using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL_Qlysieuthi
{
    public class DAL_BanHang : DBConnection
    {
        public DataTable BH_DSHangHoa()
        {
            string sql = "BH_LAYDSHANGHOABAN";
            DataTable dt = new DataTable();
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }
    }
}
