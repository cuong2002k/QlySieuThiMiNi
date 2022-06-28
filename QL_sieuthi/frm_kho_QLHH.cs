using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_Qlysieuthi;
using BUS_Qlysieuthi;
namespace QL_sieuthi
{
    public partial class frm_kho_QLHH : Form
    {
        Qlykho qlykho = new Qlykho();

        public frm_kho_QLHH()
        {
            InitializeComponent();
        }
        /// <summary>
        /// hàm lấy tất cả hàng hóa
        /// </summary>
        /// <param name="lstvhanghoa">truyền vào một listview</param>
        /// <param name="dthanghoa">truyền vào một datatable</param>
        private void LayDSHH(ListView lstvhanghoa, DataTable dthanghoa)
        {
            //làm mới listview
            lstvhanghoa.Items.Clear();
            for (int i = 0; i < dthanghoa.Rows.Count; i++)
            {
                //tạo một item
                ListViewItem item = new ListViewItem(dthanghoa.Rows[i]["MaHH"].ToString());
                // thêm dữ liệu vào subtem
                item.SubItems.Add(dthanghoa.Rows[i]["TenHang"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["LoaiHang"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["XuatXu"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["NgaySX"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["HSD"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["GiaBan"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["DonViTinh"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["NhaCungCap"].ToString());
                item.SubItems.Add(dthanghoa.Rows[i]["SoLuong"].ToString());
                //them vào bảng
                lstvhanghoa.Items.Add(item);
            }
           
        }
        // hàm load dữ liệu khi chạy app
        private void frm_kho_QLHH_Load(object sender, EventArgs e)
        {
            DataTable dthanghoa = qlykho.KHO_getHangHoa();
            LayDSHH(lstvhanghoa, dthanghoa);
            DataTable dtnhomhang = qlykho.KHO_getNhomHang();
            for (int i = 0; i < dtnhomhang.Rows.Count; i++)
            {
                cboLoaiHang.Items.Add(dtnhomhang.Rows[i]["TenNH"].ToString());
                
            }

            DataTable dtnhacungcap = qlykho.KHO_getNhaCungCap();
            for (int i = 0; i < dtnhacungcap.Rows.Count; i++)
            {
                cboNhaCungCap.Items.Add(dtnhacungcap.Rows[i]["TenNCC"].ToString());

            }
        }

        private void lstvhanghoa_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaHH.Text = lstvhanghoa.SelectedItems[0].SubItems[0].Text;
            txtTenHH.Text = lstvhanghoa.SelectedItems[0].SubItems[1].Text;
            cboLoaiHang.Text = lstvhanghoa.SelectedItems[0].SubItems[2].Text;
            txtXuatXu.Text = lstvhanghoa.SelectedItems[0].SubItems[3].Text;
            dtimeHSD.Text = lstvhanghoa.SelectedItems[0].SubItems[5].Text;
            dtimeNsx.Text = lstvhanghoa.SelectedItems[0].SubItems[4].Text;
            txtGiaBan.Text = lstvhanghoa.SelectedItems[0].SubItems[6].Text;
            txtDonViTinh.Text = lstvhanghoa.SelectedItems[0].SubItems[7].Text;
            cboNhaCungCap.Text = lstvhanghoa.SelectedItems[0].SubItems[8].Text;
            txtsoluong.Text = lstvhanghoa.SelectedItems[0].SubItems[9].Text;
            txtMaHH.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clearTextBox()
        {
            txtMaHH.Clear();
            txtTenHH.Clear();
            cboLoaiHang.SelectedItem = 0;
            txtXuatXu.Clear();
            txtGiaBan.Clear();
            txtDonViTinh.Clear();
            cboNhaCungCap.SelectedItem = 0;
            txtsoluong.Clear();
            txtMaHH.Enabled = true;
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            clearTextBox();
            txtMaHH.Focus();
        }
        // hàm check textbox not null
        private bool checkTextBoxNotNULL(){
            if(txtMaHH.Text == string.Empty){
                MessageBox.Show("Vui lòng nhập Mã Hàng Hóa");
                txtMaHH.Focus();
                return false;
            }
            if(txtTenHH.Text == string.Empty ){
                MessageBox.Show("Vui lòng nhập Tên Hàng Hóa");
                txtTenHH.Focus();
                return false;
            }
            if(cboLoaiHang.Text == string.Empty){
                MessageBox.Show("Vui lòng chọn loại hàng hóa");
                return false;
            }
            if( txtXuatXu.Text == string.Empty ){
                MessageBox.Show("Vui lòng nhập Xuất xứ");
                txtXuatXu.Focus();
                return false;
            }
            if( dtimeNsx.Text == string.Empty){
                MessageBox.Show("Vui lòng nhập Ngày Sản Xuất");
                dtimeNsx.Focus();
                return false;
            }
            if(dtimeHSD.Text == string.Empty ){
                MessageBox.Show("Vui lòng nhập Hạn sử dụng");
                dtimeHSD.Focus();
                return false;
            }

            if( txtGiaBan.Text == string.Empty ){
                MessageBox.Show("Vui lòng nhập Giá bán");
                txtGiaBan.Focus();
                return false;
            }
            if(txtDonViTinh.Text == string.Empty ){
                MessageBox.Show("Vui lòng nhập Đơn Vị Tính");
                txtDonViTinh.Focus();
                return false;
            }
            if( cboNhaCungCap.Text == string.Empty){
                MessageBox.Show("Vui lòng Chọn Nhà Cung Cấp");
                return false;
            }
            if (txtsoluong.Text == string.Empty) {
                MessageBox.Show("Vui lòng nhập số lượng");
                txtsoluong.Focus();
                return false;
            }
            return true;
        }
        //btn them hang hoa 
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkTextBoxNotNULL()==true)
            {

                DataTable dthanghoa = qlykho.KHO_getHangHoa();
                for (int i = 0; i < dthanghoa.Rows.Count; i++) {
                    if (dthanghoa.Rows[i]["MaHH"].Equals(txtMaHH.Text)) {
                        MessageBox.Show("Mã Hàng hóa đã tồn tại!!!");
                        return;
                    }
                }
                DataTable nhomhang = qlykho.KHO_getNhomHang();
                DataTable nhacungcap = qlykho.KHO_getNhaCungCap();
                string LoaiHang = nhomhang.Rows[cboLoaiHang.SelectedIndex]["MaNH"].ToString();
                string NhaCungCap = nhacungcap.Rows[cboNhaCungCap.SelectedIndex]["MaNCC"].ToString();
                DTOHangHoa hanghoa = new DTOHangHoa(txtMaHH.Text, txtTenHH.Text, LoaiHang, txtXuatXu.Text, dtimeNsx.Text, dtimeHSD.Text, int.Parse(txtGiaBan.Text), txtDonViTinh.Text, NhaCungCap, int.Parse(txtsoluong.Text));
                qlykho.KHO_themHangHoa(hanghoa);
                MessageBox.Show("Thêm hàng hóa thành công");
                DataTable dthanghoa1 = qlykho.KHO_getHangHoa();
                LayDSHH(lstvhanghoa,dthanghoa1);
                clearTextBox();
            }
           
            
        }
        // sua hang hoa 
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checkTextBoxNotNULL() == true)
            {
                DataTable nhomhang = qlykho.KHO_getNhomHang();
                DataTable nhacungcap = qlykho.KHO_getNhaCungCap();
                string LoaiHang = nhomhang.Rows[cboLoaiHang.SelectedIndex]["MaNH"].ToString();
                string NhaCungCap = nhacungcap.Rows[cboNhaCungCap.SelectedIndex]["MaNCC"].ToString();
                DTOHangHoa hanghoa = new DTOHangHoa(txtMaHH.Text, txtTenHH.Text, LoaiHang, txtXuatXu.Text, dtimeNsx.Text, dtimeHSD.Text, int.Parse(txtGiaBan.Text), txtDonViTinh.Text, NhaCungCap, int.Parse(txtsoluong.Text));
                qlykho.KHO_suaHangHoa(hanghoa);
                MessageBox.Show("Sửa hàng hóa thành công");
                DataTable dthanghoa = qlykho.KHO_getHangHoa();
                LayDSHH(lstvhanghoa, dthanghoa);
                clearTextBox();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataTable dthanghoa = qlykho.KHO_getHangHoa();
            for (int i = 0; i < dthanghoa.Rows.Count; i++)
            {
                if (dthanghoa.Rows[i]["MaHH"].Equals(txtMaHH.Text))
                {
                    qlykho.KHO_xoaHangHoa(txtMaHH.Text);
                    MessageBox.Show("Xóa Thanh công");
                    dthanghoa = qlykho.KHO_getHangHoa();
                    LayDSHH(lstvhanghoa, dthanghoa);
                    clearTextBox();
                    return;
                }
            }
            MessageBox.Show("Mã Hàng hóa khong tồn tại!!!");
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dthanghoa = qlykho.KHO_timKiemHangHoa(txttimkiem.Text);
            LayDSHH(lstvhanghoa, dthanghoa);
        }

        
        

       
       

        
    }
}
