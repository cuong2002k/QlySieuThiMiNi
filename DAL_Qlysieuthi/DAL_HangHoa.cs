using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DTO_Qlysieuthi;
namespace DAL_Qlysieuthi
{
   
    public class HangHoa 
    {
        //connect database
        SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QLSieuthi"].ToString());
        public DataTable KHO_getHangHoa() {
            // tạo 1 datatable luu ds hang hoa
            DataTable dt = new DataTable();
            _conn.Open();
            try
            {
                // tao 1 string luu ten stored
                string sql = "QLKHO_LAYDSHANGHOA";
                // thuc hien truy van
                SqlCommand cmd = new SqlCommand(sql, _conn);
                // loai truy van
                cmd.CommandType = CommandType.StoredProcedure;
                // truy van do du lieu vao dataadapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // do lu lieu vao datatable xong tra ve
                da.Fill(dt);
            }
            catch (Exception) { }
            finally {
                _conn.Close();
            }
            return dt;
        }
        private SqlCommand command(string sql, SqlConnection _conn)
        {
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
        // THEM HANG HOA
        public void KHO_themHangHoa(DTOHangHoa hanghoa) {
            _conn.Open();
                string sql = "QLKHO_THEMHANGHOA";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAHH", hanghoa.MaHH);
                cmd.Parameters.AddWithValue("@TENHH",hanghoa.TenHang);
                cmd.Parameters.AddWithValue("@LOAIHH",hanghoa.LoaiHang);
                cmd.Parameters.AddWithValue("@XUATXU", hanghoa.XuatXu);
                cmd.Parameters.AddWithValue("@NGAYSX", hanghoa.NgaySX);
                cmd.Parameters.AddWithValue("@HSD", hanghoa.HSD);
                cmd.Parameters.AddWithValue("@GIABAN", hanghoa.GiaBan);
                cmd.Parameters.AddWithValue("@DONVITINH", hanghoa.DonViTinh);
                cmd.Parameters.AddWithValue("@NHACUNGCAP", hanghoa.NhaCungCap);
                cmd.Parameters.AddWithValue("@SOLUONG", hanghoa.SoLuong);
                cmd.ExecuteNonQuery();
            _conn.Close();
        }
        // SUA HANG HOA
        public void KHO_suaHangHoa(DTOHangHoa hanghoa)
        {
            _conn.Open();
            string sql = "QLKHO_SUAHANGHOA";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHH", hanghoa.MaHH);
            cmd.Parameters.AddWithValue("@TENHH", hanghoa.TenHang);
            cmd.Parameters.AddWithValue("@LOAIHH", hanghoa.LoaiHang);
            cmd.Parameters.AddWithValue("@XUATXU", hanghoa.XuatXu);
            cmd.Parameters.AddWithValue("@NGAYSX", hanghoa.NgaySX);
            cmd.Parameters.AddWithValue("@HSD", hanghoa.HSD);
            cmd.Parameters.AddWithValue("@GIABAN", hanghoa.GiaBan);
            cmd.Parameters.AddWithValue("@DONVITINH", hanghoa.DonViTinh);
            cmd.Parameters.AddWithValue("@NHACUNGCAP", hanghoa.NhaCungCap);
            cmd.Parameters.AddWithValue("@SOLUONG", hanghoa.SoLuong);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        //xoa hang hoa
        public void KHO_xoaHangHoa(string MaHH) {
            _conn.Open();
            string sql = "QLKHO_XOAHANGHOA";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHH",MaHH);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        //TIM KIEM HANG HOA
        public DataTable KHO_timKiemhangHoa(string keyword)
        {
            _conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("KHO_TIMKIEMHANGHOA", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KEYWORD", keyword);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt); 
            _conn.Close();
            return dt;
        }
    }
}
