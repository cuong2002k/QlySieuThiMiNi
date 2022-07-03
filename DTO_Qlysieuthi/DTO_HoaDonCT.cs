using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Qlysieuthi
{
    public class DTO_HoaDonCT
    {
        string soHD;
        string MaHH;
        int soLuong;
        int donGia;
        int thanhTien;

        public DTO_HoaDonCT(string soHD, string maHH, int soLuong, int donGia, int thanhTien)
        {
            this.soHD = soHD;
            MaHH = maHH;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public string SoHD { get => soHD; set => soHD = value; }
        public string MaHH1 { get => MaHH; set => MaHH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
