using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Qlysieuthi
{
    public class DAL_NhapHang : DBConnection
    {
        public DataTable NhapHang_getHangHoa(string MaHH)
        {
            string sql = "NHAPHANG_TIMKIEMHANGHOA";
            DataTable dt = new DataTable();
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KEYWORD", MaHH);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }
        public DataSet Nhaphang_getNhaCungCapvahanghoa()
        {
            _conn.Open();
            DataSet data = new DataSet();
            string sqlnhacungcap = "SELECT * FROM NhaCungCap";
            SqlCommand cmdnhacungcap = new SqlCommand(sqlnhacungcap, _conn);
            SqlDataAdapter dtnhacungcap = new SqlDataAdapter(cmdnhacungcap);
            dtnhacungcap.Fill(data, "tbNhaCungCap");

            string sqlhanghoa = @"select MaHH,TenHang,LoaiHang = (SELECT TenNH FROM NhomHang WHERE MaNH = LoaiHang),XuatXu,NhaCungCap,SoLuong 
             from HangHoa";
            SqlCommand cmdhanghoa = new SqlCommand(sqlhanghoa, _conn);
            cmdhanghoa.CommandType = CommandType.Text;
            SqlDataAdapter datahanghoa = new SqlDataAdapter(cmdhanghoa);
            datahanghoa.Fill(data, "tbHangHoa");

            DataRelation relation = new DataRelation(
                "DSHangHoaTheoNCC", data.Tables["tbNhaCungCap"].Columns["MaNCC"],
                                    data.Tables["tbHangHoa"].Columns["NhaCungCap"]
                );
            data.Relations.Add(relation);
            _conn.Close();
            return data;
        }
    }
}
