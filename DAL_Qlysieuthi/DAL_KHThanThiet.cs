using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_Qlysieuthi;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL_Qlysieuthi
{
    public class KHThanThiet : DBConnection
    {
        
        public DataTable KH_getKhachHang()
        {
            _conn.Open();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM KHThanThiet";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }
        public void KH_themKhachHang(DTO_KhachHangTT KHTT)
        {
            _conn.Open();
            string sql = "QLKH_THEMKHACHHANG";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENKH",KHTT.TenKH);
            cmd.Parameters.AddWithValue("@CMND", KHTT.CMND);
            cmd.Parameters.AddWithValue("@DIACHI", KHTT.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", KHTT.SDT);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
