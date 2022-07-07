using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_sieuthi
{
    public partial class frm_kho_TTHHnhap : Form
    {
        public frm_kho_TTHHnhap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_kho_PhieuNhapHang.frmnhaphang.themhanghoavaolistview(txtsoluongnhap.Text,txtmahh.Text);
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            frm_kho_PhieuNhapHang.frmnhaphang.xoaitemtronglistviewhanghoa(txtmahh.Text);
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            frm_kho_PhieuNhapHang.frmnhaphang.suaitemtronglistviewhanghoa(txtmahh.Text, int.Parse(txtsoluongnhap.Text));
            this.Close();
        }
    }
}
