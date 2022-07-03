using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_Qlysieuthi;
namespace DAL_Qlysieuthi
{
    public class DAL_HoaDon : DBConnection
    {
        public void BH_LapHoaDon(DTO_HoaDon hoadon)
        {
            string sql = "BH_LAPHOADON";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql,_conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOHD",hoadon.SoHoaDon);
            cmd.Parameters.AddWithValue("@MANV", hoadon.MaNhanVien);
            cmd.Parameters.AddWithValue("@NGAYLAP", hoadon.Ngaylap);
            cmd.Parameters.AddWithValue("@MAKH", hoadon.MaKH);
            cmd.Parameters.AddWithValue("@VAT", hoadon.VAT);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void BH_LapHoaDonCT(DTO_HoaDonCT hdct)
        {
            string sql = "BH_LAPHOADONCHITIET";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOHD", hdct.SoHD);
            cmd.Parameters.AddWithValue("@MAHH", hdct.MaHH1);
            cmd.Parameters.AddWithValue("@SOLUONG", hdct.SoLuong);
            cmd.Parameters.AddWithValue("@DONGIA", hdct.DonGia);
            cmd.Parameters.AddWithValue("@THANHTIEN", hdct.ThanhTien);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public DataTable BH_RPTHoaDon(string Sohd)
        {
            string sql = "BH_XUATREPORTHOADON";
            DataTable dt = new DataTable();
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOHD", Sohd);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }
    }
}
