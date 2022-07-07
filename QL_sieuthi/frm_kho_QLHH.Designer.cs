namespace QL_sieuthi
{
    partial class frm_kho_QLHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kho_QLHH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstvhanghoa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboLoaiHang = new Guna.UI.WinForms.GunaComboBox();
            this.txtTenHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtXuatXu = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtimeNsx = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtimeHSD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonViTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboNhaCungCap = new Guna.UI.WinForms.GunaComboBox();
            this.txtsoluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.btnBaoCao = new System.Windows.Forms.ToolStripButton();
            this.btn_lammoi = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstvhanghoa);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 586);
            this.panel1.TabIndex = 1;
            // 
            // lstvhanghoa
            // 
            this.lstvhanghoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstvhanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvhanghoa.FullRowSelect = true;
            this.lstvhanghoa.GridLines = true;
            this.lstvhanghoa.HideSelection = false;
            this.lstvhanghoa.Location = new System.Drawing.Point(0, 0);
            this.lstvhanghoa.Name = "lstvhanghoa";
            this.lstvhanghoa.Size = new System.Drawing.Size(785, 532);
            this.lstvhanghoa.TabIndex = 0;
            this.lstvhanghoa.UseCompatibleStateImageBehavior = false;
            this.lstvhanghoa.View = System.Windows.Forms.View.Details;
            this.lstvhanghoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstvhanghoa_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaHH";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TenHang";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LoaiHang";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "XuatXu";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "NgaySx";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "HSD";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "GiaBan";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DonVi";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "NhaCungCap";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Số lượng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 532);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 54);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(785, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 586);
            this.panel2.TabIndex = 2;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtsoluong);
            this.guna2GroupBox1.Controls.Add(this.cboNhaCungCap);
            this.guna2GroupBox1.Controls.Add(this.txtDonViTinh);
            this.guna2GroupBox1.Controls.Add(this.txtGiaBan);
            this.guna2GroupBox1.Controls.Add(this.dtimeHSD);
            this.guna2GroupBox1.Controls.Add(this.dtimeNsx);
            this.guna2GroupBox1.Controls.Add(this.txtXuatXu);
            this.guna2GroupBox1.Controls.Add(this.cboLoaiHang);
            this.guna2GroupBox1.Controls.Add(this.txtTenHH);
            this.guna2GroupBox1.Controls.Add(this.txtMaHH);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(327, 532);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Thông Tin Hàng Hóa";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiHang.BaseColor = System.Drawing.Color.White;
            this.cboLoaiHang.BorderColor = System.Drawing.Color.Silver;
            this.cboLoaiHang.BorderSize = 1;
            this.cboLoaiHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHang.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoaiHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboLoaiHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(110, 132);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboLoaiHang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboLoaiHang.Radius = 10;
            this.cboLoaiHang.Size = new System.Drawing.Size(191, 30);
            this.cboLoaiHang.TabIndex = 2;
            // 
            // txtTenHH
            // 
            this.txtTenHH.BorderColor = System.Drawing.Color.Gray;
            this.txtTenHH.BorderRadius = 10;
            this.txtTenHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHH.DefaultText = "";
            this.txtTenHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHH.DisabledState.Parent = this.txtTenHH;
            this.txtTenHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHH.FocusedState.Parent = this.txtTenHH;
            this.txtTenHH.ForeColor = System.Drawing.Color.Black;
            this.txtTenHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHH.HoverState.Parent = this.txtTenHH;
            this.txtTenHH.Location = new System.Drawing.Point(110, 87);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.PasswordChar = '\0';
            this.txtTenHH.PlaceholderText = "";
            this.txtTenHH.SelectedText = "";
            this.txtTenHH.ShadowDecoration.Parent = this.txtTenHH;
            this.txtTenHH.Size = new System.Drawing.Size(191, 30);
            this.txtTenHH.TabIndex = 25;
            // 
            // txtMaHH
            // 
            this.txtMaHH.BorderColor = System.Drawing.Color.Gray;
            this.txtMaHH.BorderRadius = 10;
            this.txtMaHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHH.DefaultText = "";
            this.txtMaHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHH.DisabledState.Parent = this.txtMaHH;
            this.txtMaHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHH.FocusedState.Parent = this.txtMaHH;
            this.txtMaHH.ForeColor = System.Drawing.Color.Black;
            this.txtMaHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHH.HoverState.Parent = this.txtMaHH;
            this.txtMaHH.Location = new System.Drawing.Point(110, 42);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.PasswordChar = '\0';
            this.txtMaHH.PlaceholderText = "";
            this.txtMaHH.SelectedText = "";
            this.txtMaHH.ShadowDecoration.Parent = this.txtMaHH;
            this.txtMaHH.Size = new System.Drawing.Size(148, 30);
            this.txtMaHH.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xuất xứ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "HSD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Sx";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthoat,
            this.btnBaoCao,
            this.btn_lammoi,
            this.btnsua,
            this.btnxoa,
            this.btnThem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 532);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(327, 54);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1112, 74);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.panel5.Controls.Add(this.txttimkiem);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(785, 74);
            this.panel5.TabIndex = 0;
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
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txttimkiem.ForeColor = System.Drawing.Color.Black;
            this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.HoverState.Parent = this.txttimkiem;
            this.txttimkiem.Location = new System.Drawing.Point(202, 21);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderText = "";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.ShadowDecoration.Parent = this.txttimkiem;
            this.txttimkiem.Size = new System.Drawing.Size(328, 40);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Sản Phẩm";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.BorderColor = System.Drawing.Color.Gray;
            this.txtXuatXu.BorderRadius = 10;
            this.txtXuatXu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXuatXu.DefaultText = "";
            this.txtXuatXu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXuatXu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXuatXu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatXu.DisabledState.Parent = this.txtXuatXu;
            this.txtXuatXu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatXu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatXu.FocusedState.Parent = this.txtXuatXu;
            this.txtXuatXu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtXuatXu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatXu.HoverState.Parent = this.txtXuatXu;
            this.txtXuatXu.Location = new System.Drawing.Point(110, 177);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.PasswordChar = '\0';
            this.txtXuatXu.PlaceholderText = "";
            this.txtXuatXu.SelectedText = "";
            this.txtXuatXu.ShadowDecoration.Parent = this.txtXuatXu;
            this.txtXuatXu.Size = new System.Drawing.Size(122, 30);
            this.txtXuatXu.TabIndex = 26;
            // 
            // dtimeNsx
            // 
            this.dtimeNsx.BorderRadius = 10;
            this.dtimeNsx.CheckedState.Parent = this.dtimeNsx;
            this.dtimeNsx.CustomFormat = "yyyy-MM-dd";
            this.dtimeNsx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtimeNsx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeNsx.HoverState.Parent = this.dtimeNsx;
            this.dtimeNsx.Location = new System.Drawing.Point(110, 222);
            this.dtimeNsx.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtimeNsx.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtimeNsx.Name = "dtimeNsx";
            this.dtimeNsx.ShadowDecoration.Parent = this.dtimeNsx;
            this.dtimeNsx.Size = new System.Drawing.Size(200, 30);
            this.dtimeNsx.TabIndex = 2;
            this.dtimeNsx.Value = new System.DateTime(2022, 7, 6, 14, 8, 46, 202);
            // 
            // dtimeHSD
            // 
            this.dtimeHSD.BorderRadius = 10;
            this.dtimeHSD.CheckedState.Parent = this.dtimeHSD;
            this.dtimeHSD.CustomFormat = "yyyy-MM-dd";
            this.dtimeHSD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtimeHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeHSD.HoverState.Parent = this.dtimeHSD;
            this.dtimeHSD.Location = new System.Drawing.Point(110, 267);
            this.dtimeHSD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtimeHSD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtimeHSD.Name = "dtimeHSD";
            this.dtimeHSD.ShadowDecoration.Parent = this.dtimeHSD;
            this.dtimeHSD.Size = new System.Drawing.Size(200, 30);
            this.dtimeHSD.TabIndex = 27;
            this.dtimeHSD.Value = new System.DateTime(2022, 7, 6, 14, 8, 46, 202);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BorderColor = System.Drawing.Color.Gray;
            this.txtGiaBan.BorderRadius = 10;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.Parent = this.txtGiaBan;
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.FocusedState.Parent = this.txtGiaBan;
            this.txtGiaBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.HoverState.Parent = this.txtGiaBan;
            this.txtGiaBan.Location = new System.Drawing.Point(110, 312);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.ShadowDecoration.Parent = this.txtGiaBan;
            this.txtGiaBan.Size = new System.Drawing.Size(142, 30);
            this.txtGiaBan.TabIndex = 28;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BorderColor = System.Drawing.Color.Gray;
            this.txtDonViTinh.BorderRadius = 10;
            this.txtDonViTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonViTinh.DefaultText = "";
            this.txtDonViTinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonViTinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonViTinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonViTinh.DisabledState.Parent = this.txtDonViTinh;
            this.txtDonViTinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonViTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonViTinh.FocusedState.Parent = this.txtDonViTinh;
            this.txtDonViTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDonViTinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonViTinh.HoverState.Parent = this.txtDonViTinh;
            this.txtDonViTinh.Location = new System.Drawing.Point(110, 357);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.PasswordChar = '\0';
            this.txtDonViTinh.PlaceholderText = "";
            this.txtDonViTinh.SelectedText = "";
            this.txtDonViTinh.ShadowDecoration.Parent = this.txtDonViTinh;
            this.txtDonViTinh.Size = new System.Drawing.Size(166, 30);
            this.txtDonViTinh.TabIndex = 29;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cboNhaCungCap.BaseColor = System.Drawing.Color.White;
            this.cboNhaCungCap.BorderColor = System.Drawing.Color.Silver;
            this.cboNhaCungCap.BorderSize = 1;
            this.cboNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboNhaCungCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(110, 402);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboNhaCungCap.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboNhaCungCap.Radius = 10;
            this.cboNhaCungCap.Size = new System.Drawing.Size(191, 30);
            this.cboNhaCungCap.TabIndex = 30;
            // 
            // txtsoluong
            // 
            this.txtsoluong.BorderColor = System.Drawing.Color.Gray;
            this.txtsoluong.BorderRadius = 10;
            this.txtsoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluong.DefaultText = "";
            this.txtsoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsoluong.DisabledState.Parent = this.txtsoluong;
            this.txtsoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsoluong.FocusedState.Parent = this.txtsoluong;
            this.txtsoluong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtsoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsoluong.HoverState.Parent = this.txtsoluong;
            this.txtsoluong.Location = new System.Drawing.Point(110, 447);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.PasswordChar = '\0';
            this.txtsoluong.PlaceholderText = "";
            this.txtsoluong.SelectedText = "";
            this.txtsoluong.ShadowDecoration.Parent = this.txtsoluong;
            this.txtsoluong.Size = new System.Drawing.Size(194, 30);
            this.txtsoluong.TabIndex = 31;
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
            // btnBaoCao
            // 
            this.btnBaoCao.Image = global::QL_sieuthi.Properties.Resources.icons8_report_card_32;
            this.btnBaoCao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(53, 51);
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
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
            this.btn_lammoi.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            // frm_kho_QLHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_kho_QLHH";
            this.Text = "QLHH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_kho_QLHH_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.ToolStripButton btn_lammoi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lstvhanghoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHH;
        private Guna.UI.WinForms.GunaComboBox cboLoaiHang;
        private Guna.UI2.WinForms.Guna2TextBox txtsoluong;
        private Guna.UI.WinForms.GunaComboBox cboNhaCungCap;
        private Guna.UI2.WinForms.Guna2TextBox txtDonViTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtimeHSD;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtimeNsx;
        private Guna.UI2.WinForms.Guna2TextBox txtXuatXu;
        private System.Windows.Forms.ToolStripButton btnBaoCao;
    }
}