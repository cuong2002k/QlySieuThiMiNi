using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_Qlysieuthi;
using BUS_Qlysieuthi;
namespace QL_sieuthi
{
    public partial class frm_KH_QLKH : Form 
    {
        QlyKhachHang qlyKhachHang = new QlyKhachHang();
        public frm_KH_QLKH()
        {
            InitializeComponent();
        }
        private void laydsKH() {
            DataTable dt = qlyKhachHang.KH_getKhachHang();
            dtgvKhacHang.DataSource = dt;
        }
        private void frm_KH_QLKH_Load(object sender, EventArgs e)
        {
            laydsKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_KhachHangTT KH = new DTO_KhachHangTT(txtTenKH.Text,txtCMND.Text,txtDiaChi.Text,txtSDT.Text,0);
            qlyKhachHang.KH_themKhachHang(KH);
            laydsKH();
        }
    }
}
