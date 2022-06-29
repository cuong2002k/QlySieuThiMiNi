using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Qlysieuthi;
namespace QL_sieuthi
{
    public partial class frm_BH_QLBH : Form
    {
        Qlykho bushanghoa = new Qlykho();
        QlyBanHang busBanHang = new QlyBanHang();
        public static frm_BH_QLBH frmBH = new frm_BH_QLBH();
        
        public frm_BH_QLBH()
        {
            InitializeComponent();
            frm_BH_QLBH.frmBH = this;
        }
        int k = 1;
        private void txtBarcodeHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
           
              if(e.KeyCode == Keys.Enter)
              {
                DataTable dt = bushanghoa.KHO_getHangHoa();
                for(int i = 0; i < lstHangHoa.Items.Count; i++)
                {
                    
                    if(lstHangHoa.Items[i].SubItems[1].Text.Equals(txtBarcodeHangHoa.Text))
                    {
                        int temp = int.Parse(lstHangHoa.Items[i].SubItems[3].Text) + 1;

                        lstHangHoa.Items[i].SubItems[3].Text = temp.ToString();
                        int Tien = int.Parse(lstHangHoa.Items[i].SubItems[4].Text);
                        btnTien.Text = (int.Parse(btnTien.Text) + Tien).ToString();
                       
                        return;
                    }
                }
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if(txtBarcodeHangHoa.Text == dt.Rows[i]["MaHH"].ToString())
                    {
                        ListViewItem item = new ListViewItem(k.ToString());
                        item.SubItems.Add(dt.Rows[i][0].ToString());
                        item.SubItems.Add(dt.Rows[i][1].ToString());
                        item.SubItems.Add(1.ToString());
                        item.SubItems.Add(dt.Rows[i]["GiaBan"].ToString());
                        int Tien = int.Parse(dt.Rows[i]["GiaBan"].ToString());
                        btnTien.Text = (int.Parse(btnTien.Text) + Tien).ToString();
                        lstHangHoa.Items.Add(item);
                        txtBarcodeHangHoa.Clear();
                        k++;
                        return;
                    }
                }
                MessageBox.Show("Mã Hàng Hóa Không Tồn Tại!!!");
                txtBarcodeHangHoa.Clear();
            }
            
        }
        public void XoaHangHoaTrongListView(string MaHH, string SoLuong, string donGia)
        {
            
            
            for(int i = 0; i < this.lstHangHoa.Items.Count; i++)
            {
                
                if (this.lstHangHoa.Items[i].SubItems[1].Text.Equals(MaHH))
                {
                    this.lstHangHoa.Items[i].Remove();
                    btnTien.Text = (int.Parse(btnTien.Text) - int.Parse(SoLuong) * int.Parse(donGia)).ToString(); 
                    break;
                }
            }
           
            for (int i = 0; i < this.lstHangHoa.Items.Count; i++)
            {

                lstHangHoa.Items[i].SubItems[0].Text = (i + 1).ToString();
            }

        }
        public void SuaHangHoaTrongListView(string MaHH,string SoLuong,string DonGia)
        {
            for (int i = 0; i < this.lstHangHoa.Items.Count; i++)
            {

                if (this.lstHangHoa.Items[i].SubItems[1].Text.Equals(MaHH))
                {
                    int sotiencantru = int.Parse(lstHangHoa.Items[i].SubItems[3].Text) * int.Parse(lstHangHoa.Items[i].SubItems[4].Text);
                    btnTien.Text = (int.Parse(btnTien.Text) - sotiencantru).ToString();
                    btnTien.Text = (int.Parse(btnTien.Text) + int.Parse(SoLuong) * int.Parse(DonGia)).ToString();
                    this.lstHangHoa.Items[i].SubItems[3].Text = SoLuong;
                    break;
                }
            }
        }
        private void lstHangHoa_DoubleClick(object sender, EventArgs e)
        {
            frm_BH_TTSP frm = new frm_BH_TTSP();
            frm.txtMaHH.Text = lstHangHoa.SelectedItems[0].SubItems[1].Text;
            frm.txtTenHH.Text = lstHangHoa.SelectedItems[0].SubItems[2].Text;
            frm.txtSLHH.Text = lstHangHoa.SelectedItems[0].SubItems[3].Text;
            frm.txtDonGiaHH.Text = lstHangHoa.SelectedItems[0].SubItems[4].Text;
            frm.Show();
            
        }

        private void frm_BH_QLBH_Load(object sender, EventArgs e)
        {
            dtgvDsHangHoa.DataSource = busBanHang.BH_LayDSHangHoa();
        }

        private void dtgvDsHangHoa_DoubleClick(object sender, EventArgs e)
        {
            if(dtgvDsHangHoa.SelectedRows.Count > 1)
            {
                return;
            }
            for (int i = 0; i < lstHangHoa.Items.Count; i++)
            {

                if (lstHangHoa.Items[i].SubItems[1].Text.Equals(dtgvDsHangHoa.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    int slhh = int.Parse(lstHangHoa.Items[i].SubItems[3].Text) + 1;
                    lstHangHoa.Items[i].SubItems[3].Text = slhh.ToString();
                    int TienTruoc = int.Parse(lstHangHoa.Items[i].SubItems[4].Text);
                    btnTien.Text = (int.Parse(btnTien.Text) + TienTruoc).ToString();
                    return;
                }
            }
            ListViewItem item = new ListViewItem(k.ToString());
            item.SubItems.Add(dtgvDsHangHoa.SelectedRows[0].Cells[0].Value.ToString());
            item.SubItems.Add(dtgvDsHangHoa.SelectedRows[0].Cells[1].Value.ToString());
            item.SubItems.Add(1.ToString());
            item.SubItems.Add(dtgvDsHangHoa.SelectedRows[0].Cells[3].Value.ToString());
            int TienSau = int.Parse(dtgvDsHangHoa.SelectedRows[0].Cells[3].Value.ToString());
            btnTien.Text = (int.Parse(btnTien.Text) + TienSau).ToString();
            lstHangHoa.Items.Add(item);
            k++;
        }
    }
}
