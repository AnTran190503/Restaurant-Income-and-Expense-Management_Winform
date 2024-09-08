using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CrystalDecisions.CrystalReports.Engine;

namespace GUI
{
    public partial class FormQuanLiChi : Form
    {
        string strcon = "Data Source=LAPTOP-0GJ5N2UI\\SQLEXPRESS;Initial Catalog=QL_ThuChiQuanAn;Integrated Security=True";

        public FormQuanLiChi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcomboboxQuy();
            loadcomboboxNguoiDung();
            btnLammoi.PerformClick();
        }
        private void Lammoi()
        {
            tbPhieuChi.Text = " ";
            cbQuy.SelectedIndex = 0;
            cbNguoidung.SelectedIndex = 0;
            tbSoTien.Text = " ";
            tbLyDo.Text = " ";
            dTPNgaychi.Text = DateTime.Now.ToString();
            tbPhieuChi.Focus();
        }
        private void loadcomboboxQuy()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                connection.Open();
                string query = "select TenQuy,QuyID from Quy";
                SqlCommand command = new SqlCommand(query,connection);
                SqlDataReader read = command.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(read);
                cbQuy.DataSource = tb;
                cbQuy.DisplayMember = "TenQuy";
                cbQuy.ValueMember = "QuyID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void loadcomboboxNguoiDung()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                connection.Open();
                string query = "select NhanVienID,TenNhanVien from NhanVien";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(read);
                cbNguoidung.DataSource = tb;
                cbNguoidung.DisplayMember = "TenNhanVien";
                cbNguoidung.ValueMember = "NhanVienID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            dgvPhieuchi.DataSource = BLL.BLL_PhieuChi.Instance.DanhSach();
            Lammoi();
            tbPhieuChi.Enabled = false;
            cbNguoidung.Enabled = false;
            cbQuy.Enabled = false;
            tbSoTien.Enabled = false;
            tbLyDo.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;

        }

        private void tbPhieuChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbPhieuChi.Enabled = true;
            cbNguoidung.Enabled = true;
            cbQuy.Enabled = true;
            tbSoTien.Enabled = true;
            tbLyDo.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cbNguoidung.SelectedValue != null && cbQuy.SelectedValue != null)
            {
            int quyid = (int)cbQuy.SelectedValue;
            int nguoiid = (int)cbNguoidung.SelectedValue;
            int phieuid = int.Parse(tbPhieuChi.Text);
            float sotien = float.Parse(tbSoTien.Text);
            string lydo = tbLyDo.Text;
            string ngay = dTPNgaychi.Text;
            DateTime date;
            date = DateTime.ParseExact(ngay, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            
            try
            {
                if(BLL_PhieuChi.Instance.Them(phieuid, quyid, nguoiid, sotien, lydo, date.ToString("yyyy/M/d")) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLammoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbNguoidung.SelectedValue != null && cbQuy.SelectedValue != null)
            {
                int quyid = (int)cbQuy.SelectedValue;
                int nguoiid = (int)cbNguoidung.SelectedValue;
                int phieuid = int.Parse(tbPhieuChi.Text);
                float sotien = float.Parse(tbSoTien.Text);
                string lydo = tbLyDo.Text;
                string ngay = dTPNgaychi.Text;
                DateTime date;
                date = DateTime.ParseExact(ngay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                try
                {
                    if (BLL_PhieuChi.Instance.Sua(phieuid, quyid, nguoiid, sotien, lydo, date.ToString("yyyy/MM/dd")) == true)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLammoi.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            }

        private void dgvPhieuchi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPhieuChi.DataBindings.Clear();
            cbNguoidung.DataBindings.Clear();
            cbQuy.DataBindings.Clear();
            tbSoTien.DataBindings.Clear();
            tbLyDo.DataBindings.Clear();
            tbPhieuChi.DataBindings.Add("Text", dgvPhieuchi.DataSource, "PhieuChiID");
            cbNguoidung.DataBindings.Add("Text", dgvPhieuchi.DataSource, "TenNhanVien");
            cbQuy.DataBindings.Add("Text", dgvPhieuchi.DataSource, "TenQuy");
            tbSoTien.DataBindings.Add("Text", dgvPhieuchi.DataSource, "SoTien");
            tbLyDo.DataBindings.Add("Text", dgvPhieuchi.DataSource, "LyDo");
            btnSua.Enabled = true;
            cbNguoidung.Enabled = true;
            cbQuy.Enabled = true;
            tbSoTien.Enabled = true;
            tbLyDo.Enabled = true;
            btnThem.Enabled = false;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvPhieuchi.SelectedRows.Count > 0)
            {
                int phieuThuID = Convert.ToInt32(dgvPhieuchi.SelectedRows[0].Cells[0].Value); // Assuming "PhieuChiID" is the first column


                // Tạo DataTable chỉ chứa dữ liệu cho hàng được chọn
                DataTable dataTable = DataPhieuChi(phieuThuID);

                if (dataTable.Rows.Count > 0) // Kiểm tra xem có dữ liệu hay không
                {
                    // Tạo và hiển thị báo cáo
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(@"C:\Users\NITRO 5\Desktop\TranBaoAn_NguyenQuocAnh_TranNguyenPhiHung_QL_ThuChiQuanAn\QL_TCQA\GUI\rpPhieuChi.rpt");
                    reportDocument.SetDataSource(dataTable);

                    frmBaoCaoPhieuChi viewerForm = new frmBaoCaoPhieuChi();
                    viewerForm.crvPhieuChi.ReportSource = reportDocument;
                    viewerForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho phiếu nhập được chọn.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để in phiếu nhập.");
            }
        }

        private DataTable DataPhieuChi(int phieuChiID)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    connection.Open();
                    string query = "SELECT PC.PhieuChiID, Q.TenQuy, NV.TenNhanVien, PC.SoTien, PC.LyDo, PC.NgayChi " +
                                   "FROM PhieuChi PC " +
                                   "JOIN NhanVien NV ON NV.NhanVienID = PC.NhanVienID " +
                                   "JOIN Quy Q ON Q.QuyID = PC.QuyID " +
                                   "WHERE PC.PhieuChiID = @PhieuChiID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PhieuChiID", phieuChiID);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }

            return dataTable;
        }

    }
}


