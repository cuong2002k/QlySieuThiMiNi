using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_sieuthi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnkho_Click(object sender, EventArgs e)
        {
            frmQlykho frm = new frmQlykho();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frm_KH_QLKH frm = new frm_KH_QLKH();
            frm.Show();
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            frm_BH_QLBH frm = new frm_BH_QLBH();
            frm.Show();
        }
    }
}
