using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_Qlysieuthi;
using DTO_Qlysieuthi;
namespace BUS_Qlysieuthi
{
    public class QlyNhaCungCap
    {
        NhaCungCap dalNhaCungCap = new NhaCungCap();
        public DataSet NCC_gethangHoaTheoNCC() {
            return dalNhaCungCap.NCC_getNhaCungCapChiTiet();
        }
        public void NCC_themNhaCungCap(DTO_NhaCungCap dtoNCC) {
            dalNhaCungCap.NCC_ThemNCC(dtoNCC);
        }
        public void NCC_xoaNhaCungCap(string MaNCC)
        {
            dalNhaCungCap.NCC_XoaNCC(MaNCC);
        }
        public void NCC_suaNhaCungCap(DTO_NhaCungCap dtoNCC) {
            dalNhaCungCap.NCC_SuaNCC(dtoNCC);
        }
    }
}
