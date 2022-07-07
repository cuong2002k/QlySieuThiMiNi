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
    public class NhaCungCap
    {
        SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QLSieuthi"].ToString());
        public DataTable KHO_getNhaCungCap()
        {
            DataTable dt = new DataTable();
            _conn.Open();
            try
            {
                string sql = "QLKHO_LAYDSNHACUNGCAP";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception) { }
            finally {
                _conn.Close();
            }
            return dt;
        }
        public DataSet NCC_getNhaCungCapChiTiet() {
            _conn.Open();
            DataSet data = new DataSet();
            string sqlnhacungcap = "SELECT * FROM NhaCungCap";
            SqlCommand cmdnhacungcap = new SqlCommand(sqlnhacungcap,_conn);
            SqlDataAdapter dtnhacungcap = new SqlDataAdapter(cmdnhacungcap);
            dtnhacungcap.Fill(data, "tbNhaCungCap");

            string sqlhanghoa = "SELECT * FROM HangHoa";
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
        public void NCC_ThemNCC(DTO_NhaCungCap dtonhacungcap) {
            _conn.Open();
            string sql = string.Format("INSERT INTO NhaCungCap VALUES('{0}',N'{1}')",dtonhacungcap.MaNCC,dtonhacungcap.TenNCC);
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void NCC_XoaNCC(String MaNCC) {
            _conn.Open();
            string sql = string.Format("DELETE FROM NhaCungCap WHERE MaNCC = '{0}'", MaNCC);
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void NCC_SuaNCC(DTO_NhaCungCap dtonhacungcap)
        {
            _conn.Open();
            string sql = string.Format("UPDATE NhaCungCap SET TenNCC = N'{1}' WHERE MaNCC = '{0}'", dtonhacungcap.MaNCC, dtonhacungcap.TenNCC);
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
