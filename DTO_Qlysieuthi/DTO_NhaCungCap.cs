using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Qlysieuthi
{
    public class DTO_NhaCungCap
    {
        string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        string tenNCC;

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        public DTO_NhaCungCap(string maNCC, string tenNCC)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
        }
    }
}
