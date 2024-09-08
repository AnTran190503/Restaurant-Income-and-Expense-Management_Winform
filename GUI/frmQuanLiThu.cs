using BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DAL;
using CrystalDecisions.CrystalReports.Engine;

namespace GUI
{
    public partial class frmQuanLiThu : Form
    {
        string strcon = "Data Source=LAPTOP-0GJ5N2UI\\SQLEXPRESS;Initial Catalog=QL_ThuChiQuanAn;Integrated Security=True";

        public frmQuanLiThu()
        {
            InitializeComponent();
        }

        private void frmQuanLiThu_Load(object sender, EventArgs e)
        {
            LoadComboBoxQuy();
            LoadComboBoxNguoiDung();
            btnLammoi.PerformClick();
        }

        private void Lammoi()
        {
            tbPhieuThu.Text = "";
            cbQuy.SelectedIndex = 0;
            cbNguoidung.SelectedIndex = 0;
            tbSoTien.Text = "";
            tbLyDo.Text = "";
            dTPNgaythu.Text = DateTime.Now.ToString();
            tbPhieuThu.Focus();
        }

        private void LoadComboBoxQuy()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                connection.Open();
                string query = "select TenQuy,QuyID from Quy";
                SqlCommand command = new SqlCommand(query, connection);
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

        private void LoadComboBoxNguoiDung()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                connection.Open();
                string query = "select NhanVienID, TenNhanVien from NhanVien";
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
            dgvPhieuThu.DataSource = BLL_PhieuThu.Instance.DanhSach();
            Lammoi();
            tbPhieuThu.Enabled = false;
            cbNguoidung.Enabled = false;
            cbQuy.Enabled = false;
            tbSoTien.Enabled = false;
            tbLyDo.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void tbPhieuThu_KeyPress(object sender, KeyPressEventArgs e)
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
            tbPhieuThu.Enabled = true;
            cbNguoidung.Enabled = true;
            cbQuy.Enabled = true;
            tbSoTien.Enabled = true;
            tbLyDo.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbNguoidung.SelectedValue != null && cbQuy.SelectedValue != null)
            {
                int quyid = (int)cbQuy.SelectedValue;
                int nguoiid = (int)cbNguoidung.SelectedValue;
                int phieuid;

                if (!int.TryParse(tbPhieuThu.Text, out phieuid))
                {
                    MessageBox.Show("Mã phiếu thu không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                float sotien;

                if (!float.TryParse(tbSoTien.Text, out sotien))
                {
                    MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string lydo = tbLyDo.Text;
                string ngay = dTPNgaythu.Text;
                DateTime date;

                if (!DateTime.TryParseExact(ngay, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (BLL_PhieuThu.Instance.Them(phieuid, quyid, nguoiid, sotien, lydo, date.ToString("yyyy/M/d")) == true)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLammoi.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
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
                int phieuid;

                if (!int.TryParse(tbPhieuThu.Text, out phieuid))
                {
                    MessageBox.Show("Mã phiếu thu không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                float sotien;

                if (!float.TryParse(tbSoTien.Text, out sotien))
                {
                    MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string lydo = tbLyDo.Text;
                string ngay = dTPNgaythu.Text;
                DateTime date;

                if (!DateTime.TryParseExact(ngay, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (BLL_PhieuThu.Instance.Sua(phieuid, quyid, nguoiid, sotien, lydo, date.ToString("yyyy/MM/dd")) == true)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLammoi.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPhieuThu.DataBindings.Clear();
            cbNguoidung.DataBindings.Clear();
            cbQuy.DataBindings.Clear();
            tbSoTien.DataBindings.Clear();
            tbLyDo.DataBindings.Clear();
            tbPhieuThu.DataBindings.Add("Text", dgvPhieuThu.DataSource, "PhieuThuID");
            cbNguoidung.DataBindings.Add("Text", dgvPhieuThu.DataSource, "TenNhanVien");
            cbQuy.DataBindings.Add("Text", dgvPhieuThu.DataSource, "TenQuy");
            tbSoTien.DataBindings.Add("Text", dgvPhieuThu.DataSource, "SoTien");
            tbLyDo.DataBindings.Add("Text", dgvPhieuThu.DataSource, "LyDo");
            btnSua.Enabled = true;
            cbNguoidung.Enabled = true;
            cbQuy.Enabled = true;
            tbSoTien.Enabled = true;
            tbLyDo.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                int phieuThuID = Convert.ToInt32(dgvPhieuThu.SelectedRows[0].Cells["PhieuThuID"].Value);

                // Tạo DataTable chỉ chứa dữ liệu cho hàng được chọn
                DataTable dataTable = DataPhieuNhap(phieuThuID);

                if (dataTable.Rows.Count > 0) // Kiểm tra xem có dữ liệu hay không
                {
                    // Tạo và hiển thị báo cáo
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(@"C:\Users\NITRO 5\Desktop\TranBaoAn_NguyenQuocAnh_TranNguyenPhiHung_QL_ThuChiQuanAn\QL_TCQA\GUI\rpPhieuNhap.rpt");
                    reportDocument.SetDataSource(dataTable);

                    frmBaoCaoPhieuThu viewerForm = new frmBaoCaoPhieuThu();
                    viewerForm.crvPhieuThu.ReportSource = reportDocument;
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

        private DataTable DataPhieuNhap(int phieuThuID)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    connection.Open();
                    string query = "select PhieuThuID, TenQuy, TenNhanVien, SoTien, LyDo, NgayThu " +
                                   "from PhieuThu PT " +
                                   "join NhanVien NV on NV.NhanVienID = PT.NhanVienID " +
                                   "join Quy Q on Q.QuyID = PT.QuyID " +
                                   "where PhieuThuID = @PhieuThuID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PhieuThuID", phieuThuID);
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
