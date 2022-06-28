using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Qlysieuthi
{
    public class DTO_KhachHangTT
    {
        string tenKH;
        string cMND;
        string diaChi;
        string sDT;
        int diem;
        public DTO_KhachHangTT(
            string tenKH,
            string cMND,
            string diaChi,
            string sDT,
            int diem    
        )
        {

            this.tenKH = tenKH;
            this.cMND = cMND;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.diem = diem;
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
       
        public string CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }
        
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        

        public int Diem
        {
            get { return diem; }
            set { diem = value; }
        }
    }
}
