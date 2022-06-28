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
namespace QL_sieuthi
{
    public partial class frm_kho_QLNCC : Form
    {
        QlyNhaCungCap QlyNCC = new QlyNhaCungCap();
        public frm_kho_QLNCC()
        {
            InitializeComponent();
        }
        private void gethanghoatheoncc() {
            
            DataSet data = QlyNCC.NCC_gethangHoaTheoNCC();
            bdsNhaCungCap.DataSource = data;
            bdsNhaCungCap.DataMember = "tbNhaCungCap";
            bdsHangHoa.DataSource = bdsNhaCungCap;
            bdsHangHoa.DataMember = "DSHangHoaTheoNCC";
            dtgvNhaCungCap.DataSource = bdsNhaCungCap;
            dtgvhanghoa.DataSource = bdsHangHoa;
        }
        private void frm_kho_QLNCC_Load(object sender, EventArgs e)
        {
            gethanghoatheoncc(); 
        }

        private void dtgvNhaCungCap_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgvNhaCungCap.SelectedRows.Count.Equals(1))
            {
                txtMaNCC.Text = dtgvNhaCungCap.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNCC.Text = dtgvNhaCungCap.SelectedRows[0].Cells[1].Value.ToString();
            }
                
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();

        }
        private bool checktextboxnotnull(){
            if(txtMaNCC.Text == string.Empty){
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp");
                txtMaNCC.Focus();
                return false;
            }
            else if (txtTenNCC.Text == string.Empty) {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp");
                txtTenNCC.Focus();
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull() == true) {
                DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text);
                QlyNCC.NCC_themNhaCungCap(dtoNCC);
                MessageBox.Show("Thêm Nhà Cung Cấp Thành Công");
                gethanghoatheoncc(); 
            }
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull() == true)
            {
                DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text);
                QlyNCC.NCC_suaNhaCungCap(dtoNCC);
                MessageBox.Show("Sửa Nhà Cung Cấp Thành Công");
                gethanghoatheoncc();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != string.Empty) {
                QlyNCC.NCC_xoaNhaCungCap(txtMaNCC.Text);
                MessageBox.Show("Xóa Nhà Cung Cấp Thành Công");
                gethanghoatheoncc();
            }
        }

       
    }
}
