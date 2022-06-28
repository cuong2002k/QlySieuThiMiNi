using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using DTO_Qlysieuthi;
namespace DAL_Qlysieuthi
{
    public class NhomHang : DBConnection
    {
  
        public DataTable KHO_getNhomHang()
        {
            _conn.Open();
            // tạo 1 datatable luu ds hang hoa
            DataTable dt = new DataTable();
            // tao 1 string luu ten stored
            string sqlnhomhang = "QLKHO_LAYDSNHOMHANG";
            // thuc hien truy van
            SqlCommand cmdnhomhang = new SqlCommand(sqlnhomhang, _conn);
            // loai truy van
            cmdnhomhang.CommandType = CommandType.StoredProcedure;
            // truy van do du lieu vao dataadapter
            SqlDataAdapter datanhomhang = new SqlDataAdapter(cmdnhomhang);
            // do lu lieu vao datatable xong tra ve
            datanhomhang.Fill(dt);
            _conn.Close();
            return dt;
        }
        public void NH_themNhomHang(DTO_NhomHang nh)
        {
            _conn.Open();
            string sql = "QLNH_THEMNHOMHANG";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNH", nh.MaNH);
            cmd.Parameters.AddWithValue("@TenNH", nh.TenNH);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public DataSet NH_getNhomHangChiTietHangHoa()
        {
            _conn.Open();
           
            // tạo 1 datatable luu ds hang hoa
            DataSet dt = new DataSet();
            string sqlnhomhang = "QLKHO_LAYDSNHOMHANG";
            SqlCommand cmdnhomhang = new SqlCommand(sqlnhomhang, _conn);
            cmdnhomhang.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter datanhomhang = new SqlDataAdapter(cmdnhomhang);
            datanhomhang.Fill(dt, "tbNhomHang");

            string sqlhanghoa = "SELECT * FROM HangHoa";
            SqlCommand cmdhanghoa = new SqlCommand(sqlhanghoa, _conn);
            cmdhanghoa.CommandType = CommandType.Text;
            SqlDataAdapter datahanghoa = new SqlDataAdapter(cmdhanghoa);
            datahanghoa.Fill(dt, "tbHangHoa");
            DataRelation relation = new DataRelation(
                "DSHangHoaThuocNhomHang",
                dt.Tables["tbNhomHang"].Columns["MaNH"],
                dt.Tables["tbHangHoa"].Columns["LoaiHang"]
                
                );
            dt.Relations.Add(relation);
            _conn.Close();
                return dt;  
        }
        public void NH_xoaNhomHang(string MaNH) {
            _conn.Open();
            string sql = string.Format("DELETE FROM NhomHang WHERE MaNH = '{0}'", MaNH);
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void NH_suaNhomHang(DTO_NhomHang dtonhomhang) {
            _conn.Open();
            string sql = "QLNH_SUANHOMHANG";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MANH", dtonhomhang.MaNH);
            cmd.Parameters.AddWithValue("@TENNH", dtonhomhang.TenNH);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public DataTable NH_SearchNhomHang(string MaNH)
        {
            _conn.Open();
            DataTable dt = new DataTable();
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNH",MaNH);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }
    }
}
