
namespace GUI
{
    partial class frmBaoCaoPhieuChi
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
            this.crvPhieuChi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPhieuChi
            // 
            this.crvPhieuChi.ActiveViewIndex = -1;
            this.crvPhieuChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPhieuChi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPhieuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPhieuChi.Location = new System.Drawing.Point(0, 0);
            this.crvPhieuChi.Name = "crvPhieuChi";
            this.crvPhieuChi.Size = new System.Drawing.Size(800, 450);
            this.crvPhieuChi.TabIndex = 0;
            // 
            // frmBaoCaoPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvPhieuChi);
            this.Name = "frmBaoCaoPhieuChi";
            this.Text = "frmBaoCaoPhieuChi";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvPhieuChi;
    }
}