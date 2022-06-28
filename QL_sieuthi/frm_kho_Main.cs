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
        private void btn_kho_QLHH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_kho_QLHH());
        }

        private void btn_kho_QLNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_kho_QLNCC());
        }

        private void btn_kho_QLNH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_kho_QLNH());
        }

       
    }
}
