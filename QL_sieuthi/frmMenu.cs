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


        private void btn_BanHang_Click_1(object sender, EventArgs e)
        {
            frm_BH_QLBH frm = new frm_BH_QLBH();
            frm.Show();
        }

        private void btnkho_Click_1(object sender, EventArgs e)
        {
            frmQlykho frm = new frmQlykho();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
