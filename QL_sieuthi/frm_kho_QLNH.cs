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
    
    public partial class frm_kho_QLNH : Form
    {
        QlyNhomHang qlynhomhang = new QlyNhomHang();
        public frm_kho_QLNH()
        {
            InitializeComponent();
        }
        private bool checktextboxnotnull(){
            if (txtMaNH.Text == string.Empty) {
                MessageBox.Show("Vui lòng nhập mã nhóm hàng");
                txtMaNH.Focus();
                return false;
            }
            else if (txtTenNH.Text == string.Empty)
            {
                txtTenNH.Focus();
                MessageBox.Show("Vui lòng nhập Tên nhóm hàng");
                return false;
            }
            return true;
        }
        private void getNhomHangChiTiet() {
          
            DataSet dtnhomhang = qlynhomhang.NH_getNhomHangChiTiet();
            bindingSourceNhomHang.DataSource = dtnhomhang;
            bindingSourceNhomHang.DataMember = "tbNhomHang";
            bindingSourceHangHoa.DataSource = bindingSourceNhomHang;
            bindingSourceHangHoa.DataMember = "DSHangHoaThuocNhomHang";
            qlynhomhang.NH_getNhomHangChiTiet();
            dtgvnhomhang.DataSource = bindingSourceNhomHang;
            dtgvhanghoa.DataSource = bindingSourceHangHoa;
        }
        private void frm_kho_QLNH_Load(object sender, EventArgs e)
        {
            getNhomHangChiTiet();

        }

        private void dtgvnhomhang_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgvnhomhang.SelectedRows.Count.Equals(1))
            {
                txtMaNH.Text = dtgvnhomhang.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNH.Text = dtgvnhomhang.SelectedRows[0].Cells[1].Value.ToString();
                txtMaNH.Enabled = false;
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txtMaNH.Clear();
            txtTenNH.Clear();
            txtMaNH.Enabled = true;
            txtMaNH.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checktextboxnotnull() == true)
            {
                for (int i = 0; i < dtgvnhomhang.Rows.Count - 1; i++)
                {
                    string temp = "";
                    temp+=dtgvnhomhang.Rows[i].Cells[0].Value.ToString();
                    if (temp == txtMaNH.Text)
                    {
                        MessageBox.Show("Mã nhóm hàng đã tồn tại");
                        return;
                    }
                }
                DTO_NhomHang dtonhomhang = new DTO_NhomHang(txtMaNH.Text, txtTenNH.Text);
                qlynhomhang.NH_themNhomHang(dtonhomhang);
                MessageBox.Show("Thêm nhóm hàng thành công");
                getNhomHangChiTiet();
            
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(dtgvhanghoa.Rows.Count > 1)
            {
                MessageBox.Show("Nhóm Hàng Này Tồn Tại Hàng hóa Vui Lòng Thử lại");
                return;
            }
            if (txtMaNH.Text != string.Empty) {
                for (int i = 0; i < dtgvnhomhang.Rows.Count - 1; i++)
                {
                    string temp = "";
                    temp += dtgvnhomhang.Rows[i].Cells[0].Value.ToString();
                    if (temp == txtMaNH.Text)
                    {
                        qlynhomhang.NH_xoaNhomHang(txtMaNH.Text);
                        MessageBox.Show("Xóa nhóm hàng thành công");
                        getNhomHangChiTiet();
                        return;
                    }
                }
               
                MessageBox.Show("Mã nhóm hàng không tồn tại");
            }
            else
            MessageBox.Show("Mã nhóm hàng không được trống");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            
            if (checktextboxnotnull()==true)
            {
                for (int i = 0; i < dtgvnhomhang.Rows.Count - 1; i++)
                {
                    string temp = "";
                    temp += dtgvnhomhang.Rows[i].Cells[0].Value.ToString();
                    if (temp == txtMaNH.Text)
                    {
                        DTO_NhomHang dtonhomhang = new DTO_NhomHang(txtMaNH.Text, txtTenNH.Text);
                        qlynhomhang.NH_suaNhomHang(dtonhomhang);
                        MessageBox.Show("Sửa nhóm hàng thành công");
                        getNhomHangChiTiet();
                        return;
                    }
                }
                MessageBox.Show("Nhóm hàng không tồn tại");
            }
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
             
            DataSet dtnhomhang = qlynhomhang.NH_SearchNhomHang(txttimkiem.Text);
            bindingSourceNhomHang.DataSource = dtnhomhang;
            bindingSourceNhomHang.DataMember = "tbNhomHang";
            bindingSourceHangHoa.DataSource = bindingSourceNhomHang;
            bindingSourceHangHoa.DataMember = "DSHangHoaThuocNhomHang";
            qlynhomhang.NH_SearchNhomHang(txttimkiem.Text);
            dtgvnhomhang.DataSource = bindingSourceNhomHang;
            dtgvhanghoa.DataSource = bindingSourceHangHoa;
        }
    }
}
