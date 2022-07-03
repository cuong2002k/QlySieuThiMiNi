namespace QL_sieuthi
{
    partial class frm_BH_TTSP
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonGiaHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSLHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThoat,
            this.btnXoa,
            this.btnLuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 221);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(349, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QL_sieuthi.Properties.Resources.icons8_sign_out_32;
            this.btnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 51);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QL_sieuthi.Properties.Resources.icons8_close_32;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(36, 51);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.ToolTipText = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QL_sieuthi.Properties.Resources.icons8_save_32;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(36, 51);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn Giá";
            // 
            // txtMaHH
            // 
            this.txtMaHH.BorderRadius = 10;
            this.txtMaHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHH.DefaultText = "";
            this.txtMaHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHH.DisabledState.Parent = this.txtMaHH;
            this.txtMaHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHH.Enabled = false;
            this.txtMaHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHH.FocusedState.Parent = this.txtMaHH;
            this.txtMaHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHH.HoverState.Parent = this.txtMaHH;
            this.txtMaHH.Location = new System.Drawing.Point(120, 22);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.PasswordChar = '\0';
            this.txtMaHH.PlaceholderText = "";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.SelectedText = "";
            this.txtMaHH.ShadowDecoration.Parent = this.txtMaHH;
            this.txtMaHH.Size = new System.Drawing.Size(172, 30);
            this.txtMaHH.TabIndex = 9;
            // 
            // txtTenHH
            // 
            this.txtTenHH.BorderRadius = 10;
            this.txtTenHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHH.DefaultText = "";
            this.txtTenHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHH.DisabledState.Parent = this.txtTenHH;
            this.txtTenHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHH.Enabled = false;
            this.txtTenHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHH.FocusedState.Parent = this.txtTenHH;
            this.txtTenHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHH.HoverState.Parent = this.txtTenHH;
            this.txtTenHH.Location = new System.Drawing.Point(120, 64);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.PasswordChar = '\0';
            this.txtTenHH.PlaceholderText = "";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.SelectedText = "";
            this.txtTenHH.ShadowDecoration.Parent = this.txtTenHH;
            this.txtTenHH.Size = new System.Drawing.Size(172, 30);
            this.txtTenHH.TabIndex = 10;
            // 
            // txtDonGiaHH
            // 
            this.txtDonGiaHH.BorderRadius = 10;
            this.txtDonGiaHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGiaHH.DefaultText = "";
            this.txtDonGiaHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGiaHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGiaHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaHH.DisabledState.Parent = this.txtDonGiaHH;
            this.txtDonGiaHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaHH.Enabled = false;
            this.txtDonGiaHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaHH.FocusedState.Parent = this.txtDonGiaHH;
            this.txtDonGiaHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaHH.HoverState.Parent = this.txtDonGiaHH;
            this.txtDonGiaHH.Location = new System.Drawing.Point(120, 147);
            this.txtDonGiaHH.Name = "txtDonGiaHH";
            this.txtDonGiaHH.PasswordChar = '\0';
            this.txtDonGiaHH.PlaceholderText = "";
            this.txtDonGiaHH.ReadOnly = true;
            this.txtDonGiaHH.SelectedText = "";
            this.txtDonGiaHH.ShadowDecoration.Parent = this.txtDonGiaHH;
            this.txtDonGiaHH.Size = new System.Drawing.Size(172, 30);
            this.txtDonGiaHH.TabIndex = 11;
            // 
            // txtSLHH
            // 
            this.txtSLHH.BorderRadius = 10;
            this.txtSLHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLHH.DefaultText = "";
            this.txtSLHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSLHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSLHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSLHH.DisabledState.Parent = this.txtSLHH;
            this.txtSLHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSLHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSLHH.FocusedState.Parent = this.txtSLHH;
            this.txtSLHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSLHH.HoverState.Parent = this.txtSLHH;
            this.txtSLHH.Location = new System.Drawing.Point(120, 105);
            this.txtSLHH.Name = "txtSLHH";
            this.txtSLHH.PasswordChar = '\0';
            this.txtSLHH.PlaceholderText = "";
            this.txtSLHH.SelectedText = "";
            this.txtSLHH.ShadowDecoration.Parent = this.txtSLHH;
            this.txtSLHH.Size = new System.Drawing.Size(172, 30);
            this.txtSLHH.TabIndex = 12;
            // 
            // frm_BH_TTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 275);
            this.Controls.Add(this.txtSLHH);
            this.Controls.Add(this.txtDonGiaHH);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_BH_TTSP";
            this.ShowIcon = false;
            this.Text = "Thông Tin Hàng Hóa Bán";
            this.Load += new System.EventHandler(this.frm_BH_TTSP_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox txtMaHH;
        public Guna.UI2.WinForms.Guna2TextBox txtTenHH;
        public Guna.UI2.WinForms.Guna2TextBox txtDonGiaHH;
        public Guna.UI2.WinForms.Guna2TextBox txtSLHH;
    }
}