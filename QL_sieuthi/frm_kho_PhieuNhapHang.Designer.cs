namespace QL_sieuthi
{
    partial class frm_kho_PhieuNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kho_PhieuNhapHang));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstdshangnhap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvdshanghoa = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvnhacungcap = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.btn_lammoi = new System.Windows.Forms.ToolStripButton();
            this.btnluuphieunhap = new System.Windows.Forms.ToolStripButton();
            this.btnlaphoadon = new System.Windows.Forms.ToolStripButton();
            this.bdshanghoa = new System.Windows.Forms.BindingSource(this.components);
            this.bdsnhacungcap = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdshanghoa)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhacungcap)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdshanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsnhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(794, 397);
            this.guna2Panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstdshangnhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng hóa cần nhập";
            // 
            // lstdshangnhap
            // 
            this.lstdshangnhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstdshangnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstdshangnhap.FullRowSelect = true;
            this.lstdshangnhap.GridLines = true;
            this.lstdshangnhap.HideSelection = false;
            this.lstdshangnhap.Location = new System.Drawing.Point(3, 16);
            this.lstdshangnhap.Name = "lstdshangnhap";
            this.lstdshangnhap.Size = new System.Drawing.Size(788, 306);
            this.lstdshangnhap.TabIndex = 0;
            this.lstdshangnhap.UseCompatibleStateImageBehavior = false;
            this.lstdshangnhap.View = System.Windows.Forms.View.Details;
            this.lstdshangnhap.DoubleClick += new System.EventHandler(this.lstdshangnhap_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma Hang Hoa";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten Hang Hoa";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loai Hang";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Xuat xu";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Don vi tinh";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nha Cung Cap";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "So Luong Nhap";
            this.columnHeader8.Width = 100;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(794, 72);
            this.guna2Panel3.TabIndex = 0;
            // 
            // dtgvdshanghoa
            // 
            this.dtgvdshanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvdshanghoa.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgvdshanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdshanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvdshanghoa.Enabled = false;
            this.dtgvdshanghoa.Location = new System.Drawing.Point(3, 16);
            this.dtgvdshanghoa.Name = "dtgvdshanghoa";
            this.dtgvdshanghoa.ReadOnly = true;
            this.dtgvdshanghoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvdshanghoa.Size = new System.Drawing.Size(395, 135);
            this.dtgvdshanghoa.TabIndex = 28;
            this.dtgvdshanghoa.DoubleClick += new System.EventHandler(this.dtgvdshanghoa_DoubleClick);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.groupBox3);
            this.guna2CustomGradientPanel1.Controls.Add(this.groupBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.toolStrip1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(794, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(401, 450);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvdshanghoa);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 154);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hàng hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvnhacungcap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 170);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dtgvnhacungcap
            // 
            this.dtgvnhacungcap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvnhacungcap.BackgroundColor = System.Drawing.Color.White;
            this.dtgvnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhacungcap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvnhacungcap.Location = new System.Drawing.Point(3, 16);
            this.dtgvnhacungcap.Name = "dtgvnhacungcap";
            this.dtgvnhacungcap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvnhacungcap.Size = new System.Drawing.Size(395, 151);
            this.dtgvnhacungcap.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthoat,
            this.btn_lammoi,
            this.btnluuphieunhap,
            this.btnlaphoadon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 396);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(401, 54);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(401, 72);
            this.guna2Panel2.TabIndex = 1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 397);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(794, 53);
            this.gunaPanel1.TabIndex = 0;
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
            // btn_lammoi
            // 
            this.btn_lammoi.Image = global::QL_sieuthi.Properties.Resources.icons8_clear_32;
            this.btn_lammoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_lammoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(91, 51);
            this.btn_lammoi.Text = "Làm mới phiếu";
            this.btn_lammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_lammoi.ToolTipText = "Làm mới Phiếu";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btnluuphieunhap
            // 
            this.btnluuphieunhap.Image = global::QL_sieuthi.Properties.Resources.icons8_save_32__1_;
            this.btnluuphieunhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnluuphieunhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnluuphieunhap.Name = "btnluuphieunhap";
            this.btnluuphieunhap.Size = new System.Drawing.Size(94, 51);
            this.btnluuphieunhap.Text = "Lưu phiếu nhập";
            this.btnluuphieunhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnlaphoadon
            // 
            this.btnlaphoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnlaphoadon.Image")));
            this.btnlaphoadon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlaphoadon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlaphoadon.Name = "btnlaphoadon";
            this.btnlaphoadon.Size = new System.Drawing.Size(93, 51);
            this.btnlaphoadon.Text = "Lập phiếu nhập";
            this.btnlaphoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlaphoadon.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frm_kho_PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "frm_kho_PhieuNhapHang";
            this.Text = "Nhập Hàng Hóa";
            this.Load += new System.EventHandler(this.frm_kho_PhieuNhapHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdshanghoa)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhacungcap)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdshanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsnhacungcap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.ToolStripButton btn_lammoi;
        private System.Windows.Forms.ToolStripButton btnlaphoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvdshanghoa;
        private System.Windows.Forms.ListView lstdshangnhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvnhacungcap;
        private System.Windows.Forms.BindingSource bdshanghoa;
        private System.Windows.Forms.BindingSource bdsnhacungcap;
        private System.Windows.Forms.ToolStripButton btnluuphieunhap;
    }
}