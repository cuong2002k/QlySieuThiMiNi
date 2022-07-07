namespace QL_sieuthi
{
    partial class frm_kho_ReportHH
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
            this.rpvHangHoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpvHangHoa
            // 
            this.rpvHangHoa.ActiveViewIndex = -1;
            this.rpvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvHangHoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHangHoa.Location = new System.Drawing.Point(0, 0);
            this.rpvHangHoa.Name = "rpvHangHoa";
            this.rpvHangHoa.Size = new System.Drawing.Size(800, 450);
            this.rpvHangHoa.TabIndex = 0;
            // 
            // frm_kho_ReportHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvHangHoa);
            this.Name = "frm_kho_ReportHH";
            this.Text = "frm_kho_ReportHH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpvHangHoa;
    }
}