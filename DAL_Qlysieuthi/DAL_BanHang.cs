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
        public DataTable BH_TimKhachHangThanThiet(string MaKH)
        {
            string sql = "BH_TIMKIEMKHTHANTHIET";
            DataTable dt = new DataTable();
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAKH", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }
        public void BH_HOATDONGDOIDIEM(string MaKHH, int Diem)
        {
            string sql = string.Format(@"UPDATE KHThanThiet
                        SET Diem = Diem + '{1}'
                        WHERE MaKH = '{0}'", MaKHH, Diem);
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
    
            cmd.ExecuteNonQuery();
            _conn.Close();
           
        }
        public void BH_HOATDONGTICHDIEM(string MaKHH, int Diem)
        {
            string sql = string.Format(@"UPDATE KHThanThiet
                        SET Diem = '{1}'
                        WHERE MaKH = '{0}'", MaKHH, Diem);
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);

            cmd.ExecuteNonQuery();
            _conn.Close();

        }
        
    }
}
