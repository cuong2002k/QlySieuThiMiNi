using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_Qlysieuthi;
using System.Data;
using DTO_Qlysieuthi;
namespace BUS_Qlysieuthi
{
    public class Qlykho
    {
        HangHoa dalhanghoa = new HangHoa();
        NhomHang dalnhomhang = new NhomHang();
        NhaCungCap dalnhacungcap = new NhaCungCap();
        // hang hoa
        public DataTable KHO_getHangHoa()
        {
            return dalhanghoa.KHO_getHangHoa();
        }
        public void KHO_themHangHoa(DTOHangHoa dtohanghoa)
        {
            dalhanghoa.KHO_themHangHoa(dtohanghoa);
        }
        public void KHO_xoaHangHoa(string MaHH) {
            dalhanghoa.KHO_xoaHangHoa(MaHH);
        }
        public void KHO_suaHangHoa(DTOHangHoa dtohanghoa)
        {
            dalhanghoa.KHO_suaHangHoa(dtohanghoa);
        }
        public DataTable KHO_timKiemHangHoa(string keyword) {
            return dalhanghoa.KHO_timKiemhangHoa(keyword);
        }
        // nhom hang 
        public DataTable KHO_getNhomHang()
        {
            return dalnhomhang.KHO_getNhomHang();
        }
        public void KHO_themNhomHang(DTO_NhomHang dtonhomhang) {
            dalnhomhang.NH_themNhomHang(dtonhomhang); 
        }
        // nha cung cap
        public DataTable KHO_getNhaCungCap()
        {
            return dalnhacungcap.KHO_getNhaCungCap();
        }
    }
}
