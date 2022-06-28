using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Qlysieuthi
{
    public class DTOHangHoa
    {
        string maHH;
        string tenHang;
        string loaiHang;
        string xuatXu;
        string ngaySX;
        string hSD;
        float giaBan;
        string donViTinh;
        string nhaCungCap;
        int soLuong;


       
        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
       

        public string LoaiHang
        {
            get { return loaiHang; }
            set { loaiHang = value; }
        }
        
        public string XuatXu
        {
            get { return xuatXu; }
            set { xuatXu = value; }
        }
        
        public string NgaySX
        {
            get { return ngaySX; }
            set { ngaySX = value; }
        }
        
        public string HSD
        {
            get { return hSD; }
            set { hSD = value; }
        }
        
        public float GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        
        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
        

        public string NhaCungCap
        {
            get { return nhaCungCap; }
            set { nhaCungCap = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public DTOHangHoa(string maHH, string tenHang,string loaiHang, string xuatXu, string ngaySX, string hSD, float giaBan, string donViTinh, string nhaCungCap,
           int soLuong 
        )
        {
            this.maHH = maHH;
            this.tenHang = tenHang;
            this.loaiHang = loaiHang;
            this.xuatXu = xuatXu;
            this.ngaySX = ngaySX;
            this.hSD = hSD;
            this.giaBan = giaBan;
            this.donViTinh = donViTinh;
            this.nhaCungCap = nhaCungCap;
            this.soLuong = soLuong;
        }
        
    }
}
