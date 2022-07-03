using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Qlysieuthi
{
    public class DTO_HoaDon
    {
        string soHoaDon;
        string maNhanVien;
        string ngaylap;
        string maKH = null;
        float vAT;

        public DTO_HoaDon(string soHoaDon, string maNhanVien, float vAT)
        {
            this.soHoaDon = soHoaDon;
            this.MaNhanVien = maNhanVien;
            this.VAT = vAT;
            Ngaylap = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        public DTO_HoaDon(string soHoaDon, string maNhanVien, string maKH, float vAT)
        {
            this.soHoaDon = soHoaDon;
            this.maNhanVien = maNhanVien;
            this.maKH = maKH;
            this.vAT = vAT;
            Ngaylap = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
           
        }

        
        public string SoHoaDon { get => soHoaDon; set => soHoaDon = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public float VAT { get => vAT; set => vAT = value; }
    }
}
