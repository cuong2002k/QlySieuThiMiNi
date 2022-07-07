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
    public partial class frmQlykho : Form
    {
        public frmQlykho()
        {
            InitializeComponent();
            
            
        }
        private Form Active = null;
        private void OpenChildForm(Form ChildForm){
            if(Active != null){
                Active.Close();
            }
            Active = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(ChildForm);
            panelchildform.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frm_kho_QLHH frm = new frm_kho_QLHH();
            OpenChildForm(frm);
        }

        private void frmQlykho_Load(object sender, EventArgs e)
        {
            frm_kho_QLHH frm = new frm_kho_QLHH();
            OpenChildForm(frm);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frm_kho_QLNCC frm = new frm_kho_QLNCC();
            OpenChildForm(frm);
        }

        private void btnnhomhang_Click(object sender, EventArgs e)
        {
            frm_kho_QLNH frm = new frm_kho_QLNH();
            OpenChildForm(frm);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frm_kho_PhieuNhapHang frm = new frm_kho_PhieuNhapHang();
            OpenChildForm(frm);
        }
    }
}
