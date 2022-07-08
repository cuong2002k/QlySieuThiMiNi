using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Qlysieuthi;
namespace QL_sieuthi
{
    public partial class frm_kho_PhieuNhapHang : Form
    {
        QlyBanHang busbanhang = new QlyBanHang();
        Qlykho buskhohang = new Qlykho();
        QlyNhaphang busnhaphang = new QlyNhaphang();
        
        public static frm_kho_PhieuNhapHang frmnhaphang = new frm_kho_PhieuNhapHang();
        public frm_kho_PhieuNhapHang()
        {
            InitializeComponent();
            frmnhaphang = this;
        }

        private void frm_kho_PhieuNhapHang_Load(object sender, EventArgs e)
        {
            //dtgvdshanghoa.DataSource = busbanhang.BH_LayDSHangHoa();
            DataSet dts = busnhaphang.NhapHang_getHangHoaNhaCungCap();
            bdsnhacungcap.DataSource = dts;
            bdsnhacungcap.DataMember = "tbNhaCungCap";
            bdshanghoa.DataSource = bdsnhacungcap;
            bdshanghoa.DataMember = "DSHangHoaTheoNCC";
            dtgvnhacungcap.DataSource = bdsnhacungcap;
            dtgvdshanghoa.DataSource = bdshanghoa;
        }

        private void dtgvdshanghoa_DoubleClick(object sender, EventArgs e)
        {
            if(dtgvdshanghoa.SelectedRows[0].Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Có lỗi vui lòng thử lại");
                return;
            }
            DataTable tbHanghoa = busnhaphang.Nhaphang_getHangHoa(dtgvdshanghoa.SelectedRows[0].Cells[0].Value.ToString());
            frm_kho_TTHHnhap frm = new frm_kho_TTHHnhap();
            frm.txtmahh.Text = tbHanghoa.Rows[0][0].ToString();
            frm.txttenhh.Text = tbHanghoa.Rows[0][1].ToString();
            frm.txtloaihh.Text = tbHanghoa.Rows[0][2].ToString();
            frm.txtxuatxu.Text = tbHanghoa.Rows[0][3].ToString();
            frm.txtnhacungcap.Text = tbHanghoa.Rows[0][6].ToString();
            frm.txtdonvitinh.Text = tbHanghoa.Rows[0][5].ToString();
            frm.txtgiaban.Text = tbHanghoa.Rows[0][4].ToString();
            frm.txtsoluongnhap.Text = "1";

            frm.btnsua.Visible = false;
            frm.btnxoa.Visible = false;
            frm.btn_lammoi.Visible = false;
            frm.ShowDialog();
        }
        //ham them san pham vao listbox
        public void themhanghoavaolistview(string soluonhnhap,string mahh)
        {
            DataTable tbHanghoa = busnhaphang.Nhaphang_getHangHoa(dtgvdshanghoa.SelectedRows[0].Cells[0].Value.ToString());
            for(int i = 0; i < lstdshangnhap.Items.Count; i++)
            {
                if (lstdshangnhap.Items[i].SubItems[0].Text.Equals(mahh))
                {
                    int soluongnhaphienco = int.Parse(lstdshangnhap.Items[i].SubItems[7].Text);
                    lstdshangnhap.Items[i].SubItems[7].Text = (soluongnhaphienco + int.Parse(soluonhnhap)).ToString();
                    return;
                }
            }
            ListViewItem item = new ListViewItem(tbHanghoa.Rows[0][0].ToString());
            item.SubItems.Add(tbHanghoa.Rows[0][1].ToString());
            item.SubItems.Add(tbHanghoa.Rows[0][2].ToString());
            item.SubItems.Add(tbHanghoa.Rows[0][3].ToString());
            item.SubItems.Add(tbHanghoa.Rows[0][4].ToString());
            item.SubItems.Add(tbHanghoa.Rows[0][5].ToString());
            item.SubItems.Add(tbHanghoa.Rows[0][6].ToString());
            item.SubItems.Add(soluonhnhap);
            lstdshangnhap.Items.Add(item);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
           DialogResult result =  MessageBox.Show("Khi làm mới danh sách hàng hóa thêm vào khi nhập sẽ bị xóa", "Bạn có chắc chắn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           if(result == DialogResult.Yes)
            {
                lstdshangnhap.Items.Clear();
            }
            else
            {
                return;
            }
           
        }

        private void lstdshangnhap_DoubleClick(object sender, EventArgs e)
        {
            frm_kho_TTHHnhap frm = new frm_kho_TTHHnhap();
            frm.txtmahh.Text = lstdshangnhap.SelectedItems[0].SubItems[0].Text;
            frm.txttenhh.Text = lstdshangnhap.SelectedItems[0].SubItems[1].Text;
            frm.txtloaihh.Text = lstdshangnhap.SelectedItems[0].SubItems[2].Text;
            frm.txtxuatxu.Text = lstdshangnhap.SelectedItems[0].SubItems[3].Text;
            frm.txtnhacungcap.Text = lstdshangnhap.SelectedItems[0].SubItems[4].Text;
            frm.txtdonvitinh.Text = lstdshangnhap.SelectedItems[0].SubItems[5].Text;
            frm.txtgiaban.Text = lstdshangnhap.SelectedItems[0].SubItems[6].Text;
            frm.txtsoluongnhap.Text = lstdshangnhap.SelectedItems[0].SubItems[7].Text;

            frm.btnThem.Visible = false;
            frm.btn_lammoi.Visible = false;
            frm.ShowDialog();
        }
        public void xoaitemtronglistviewhanghoa(string mahh)
        {
            for (int i = 0; i < lstdshangnhap.Items.Count; i++)
            {
                if (lstdshangnhap.Items[i].SubItems[0].Text.Equals(mahh))
                {
                    lstdshangnhap.Items[i].Remove();
                    break;
                }
            }
            MessageBox.Show("xóa hang hóa cần nhập thành công");
        }
        public void suaitemtronglistviewhanghoa(string mahh, int soluong)
        {
            for (int i = 0; i < lstdshangnhap.Items.Count; i++)
            {
                if (lstdshangnhap.Items[i].SubItems[0].Text.Equals(mahh))
                {
                    lstdshangnhap.Items[i].SubItems[7].Text = soluong.ToString();
                    break;
                }
            }
            MessageBox.Show("sửa hang hóa cần nhập thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(dtgvnhacungcap.SelectedRows.Count > 1)
            {
                MessageBox.Show("chỉ chọn được một nhà cung cấp để tiến hành nhập hàng");
            }
            else
            {
                dtgvnhacungcap.Enabled = false;
                dtgvnhacungcap.BackgroundColor = Color.LightGray;
                dtgvdshanghoa.Enabled = true;
                dtgvdshanghoa.BackgroundColor = Color.White;
                //
            }
        }
    }
}
