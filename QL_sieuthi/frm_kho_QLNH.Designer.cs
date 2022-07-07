namespace QL_sieuthi
{
    partial class frm_kho_QLNH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kho_QLNH));
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btn_lammoi = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvhanghoa = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgvnhomhang = new System.Windows.Forms.DataGridView();
            this.bindingSourceNhomHang = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceHangHoa = new System.Windows.Forms.BindingSource(this.components);
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtMaNH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNH = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhomhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhomHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHangHoa)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(492, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 408);
            this.panel2.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthoat,
            this.btn_lammoi,
            this.btnxoa,
            this.btnsua,
            this.btnThem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 354);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(292, 54);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 51);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(36, 51);
            this.btnsua.Text = "Sửa";
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(36, 51);
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Image = global::QL_sieuthi.Properties.Resources.icons8_clear_32;
            this.btn_lammoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_lammoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(58, 51);
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(41, 51);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhóm Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm Hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 79);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.panel4.Controls.Add(this.txttimkiem);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 79);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhóm Hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 408);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvhanghoa);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dtgvnhomhang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(492, 408);
            this.panel5.TabIndex = 1;
            // 
            // dtgvhanghoa
            // 
            this.dtgvhanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvhanghoa.BackgroundColor = System.Drawing.Color.White;
            this.dtgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvhanghoa.Location = new System.Drawing.Point(0, 305);
            this.dtgvhanghoa.Name = "dtgvhanghoa";
            this.dtgvhanghoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvhanghoa.Size = new System.Drawing.Size(492, 49);
            this.dtgvhanghoa.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 354);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(492, 54);
            this.panel6.TabIndex = 1;
            // 
            // dtgvnhomhang
            // 
            this.dtgvnhomhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvnhomhang.BackgroundColor = System.Drawing.Color.White;
            this.dtgvnhomhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhomhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvnhomhang.Location = new System.Drawing.Point(0, 0);
            this.dtgvnhomhang.Name = "dtgvnhomhang";
            this.dtgvnhomhang.ReadOnly = true;
            this.dtgvnhomhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvnhomhang.Size = new System.Drawing.Size(492, 305);
            this.dtgvnhomhang.TabIndex = 0;
            this.dtgvnhomhang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvnhomhang_MouseClick);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderRadius = 10;
            this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiem.DefaultText = "";
            this.txttimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.DisabledState.Parent = this.txttimkiem;
            this.txttimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.FocusedState.Parent = this.txttimkiem;
            this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.HoverState.Parent = this.txttimkiem;
            this.txttimkiem.Location = new System.Drawing.Point(159, 23);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderText = "";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.ShadowDecoration.Parent = this.txttimkiem;
            this.txttimkiem.Size = new System.Drawing.Size(232, 36);
            this.txttimkiem.TabIndex = 1;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtTenNH);
            this.guna2GroupBox1.Controls.Add(this.txtMaNH);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(292, 354);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Thông Tin Nhóm Hàng";
            // 
            // txtMaNH
            // 
            this.txtMaNH.BorderRadius = 10;
            this.txtMaNH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNH.DefaultText = "";
            this.txtMaNH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNH.DisabledState.Parent = this.txtMaNH;
            this.txtMaNH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNH.FocusedState.Parent = this.txtMaNH;
            this.txtMaNH.ForeColor = System.Drawing.Color.Black;
            this.txtMaNH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNH.HoverState.Parent = this.txtMaNH;
            this.txtMaNH.Location = new System.Drawing.Point(115, 66);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.PasswordChar = '\0';
            this.txtMaNH.PlaceholderText = "";
            this.txtMaNH.SelectedText = "";
            this.txtMaNH.ShadowDecoration.Parent = this.txtMaNH;
            this.txtMaNH.Size = new System.Drawing.Size(157, 36);
            this.txtMaNH.TabIndex = 4;
            // 
            // txtTenNH
            // 
            this.txtTenNH.BorderRadius = 10;
            this.txtTenNH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNH.DefaultText = "";
            this.txtTenNH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNH.DisabledState.Parent = this.txtTenNH;
            this.txtTenNH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNH.FocusedState.Parent = this.txtTenNH;
            this.txtTenNH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNH.HoverState.Parent = this.txtTenNH;
            this.txtTenNH.Location = new System.Drawing.Point(115, 108);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.PasswordChar = '\0';
            this.txtTenNH.PlaceholderText = "";
            this.txtTenNH.SelectedText = "";
            this.txtTenNH.ShadowDecoration.Parent = this.txtTenNH;
            this.txtTenNH.Size = new System.Drawing.Size(157, 36);
            this.txtTenNH.TabIndex = 5;
            // 
            // frm_kho_QLNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 487);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_kho_QLNH";
            this.Text = "Quản lý nhóm hàng";
            this.Load += new System.EventHandler(this.frm_kho_QLNH_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhomhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhomHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHangHoa)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btn_lammoi;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvnhomhang;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvhanghoa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource bindingSourceNhomHang;
        private System.Windows.Forms.BindingSource bindingSourceHangHoa;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNH;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
    }
}