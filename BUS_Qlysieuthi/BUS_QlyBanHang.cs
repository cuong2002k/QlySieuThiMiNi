using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_Qlysieuthi;
using DTO_Qlysieuthi;
using System.Data;
namespace BUS_Qlysieuthi
{
    public class QlyBanHang : BUSConnectDAL
    {
        public DataTable BH_LayDSHangHoa()
        {
            return dalbanhang.BH_DSHangHoa();
        }
        public DataTable BH_TimKiemKHTT(string MaKH)
        {
            return dalbanhang.BH_TimKhachHangThanThiet(MaKH);
        }
        public void BH_HoatDongTichDiem(string MaKH, int Diem)
        {
            dalbanhang.BH_HOATDONGDOIDIEM(MaKH, Diem);
        }
        public void BH_HoatDongDoiDiem(string MaKH, int Diem)
        {
            dalbanhang.BH_HOATDONGTICHDIEM(MaKH, Diem);
        }

        // hoat dong thanh toan
        public void BH_LapHoaDon(DTO_HoaDon hd)
        {
            dalhoadon.BH_LapHoaDon(hd);
        }
        public void BH_LapHoaDonCT(DTO_HoaDonCT hdct)
        {
            dalhoadon.BH_LapHoaDonCT(hdct);
        }
        public DataTable BH_RPTHoaDon(string SoHD)
        {
            return dalhoadon.BH_RPTHoaDon(SoHD);
        }
    }
}
