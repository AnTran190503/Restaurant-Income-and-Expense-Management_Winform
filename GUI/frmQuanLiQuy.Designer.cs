
namespace GUI
{
    partial class frmQuanLiQuy
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
            this.txtQuyID = new System.Windows.Forms.TextBox();
            this.cbTenQuy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiQuy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoDu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvQuy = new System.Windows.Forms.DataGridView();
            this.QuyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quỹ ID";
            // 
            // txtQuyID
            // 
            this.txtQuyID.Location = new System.Drawing.Point(207, 34);
            this.txtQuyID.Name = "txtQuyID";
            this.txtQuyID.Size = new System.Drawing.Size(218, 22);
            this.txtQuyID.TabIndex = 1;
            // 
            // cbTenQuy
            // 
            this.cbTenQuy.FormattingEnabled = true;
            this.cbTenQuy.Location = new System.Drawing.Point(207, 89);
            this.cbTenQuy.Name = "cbTenQuy";
            this.cbTenQuy.Size = new System.Drawing.Size(218, 24);
            this.cbTenQuy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Quỹ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại Quỹ";
            // 
            // cbLoaiQuy
            // 
            this.cbLoaiQuy.FormattingEnabled = true;
            this.cbLoaiQuy.Location = new System.Drawing.Point(613, 35);
            this.cbLoaiQuy.Name = "cbLoaiQuy";
            this.cbLoaiQuy.Size = new System.Drawing.Size(218, 24);
            this.cbLoaiQuy.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Dư";
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(613, 93);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(218, 22);
            this.txtSoDu.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(134, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 41);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(796, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 41);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvQuy
            // 
            this.dgvQuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuyID,
            this.TenQuy,
            this.LoaiQuy,
            this.SoDu});
            this.dgvQuy.Location = new System.Drawing.Point(12, 246);
            this.dgvQuy.Name = "dgvQuy";
            this.dgvQuy.RowHeadersWidth = 51;
            this.dgvQuy.RowTemplate.Height = 24;
            this.dgvQuy.Size = new System.Drawing.Size(938, 368);
            this.dgvQuy.TabIndex = 12;
            // 
            // QuyID
            // 
            this.QuyID.DataPropertyName = "QuyID";
            this.QuyID.HeaderText = "QuyID";
            this.QuyID.MinimumWidth = 6;
            this.QuyID.Name = "QuyID";
            this.QuyID.Width = 170;
            // 
            // TenQuy
            // 
            this.TenQuy.DataPropertyName = "TenQuy";
            this.TenQuy.HeaderText = "TenQuy";
            this.TenQuy.MinimumWidth = 6;
            this.TenQuy.Name = "TenQuy";
            this.TenQuy.Width = 170;
            // 
            // LoaiQuy
            // 
            this.LoaiQuy.DataPropertyName = "LoaiQuy";
            this.LoaiQuy.HeaderText = "LoaiQuy";
            this.LoaiQuy.MinimumWidth = 6;
            this.LoaiQuy.Name = "LoaiQuy";
            this.LoaiQuy.Width = 170;
            // 
            // SoDu
            // 
            this.SoDu.DataPropertyName = "SoDu";
            this.SoDu.HeaderText = "SoDu";
            this.SoDu.MinimumWidth = 6;
            this.SoDu.Name = "SoDu";
            this.SoDu.Width = 170;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(435, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 41);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Location = new System.Drawing.Point(604, 165);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(125, 41);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(285, 165);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 41);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQuanLiQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(962, 615);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvQuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoDu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLoaiQuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTenQuy);
            this.Controls.Add(this.txtQuyID);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLiQuy";
            this.Text = "Quản Lí Quỹ";
            this.Load += new System.EventHandler(this.frmQuanLiQuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuyID;
        private System.Windows.Forms.ComboBox cbTenQuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiQuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoDu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvQuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLuu;
    }
}