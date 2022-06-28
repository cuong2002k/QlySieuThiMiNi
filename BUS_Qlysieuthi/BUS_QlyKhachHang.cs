using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_Qlysieuthi;
using DTO_Qlysieuthi;
using System.Data;
namespace BUS_Qlysieuthi
{
    public class QlyKhachHang
    {
        KHThanThiet KHTT = new KHThanThiet();
        public DataTable KH_getKhachHang() {
            return KHTT.KH_getKhachHang();
        }
        public void KH_themKhachHang(DTO_KhachHangTT dtokhachhang) {
            KHTT.KH_themKhachHang(dtokhachhang);
        }
    }
}
