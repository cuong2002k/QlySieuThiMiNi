namespace QL_sieuthi
{
    partial class frm_BH_QLBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BH_QLBH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstHangHoa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBarcodeHangHoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvDsHangHoa = new System.Windows.Forms.DataGridView();
            this.btnTien = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangHoa)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstHangHoa);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 586);
            this.panel1.TabIndex = 0;
            // 
            // lstHangHoa
            // 
            this.lstHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHangHoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHangHoa.FullRowSelect = true;
            this.lstHangHoa.GridLines = true;
            this.lstHangHoa.HideSelection = false;
            this.lstHangHoa.Location = new System.Drawing.Point(0, 0);
            this.lstHangHoa.Name = "lstHangHoa";
            this.lstHangHoa.Size = new System.Drawing.Size(605, 514);
            this.lstHangHoa.TabIndex = 2;
            this.lstHangHoa.UseCompatibleStateImageBehavior = false;
            this.lstHangHoa.View = System.Windows.Forms.View.Details;
            this.lstHangHoa.DoubleClick += new System.EventHandler(this.lstHangHoa_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Hàng Hóa";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Hàng Hóa";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn Giá";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBarcodeHangHoa);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 514);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 72);
            this.panel3.TabIndex = 1;
            // 
            // txtBarcodeHangHoa
            // 
            this.txtBarcodeHangHoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcodeHangHoa.BorderRadius = 10;
            this.txtBarcodeHangHoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcodeHangHoa.DefaultText = "";
            this.txtBarcodeHangHoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarcodeHangHoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarcodeHangHoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcodeHangHoa.DisabledState.Parent = this.txtBarcodeHangHoa;
            this.txtBarcodeHangHoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcodeHangHoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcodeHangHoa.FocusedState.Parent = this.txtBarcodeHangHoa;
            this.txtBarcodeHangHoa.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtBarcodeHangHoa.ForeColor = System.Drawing.Color.Black;
            this.txtBarcodeHangHoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcodeHangHoa.HoverState.Parent = this.txtBarcodeHangHoa;
            this.txtBarcodeHangHoa.Location = new System.Drawing.Point(136, 20);
            this.txtBarcodeHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBarcodeHangHoa.Name = "txtBarcodeHangHoa";
            this.txtBarcodeHangHoa.PasswordChar = '\0';
            this.txtBarcodeHangHoa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarcodeHangHoa.PlaceholderText = "Mã sản phẩm";
            this.txtBarcodeHangHoa.SelectedText = "";
            this.txtBarcodeHangHoa.ShadowDecoration.Parent = this.txtBarcodeHangHoa;
            this.txtBarcodeHangHoa.Size = new System.Drawing.Size(404, 40);
            this.txtBarcodeHangHoa.TabIndex = 2;
            this.txtBarcodeHangHoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeHangHoa_KeyDown_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::QL_sieuthi.Properties.Resources.icons8_barcode_96__1_;
            this.pictureBox1.Location = new System.Drawing.Point(80, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvDsHangHoa);
            this.panel2.Controls.Add(this.btnTien);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(605, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 586);
            this.panel2.TabIndex = 1;
            // 
            // dtgvDsHangHoa
            // 
            this.dtgvDsHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDsHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDsHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDsHangHoa.Location = new System.Drawing.Point(0, 78);
            this.dtgvDsHangHoa.Name = "dtgvDsHangHoa";
            this.dtgvDsHangHoa.ReadOnly = true;
            this.dtgvDsHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDsHangHoa.Size = new System.Drawing.Size(397, 436);
            this.dtgvDsHangHoa.TabIndex = 2;
            this.dtgvDsHangHoa.DoubleClick += new System.EventHandler(this.dtgvDsHangHoa_DoubleClick);
            // 
            // btnTien
            // 
            this.btnTien.CheckedState.Parent = this.btnTien;
            this.btnTien.CustomImages.Parent = this.btnTien;
            this.btnTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTien.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnTien.ForeColor = System.Drawing.Color.White;
            this.btnTien.HoverState.Parent = this.btnTien;
            this.btnTien.Location = new System.Drawing.Point(0, 514);
            this.btnTien.Name = "btnTien";
            this.btnTien.ShadowDecoration.Parent = this.btnTien;
            this.btnTien.Size = new System.Drawing.Size(397, 72);
            this.btnTien.TabIndex = 5;
            this.btnTien.Text = "0";
            this.btnTien.Click += new System.EventHandler(this.btnTien_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.guna2TextBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 78);
            this.panel4.TabIndex = 4;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(102, 18);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm sản phẩm";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(234, 42);
            this.guna2TextBox1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QL_sieuthi.Properties.Resources.icons8_search_64;
            this.pictureBox2.Location = new System.Drawing.Point(43, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frm_BH_QLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_BH_QLBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.frm_BH_QLBH_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangHoa)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvDsHangHoa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ListView lstHangHoa;
        private Guna.UI2.WinForms.Guna2TextBox txtBarcodeHangHoa;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnTien;
    }
}