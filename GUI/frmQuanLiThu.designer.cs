
namespace GUI
{
    partial class frmQuanLiThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhieuThu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dTPNgaythu = new System.Windows.Forms.DateTimePicker();
            this.cbNguoidung = new System.Windows.Forms.ComboBox();
            this.cbQuy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLyDo = new System.Windows.Forms.TextBox();
            this.tbSoTien = new System.Windows.Forms.TextBox();
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            this.PhieuThuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInPhieuNhap = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.quayLạiToolStripMenuItem.Text = "< Quay lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qũy";
            // 
            // tbPhieuThu
            // 
            this.tbPhieuThu.Enabled = false;
            this.tbPhieuThu.Location = new System.Drawing.Point(127, 32);
            this.tbPhieuThu.Name = "tbPhieuThu";
            this.tbPhieuThu.Size = new System.Drawing.Size(197, 22);
            this.tbPhieuThu.TabIndex = 0;
            this.tbPhieuThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhieuThu_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInPhieuNhap);
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dTPNgaythu);
            this.groupBox1.Controls.Add(this.cbNguoidung);
            this.groupBox1.Controls.Add(this.cbQuy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbLyDo);
            this.groupBox1.Controls.Add(this.tbSoTien);
            this.groupBox1.Controls.Add(this.tbPhieuThu);
            this.groupBox1.Location = new System.Drawing.Point(33, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(754, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập phiếu thu";
            // 
            // btnLammoi
            // 
            this.btnLammoi.AutoSize = true;
            this.btnLammoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLammoi.Location = new System.Drawing.Point(640, 176);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(84, 30);
            this.btnLammoi.TabIndex = 9;
            this.btnLammoi.TabStop = false;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(534, 176);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(433, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 7;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(329, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dTPNgaythu
            // 
            this.dTPNgaythu.Enabled = false;
            this.dTPNgaythu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgaythu.Location = new System.Drawing.Point(481, 128);
            this.dTPNgaythu.Name = "dTPNgaythu";
            this.dTPNgaythu.Size = new System.Drawing.Size(243, 22);
            this.dTPNgaythu.TabIndex = 5;
            // 
            // cbNguoidung
            // 
            this.cbNguoidung.Enabled = false;
            this.cbNguoidung.FormattingEnabled = true;
            this.cbNguoidung.Location = new System.Drawing.Point(127, 127);
            this.cbNguoidung.Name = "cbNguoidung";
            this.cbNguoidung.Size = new System.Drawing.Size(197, 24);
            this.cbNguoidung.TabIndex = 2;
            // 
            // cbQuy
            // 
            this.cbQuy.Enabled = false;
            this.cbQuy.FormattingEnabled = true;
            this.cbQuy.Location = new System.Drawing.Point(127, 79);
            this.cbQuy.Name = "cbQuy";
            this.cbQuy.Size = new System.Drawing.Size(197, 24);
            this.cbQuy.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Người Dùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lý Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID";
            // 
            // tbLyDo
            // 
            this.tbLyDo.Enabled = false;
            this.tbLyDo.Location = new System.Drawing.Point(481, 80);
            this.tbLyDo.Name = "tbLyDo";
            this.tbLyDo.Size = new System.Drawing.Size(243, 22);
            this.tbLyDo.TabIndex = 4;
            // 
            // tbSoTien
            // 
            this.tbSoTien.Enabled = false;
            this.tbSoTien.Location = new System.Drawing.Point(481, 32);
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.Size = new System.Drawing.Size(243, 22);
            this.tbSoTien.TabIndex = 3;
            this.tbSoTien.Text = " ";
            this.tbSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoTien_KeyPress);
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.AllowUserToAddRows = false;
            this.dgvPhieuThu.AllowUserToDeleteRows = false;
            this.dgvPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhieuThuID,
            this.TenQuy,
            this.TenNhanVien,
            this.SoTien,
            this.LyDo,
            this.NgayChi});
            this.dgvPhieuThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuThu.Location = new System.Drawing.Point(0, 252);
            this.dgvPhieuThu.MultiSelect = false;
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.ReadOnly = true;
            this.dgvPhieuThu.RowHeadersVisible = false;
            this.dgvPhieuThu.RowHeadersWidth = 51;
            this.dgvPhieuThu.RowTemplate.Height = 24;
            this.dgvPhieuThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThu.Size = new System.Drawing.Size(800, 247);
            this.dgvPhieuThu.TabIndex = 8;
            this.dgvPhieuThu.TabStop = false;
            this.dgvPhieuThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThu_CellContentClick);
            // 
            // PhieuThuID
            // 
            this.PhieuThuID.DataPropertyName = "PhieuThuID";
            this.PhieuThuID.HeaderText = "Mã Phiếu Thu";
            this.PhieuThuID.MinimumWidth = 6;
            this.PhieuThuID.Name = "PhieuThuID";
            this.PhieuThuID.ReadOnly = true;
            // 
            // TenQuy
            // 
            this.TenQuy.DataPropertyName = "TenQuy";
            this.TenQuy.HeaderText = "Quỹ";
            this.TenQuy.MinimumWidth = 6;
            this.TenQuy.Name = "TenQuy";
            this.TenQuy.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Người dùng";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // NgayChi
            // 
            this.NgayChi.DataPropertyName = "NgayChi";
            this.NgayChi.HeaderText = "Ngày Thu";
            this.NgayChi.MinimumWidth = 6;
            this.NgayChi.Name = "NgayChi";
            this.NgayChi.ReadOnly = true;
            // 
            // btnInPhieuNhap
            // 
            this.btnInPhieuNhap.AutoSize = true;
            this.btnInPhieuNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuNhap.Location = new System.Drawing.Point(53, 176);
            this.btnInPhieuNhap.Name = "btnInPhieuNhap";
            this.btnInPhieuNhap.Size = new System.Drawing.Size(164, 30);
            this.btnInPhieuNhap.TabIndex = 10;
            this.btnInPhieuNhap.Text = "In Phiếu Thu";
            this.btnInPhieuNhap.UseVisualStyleBackColor = false;
            this.btnInPhieuNhap.Click += new System.EventHandler(this.btnInPhieuNhap_Click);
            // 
            // frmQuanLiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhieuThu);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLiThu";
            this.Text = "Quản Lí Thu";
            this.Load += new System.EventHandler(this.frmQuanLiThu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhieuThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dTPNgaythu;
        private System.Windows.Forms.ComboBox cbNguoidung;
        private System.Windows.Forms.ComboBox cbQuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLyDo;
        private System.Windows.Forms.TextBox tbSoTien;
        private System.Windows.Forms.DataGridView dgvPhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhieuThuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChi;
        private System.Windows.Forms.Button btnInPhieuNhap;
    }
}