using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Qlysieuthi
{
    public class DTO_NhomHang
    {
        string maNH;
        string tenNH;
        public DTO_NhomHang(string maNH, string tenNH)
        {
            this.tenNH = tenNH;
            this.maNH = maNH;
        }
        public string MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
        

        public string TenNH
        {
            get { return tenNH; }
            set { tenNH = value; }
        }
       


    }
}
