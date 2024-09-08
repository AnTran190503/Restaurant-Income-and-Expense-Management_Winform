using GUI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private int vaiTro;

        public frmMain(int roleId)
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.vaiTro = roleId;

            if (vaiTro == 1)
            {
                btnQuanLiQuy.Visible = true;
                btnNhanVien.Visible = true;
                btnPhieuThu.Visible = true;
                btnPhieuChi.Visible = true;
               
                btnThongKe.Visible = true;
            }
            else if (vaiTro == 2)
            {

                btnQuanLiQuy.Visible = false;
                btnNhanVien.Visible = true;
                btnPhieuThu.Visible = true;
                btnPhieuChi.Visible = true;
                
                btnThongKe.Visible = true;
            }
            else
            {

                btnQuanLiQuy.Visible = false;
                btnNhanVien.Visible = false;
                btnPhieuThu.Visible = true;
                btnPhieuChi.Visible = true;
                
                btnThongKe.Visible = false;
            }
        }

        private void btnQuanLiQuy_Click(object sender, EventArgs e)
        {
            frmQuanLiQuy frmQuanLiQuy = new frmQuanLiQuy();

            frmQuanLiQuy.MdiParent = this;
            frmQuanLiQuy.Dock = DockStyle.Fill;
            frmQuanLiQuy.FormBorderStyle = FormBorderStyle.None;

            panelBody.Controls.Clear();
            panelBody.Controls.Add(frmQuanLiQuy);

            frmQuanLiQuy.Show();
            label1.Text = btnQuanLiQuy.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLiNhanVien frmQuanLiNhanVien = new frmQuanLiNhanVien();

            frmQuanLiNhanVien.MdiParent = this;
            frmQuanLiNhanVien.Dock = DockStyle.Fill;
            frmQuanLiNhanVien.FormBorderStyle = FormBorderStyle.None;

            panelBody.Controls.Clear();
            panelBody.Controls.Add(frmQuanLiNhanVien);

            frmQuanLiNhanVien.Show();
            label1.Text = btnNhanVien.Text;
        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            frmQuanLiThu frmQuanLiThu = new frmQuanLiThu();

            frmQuanLiThu.MdiParent = this;
            frmQuanLiThu.Dock = DockStyle.Fill;
            frmQuanLiThu.FormBorderStyle = FormBorderStyle.None;

            panelBody.Controls.Clear();
            panelBody.Controls.Add(frmQuanLiThu);

            frmQuanLiThu.Show();
            label1.Text = btnPhieuThu.Text;
        }

        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            
            FormQuanLiChi FormQuanLiChi = new FormQuanLiChi();

            FormQuanLiChi.MdiParent = this;
            FormQuanLiChi.Dock = DockStyle.Fill;
            FormQuanLiChi.FormBorderStyle = FormBorderStyle.None;

            panelBody.Controls.Clear();
            panelBody.Controls.Add(FormQuanLiChi);

            FormQuanLiChi.Show();
            label1.Text = btnPhieuChi.Text;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKE FormThongKE = new FormThongKE();

            FormThongKE.MdiParent = this;
            FormThongKE.Dock = DockStyle.Fill;
            FormThongKE.FormBorderStyle = FormBorderStyle.None;

            panelBody.Controls.Clear();
            panelBody.Controls.Add(FormThongKE);

            FormThongKE.Show();
            label1.Text = btnThongKe.Text;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
        }
    }
}

