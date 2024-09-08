
namespace GUI
{
    partial class frmBaoCaoPhieuThu
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
            this.crvPhieuThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPhieuThu
            // 
            this.crvPhieuThu.ActiveViewIndex = -1;
            this.crvPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPhieuThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.crvPhieuThu.Name = "crvPhieuThu";
            this.crvPhieuThu.Size = new System.Drawing.Size(800, 450);
            this.crvPhieuThu.TabIndex = 0;
            // 
            // frmBaoCaoPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvPhieuThu);
            this.Name = "frmBaoCaoPhieuThu";
            this.Text = "frmBaoCaoPhieuThu";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvPhieuThu;
    }
}