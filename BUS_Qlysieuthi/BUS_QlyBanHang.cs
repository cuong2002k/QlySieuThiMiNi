using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_Qlysieuthi;
using System.Data;
namespace BUS_Qlysieuthi
{
    public class QlyBanHang : BUSConnectDAL
    {
        public DataTable BH_LayDSHangHoa()
        {
            return dalbanhang.BH_DSHangHoa();
        }
    }
}
