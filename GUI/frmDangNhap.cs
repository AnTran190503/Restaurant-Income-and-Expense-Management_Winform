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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

      

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            // Kiểm tra đăng nhập
            DataTable result = BLL_NhanVien.Instance.KiemTraDangNhap(username, password);

            if (result.Rows.Count > 0)
            {
                int nhanVienId = Convert.ToInt32(result.Rows[0]["NhanVienID"]);

                // Lấy vai trò của người dùng
                int roleId = BLL_NhanVien.Instance.LayVaiTroNhanVien(nhanVienId);

                // Hiển thị thông báo thành công và mở form chính
                MessageBox.Show("Đăng nhập thành công!");

                // Mở form chính và truyền vai trò
                frmMain formChinh = new frmMain(roleId);
                formChinh.Show();

                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tên người dùng và mật khẩu.");
            }
        }
    }
    
}
