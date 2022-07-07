using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Qlysieuthi
{
    public class QlyNhaphang : BUSConnectDAL
    {
        public DataTable Nhaphang_getHangHoa(string MaHH)
        {
            return dalnhaphang.NhapHang_getHangHoa(MaHH);
        }
        public DataSet NhapHang_getHangHoaNhaCungCap()
        {
            return dalnhaphang.Nhaphang_getNhaCungCapvahanghoa();
        }
    }
}
