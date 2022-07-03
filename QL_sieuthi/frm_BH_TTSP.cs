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
    public partial class frm_BH_TTSP : Form
    {
        
        public frm_BH_TTSP()
        {
            InitializeComponent();
        }

        public void btnoke_Click(object sender, EventArgs e)
        {
           //frm_BH_QLBH.frmBH;
           
        }

        private void frm_BH_TTSP_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frm_BH_QLBH.frmBH.XoaHangHoaTrongListView(txtMaHH.Text, txtSLHH.Text, txtDonGiaHH.Text);
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frm_BH_QLBH.frmBH.SuaHangHoaTrongListView(txtMaHH.Text, txtSLHH.Text, txtDonGiaHH.Text);
            this.Close();

        }
    }
}
