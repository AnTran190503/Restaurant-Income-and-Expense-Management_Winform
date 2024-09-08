using BLL;
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
    public partial class frmQuanLiQuy : Form
    {
        public frmQuanLiQuy()
        {
            InitializeComponent();
        }



        private void frmQuanLiQuy_Load(object sender, EventArgs e)
        {
            dgvQuy.DataSource = BLL_Quy.Instance.DanhSachQuy();
            BLL_Quy.Instance.LoadComboBoxQuy(cbTenQuy);
            BLL_Quy.Instance.LoadComboBoxLoaiQuy(cbLoaiQuy);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtQuyID.Text = "";
            cbTenQuy.SelectedIndex = -1; // Chọn index -1 để không có giá trị được chọn
            cbLoaiQuy.SelectedIndex = -1;
            txtSoDu.Text = "";

            // Bật tính năng chỉnh sửa cho TextBox và ComboBox
            txtQuyID.Enabled = true;
            cbTenQuy.Enabled = true;
            cbLoaiQuy.Enabled = true;
            txtSoDu.Enabled = true;
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dgvQuy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một quỹ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ dòng được chọn
            DataGridViewRow selectedRow = dgvQuy.SelectedRows[0];
            int quyID = Convert.ToInt32(selectedRow.Cells["QuyID"].Value);
            string tenQuy = Convert.ToString(selectedRow.Cells["TenQuy"].Value);
            string loaiQuy = Convert.ToString(selectedRow.Cells["LoaiQuy"].Value);
            float soDu = Convert.ToSingle(selectedRow.Cells["SoDu"].Value);

            // Hiển thị thông tin lên các điều khiển để người dùng chỉnh sửa
            txtQuyID.Text = quyID.ToString();
            cbTenQuy.Text = tenQuy;
            cbLoaiQuy.Text = loaiQuy;
            txtSoDu.Text = soDu.ToString();

            // Bật tính năng chỉnh sửa cho TextBox và ComboBox
            txtQuyID.Enabled = false; // Không cho sửa QuyID
            cbTenQuy.Enabled = true;
            cbLoaiQuy.Enabled = true;
            txtSoDu.Enabled = true;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvQuy.SelectedRows[0];
            int quyID = Convert.ToInt32(selectedRow.Cells["QuyID"].Value);
            string tenQuy = Convert.ToString(selectedRow.Cells["TenQuy"].Value);
            string loaiQuy = Convert.ToString(selectedRow.Cells["LoaiQuy"].Value);
            float soDu = Convert.ToSingle(selectedRow.Cells["SoDu"].Value);

            bool result = BLL_Quy.Instance.SuaQuy(quyID, cbTenQuy.Text, cbLoaiQuy.Text, soDu);

            if (result)
            {
                MessageBox.Show("Cập nhật quỹ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại dữ liệu cho DataGridView
                dgvQuy.DataSource = BLL_Quy.Instance.DanhSachQuy();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dgvQuy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một quỹ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa quỹ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Lấy QuyID của dòng được chọn
                int quyID = Convert.ToInt32(dgvQuy.SelectedRows[0].Cells["QuyID"].Value);

                // Gọi hàm xóa quỹ từ BLL và kiểm tra kết quả
                bool result = BLL_Quy.Instance.XoaQuy(quyID);

                if (result)
                {
                    MessageBox.Show("Xóa quỹ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại dữ liệu cho DataGridView
                    dgvQuy.DataSource = BLL_Quy.Instance.DanhSachQuy();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuyID.Text) || cbTenQuy.SelectedIndex == -1 || cbLoaiQuy.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtSoDu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra chuyển đổi dữ liệu đầu vào thành số nguyên và số thực
            int quyID;
            if (!int.TryParse(txtQuyID.Text, out quyID))
            {
                MessageBox.Show("QuyID phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float soDu;
            if (!float.TryParse(txtSoDu.Text, out soDu))
            {
                MessageBox.Show("SoDu phải là số thực.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm thêm quỹ từ BLL và kiểm tra kết quả
            bool result = BLL_Quy.Instance.ThemQuy(quyID, cbTenQuy.Text, cbLoaiQuy.Text, soDu);

            if (result)
            {
                MessageBox.Show("Thêm quỹ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại dữ liệu cho DataGridView
                dgvQuy.DataSource = BLL_Quy.Instance.DanhSachQuy();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Đặt lại trạng thái của các điều khiển
            txtQuyID.Text = "";
            cbTenQuy.SelectedIndex = -1;
            cbLoaiQuy.SelectedIndex = -1;
            txtSoDu.Text = "";

            txtQuyID.Enabled = false;
            cbTenQuy.Enabled = false;
            cbLoaiQuy.Enabled = false;
            txtSoDu.Enabled = false;
        }
    }
}
