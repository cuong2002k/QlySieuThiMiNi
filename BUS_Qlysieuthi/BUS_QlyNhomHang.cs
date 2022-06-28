using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DAL_Qlysieuthi;
using DTO_Qlysieuthi;
using System.Data;
using System.Data.SqlClient;
namespace BUS_Qlysieuthi
{
    public class QlyNhomHang
    {
       
        NhomHang dalnhomhang = new NhomHang();
        //them nhom hang
        public void NH_themNhomHang(DTO_NhomHang dtonhomhang) {
            dalnhomhang.NH_themNhomHang(dtonhomhang);
        }
        public DataSet NH_getNhomHangChiTiet() {
            return dalnhomhang.NH_getNhomHangChiTietHangHoa();
        }
        public void NH_xoaNhomHang(string MaNH) {
            dalnhomhang.NH_xoaNhomHang(MaNH);
        }
        public void NH_suaNhomHang(DTO_NhomHang dtonhomhang) {
            dalnhomhang.NH_suaNhomHang(dtonhomhang);
        }
        public DataTable NH_SearchNhomHang(string MaNH)
        {
            return dalnhomhang.NH_SearchNhomHang(MaNH);
        }
    }
}
