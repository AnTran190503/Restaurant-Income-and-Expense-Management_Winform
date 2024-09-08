using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmQuanLiNhanVien : Form
    {
        public frmQuanLiNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            LoadDanhSachQuyen();
            btnLuu.Click += btnLuu_Click;
        }
        private void LoadDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = BLL_NhanVien.Instance.LayDanhSachNhanVien();
            
        }
        // GUI/frmQuanLiNhanVien.cs
        private void LoadDanhSachQuyen()
        {
            List<int> danhSachQuyen = BLL_NhanVien.Instance.LayDanhSachQuyen();
            cbQuyen.DataSource = danhSachQuyen;
        }
        


        private void btnThem_Click(object sender, EventArgs e)
        {
            txtNhanVienID.Text = "";
            txtTenNhanVien.Text = ""; // Chọn index -1 để không có giá trị được chọn
            txtMatKhau.Text = "";
            cbQuyen.SelectedIndex = -1;

            // Bật tính năng chỉnh sửa cho TextBox và ComboBox
            txtNhanVienID.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtMatKhau.Enabled = true;
            cbQuyen.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một Nhân Viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ dòng được chọn
            DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
            int nhanVienID = Convert.ToInt32(selectedRow.Cells["NhanVienID"].Value);
            string tenNhanVien = Convert.ToString(selectedRow.Cells["TenNhanVien"].Value);
            string matKhau = Convert.ToString(selectedRow.Cells["MatKhau"].Value);
            int quyenID = Convert.ToInt32(selectedRow.Cells["RoleId"].Value);

            // Hiển thị thông tin lên các điều khiển để người dùng chỉnh sửa
            txtNhanVienID.Text = nhanVienID.ToString();
            txtTenNhanVien.Text = tenNhanVien;
            txtMatKhau.Text = matKhau;
            cbQuyen.SelectedItem = quyenID;

            // Bật tính năng chỉnh sửa cho TextBox và ComboBox
            txtNhanVienID.Enabled = false; // Không cho sửa NhanVienID
            txtTenNhanVien.Enabled = true;
            txtMatKhau.Enabled = true;
            cbQuyen.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ dòng được chọn
            DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
            int nhanVienID = Convert.ToInt32(selectedRow.Cells["NhanVienID"].Value);

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txtNhanVienID.Text) || string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || cbQuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra chuyển đổi dữ liệu đầu vào thành số nguyên
            int newNhanVienID;
            if (!int.TryParse(txtNhanVienID.Text, out newNhanVienID))
            {
                MessageBox.Show("NhanVienID phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giá trị của quyền từ ComboBox
            int quyenID = (int)cbQuyen.SelectedItem;

            // Gọi hàm cập nhật nhân viên từ BLL và kiểm tra kết quả
            bool result = BLL_NhanVien.Instance.CapNhatNhanVien(nhanVienID, newNhanVienID, txtTenNhanVien.Text, txtMatKhau.Text, quyenID);

            if (result)
            {
                MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại danh sách nhân viên
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Đặt lại trạng thái của các điều khiển
            txtNhanVienID.Text = "";
            txtTenNhanVien.Text = "";
            txtMatKhau.Text = "";
            cbQuyen.SelectedIndex = -1;

            txtNhanVienID.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtMatKhau.Enabled = false;
            cbQuyen.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ dòng được chọn
            DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
            int nhanVienID = Convert.ToInt32(selectedRow.Cells["NhanVienID"].Value);

            // Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Gọi hàm xóa nhân viên từ BLL và kiểm tra kết quả
                bool result = BLL_NhanVien.Instance.XoaNhanVien(nhanVienID);

                // Xử lý kết quả và hiển thị thông báo
                HandleOperationResult(result, "Xóa nhân viên");

                // Load lại danh sách nhân viên sau khi xóa
                LoadDanhSachNhanVien();
            }
        }

        private void HandleOperationResult(bool result, string operation)
        {
            if (result)
            {
                MessageBox.Show($"{operation} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Có lỗi xảy ra. {operation} không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetControls()
        {
            txtNhanVienID.Text = "";
            txtTenNhanVien.Text = "";
            txtMatKhau.Text = "";
            cbQuyen.SelectedIndex = -1;
        }

        private void EnableControls(bool enable)
        {
            txtNhanVienID.Enabled = enable;
            txtTenNhanVien.Enabled = enable;
            txtMatKhau.Enabled = enable;
            cbQuyen.Enabled = enable;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txtNhanVienID.Text) || string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || cbQuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra chuyển đổi dữ liệu đầu vào thành số nguyên
            int newNhanVienID;
            if (!int.TryParse(txtNhanVienID.Text, out newNhanVienID))
            {
                MessageBox.Show("NhanVienID phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giá trị của quyền từ ComboBox
            int quyenID = (int)cbQuyen.SelectedItem;

            // Kiểm tra trạng thái form để xác định là thêm mới hay cập nhật
            if (txtNhanVienID.Enabled) // Thêm mới
            {
                // Gọi hàm thêm mới nhân viên từ BLL và kiểm tra kết quả
                bool result = BLL_NhanVien.Instance.ThemNhanVien(newNhanVienID, txtTenNhanVien.Text, txtMatKhau.Text, quyenID);

                // Xử lý kết quả và hiển thị thông báo
                HandleOperationResult(result, "Thêm mới nhân viên");
            }
            else // Cập nhật
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
                int nhanVienID = Convert.ToInt32(selectedRow.Cells["NhanVienID"].Value);

                // Gọi hàm cập nhật nhân viên từ BLL và kiểm tra kết quả
                bool result = BLL_NhanVien.Instance.CapNhatNhanVien(nhanVienID, newNhanVienID, txtTenNhanVien.Text, txtMatKhau.Text, quyenID);

                // Xử lý kết quả và hiển thị thông báo
                HandleOperationResult(result, "Cập nhật nhân viên");
            }

            // Load lại danh sách nhân viên sau khi thêm mới hoặc cập nhật
            LoadDanhSachNhanVien();

            // Đặt lại trạng thái của các điều khiển
            ResetControls();
            EnableControls(false);
        }
    }
}
