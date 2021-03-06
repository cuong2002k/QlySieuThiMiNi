using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Qlysieuthi;
using DTO_Qlysieuthi;
using DevExpress.XtraReports.UI;
using CrystalDecisions.CrystalReports.Engine;

namespace QL_sieuthi
{
    public partial class frm_BH_ThanhToan : Form
    {
        QlyBanHang BanHang = new QlyBanHang();
        string MaNV = "NVBH000001";
        public frm_BH_ThanhToan()
        {
            InitializeComponent();
           
        }
        //ham lay so hoa don tu dong
        string SoHD()
        {
            string sohd = "";
            sohd = DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");
            return sohd;
        }
 
        DataTable KhachHang = new DataTable();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                KhachHang = BanHang.BH_TimKiemKHTT(txtMaKH.Text);
                if(KhachHang.Rows.Count > 0)
                {
                    txttenKH.Text = KhachHang.Rows[0][1].ToString();
                    txtDiemTichLuy.Text = KhachHang.Rows[0][5].ToString();
                    txtMaKH.Enabled = false;
                    rdotichdiem.Enabled = true;
                    rdodoidiem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại trong hệ thống vui lòng thử lại!!!");
                }
            }
        }
        void TinhThue()
        {
            double TienThue = double.Parse(txtTienThue.Text);
            TienThue = (double)TienThue / 100;
            TienThue = (double)TienThue * int.Parse(txtSotientamtinh.Text);
            txtTongTienThanhToan.Text = (int.Parse(txtSotientamtinh.Text) + TienThue).ToString();
        }
        private void frm_BH_ThanhToan_Load(object sender, EventArgs e)
        {
            TinhThue();

        }
        bool checkNumber(string s)
        {
            int num;
            bool check = int.TryParse(s, out num);
            return check;
        }
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if(checkNumber(txtTienKhachDua.Text) == false && txtTienKhachDua.Text != string.Empty)
            {
                MessageBox.Show("Số tiền khách đưa không hợp lệ!!!");
                txtTienKhachDua.Clear();
                return;
            }
            if(txtTienKhachDua.Text != string.Empty)
            {
                if ((int.Parse(txtTienKhachDua.Text) >= int.Parse(txtTongTienThanhToan.Text)))
                {
                    txtTienTraKhach.Text = (int.Parse(txtTienKhachDua.Text) - int.Parse(txtTongTienThanhToan.Text)).ToString();
                    btnThanhToan.Enabled = true;
                }
                else
                {
                    btnThanhToan.Enabled = false;
                }
            }
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (rdotichdiem.Checked && rdotichdiem.Enabled)
            {
                
                int diemtichluy = int.Parse(txtTongTienThanhToan.Text) / 1000;
                BanHang.BH_HoatDongTichDiem(txtMaKH.Text, diemtichluy);
                
            }
            else if(rdodoidiem.Checked && rdodoidiem.Enabled)
            {
                BanHang.BH_HoatDongDoiDiem(txtMaKH.Text, 0);
               
            }
            string sohd = SoHD();
            DTO_HoaDon dtohd = new DTO_HoaDon(sohd, MaNV,txtMaKH.Text,float.Parse(txtTienThue.Text));
            BanHang.BH_LapHoaDon(dtohd);
            frm_BH_QLBH.frmBH.themsanphamvaohoadonCT(sohd);
            DataTable rpt = new DataTable();

            rpt = BanHang.BH_RPTHoaDon(sohd);
            hoadon hoadonreport = new hoadon();
            TextObject rptSohd = (TextObject)hoadonreport.ReportDefinition.Sections["Section2"].ReportObjects["SoHD"];
            TextObject rpttienkhachdua = (TextObject)hoadonreport.ReportDefinition.Sections["Section4"].ReportObjects["TienKhachDua"];
            TextObject rpttientrakhach = (TextObject)hoadonreport.ReportDefinition.Sections["Section4"].ReportObjects["TienTraKhach"];
            rpttienkhachdua.Text = txtTienKhachDua.Text;
            rptSohd.Text = sohd.ToString();
            rpttientrakhach.Text = txtTienTraKhach.Text;


            hoadonreport.SetDataSource(rpt);
            


            frm_BH_ReportHD reportfrm = new frm_BH_ReportHD();
            reportfrm.crystalReportViewer2.ReportSource = hoadonreport;
            reportfrm.ShowDialog();
            this.Close();
            frm_BH_QLBH.frmBH.lstHangHoa.Items.Clear();
            frm_BH_QLBH.frmBH.btnTien.Text = "0";
            MessageBox.Show("Thanh toán thành công");
        }
        
        private void rdodoidiem_CheckedChanged(object sender, EventArgs e)
        {
            if(rdodoidiem.Checked == true)
            {
                txtTongTienThanhToan.Text = (int.Parse(txtTongTienThanhToan.Text) - int.Parse(txtDiemTichLuy.Text) * 100).ToString();
            }
            else
            {
                txtTongTienThanhToan.Text = (int.Parse(txtTongTienThanhToan.Text) + int.Parse(txtDiemTichLuy.Text) * 100).ToString();
            }
        }
    }
}
