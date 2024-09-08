// DAL_NhanVien.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien instance;

        public static DAL_NhanVien Instance
        {
            get { if (instance == null) instance = new DAL_NhanVien(); return instance; }
            private set => instance = value;
        }

        private DAL_NhanVien() { }

        public DataTable KiemTraDangNhap(string username, string password)
        {
            string hashedPassword = HashMatKhau(password);
            string query = $"SELECT * FROM NhanVien WHERE TenNhanVien = '{username}' AND MatKhau = '{hashedPassword}'";
            return KetNoi.Instance.ExecuteQuery(query);
        }

        private string HashMatKhau(string matKhau)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(matKhau));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public int LayVaiTroNhanVien(int nhanVienId)
        {
            string query = $"SELECT RoleId FROM UserRoles WHERE UserId = {nhanVienId}";
            DataTable result = KetNoi.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["RoleId"]);
            }

            return -1;
        }

        public DataTable LayDanhSachNhanVien()
        {
            string query = "SELECT N.*, U.RoleId " +
                  "FROM NhanVien N " +
                  "JOIN UserRoles U ON N.NhanVienID = U.UserId";
            return KetNoi.Instance.ExecuteQuery(query);
        }

        public bool ThemNhanVien(int nhanVienID, string tenNhanVien, string matKhau, int quyenID)
        {
            string hashedMatKhau = HashMatKhau(matKhau);
            string query = $"INSERT INTO NhanVien (NhanVienID, TenNhanVien, MatKhau) VALUES ({nhanVienID}, '{tenNhanVien}', '{hashedMatKhau}')";

            bool result = KetNoi.Instance.ExecuteNonQuery(query, null);

            if (result)
            {
                result = ThemQuyenChoNhanVien(nhanVienID, quyenID);
            }

            return result;
        }

        public bool CapNhatNhanVien(int oldNhanVienID, int newNhanVienID, string tenNhanVien, string matKhau, int quyenID)
        {
            try
            {
                string hashedMatKhau = HashMatKhau(matKhau);

                string query = $"UPDATE NhanVien SET NhanVienID = {newNhanVienID}, TenNhanVien = '{tenNhanVien}', MatKhau = '{hashedMatKhau}' WHERE NhanVienID = {oldNhanVienID}";

                bool rowsAffected = KetNoi.Instance.ExecuteNonQuery(query, null);

                if (rowsAffected)
                {
                    if (CapNhatQuyenNhanVien(newNhanVienID, quyenID))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool CapNhatQuyenNhanVien(int nhanVienID, int quyenID)
        {
            try
            {
                string query = $"UPDATE UserRoles SET RoleId = {quyenID} WHERE UserId = {nhanVienID}";

                bool rowsAffected =   KetNoi.Instance.ExecuteNonQuery(query, null);

                return rowsAffected;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaNhanVien(int nhanVienID, string tenNhanVien, string matKhau)
        {
            string hashedMatKhau = HashMatKhau(matKhau);
            string query = $"UPDATE NhanVien SET TenNhanVien = '{tenNhanVien}', MatKhau = '{hashedMatKhau}' WHERE NhanVienID = {nhanVienID}";

            return KetNoi.Instance.ExecuteNonQuery(query, null);
        }

        public bool XoaNhanVien(int nhanVienID)
        {
            // Trước tiên, xóa các bản ghi trong bảng UserRoles liên quan đến nhân viên
            string deleteRolesQuery = $"DELETE FROM UserRoles WHERE UserId = {nhanVienID}";

            bool deleteRolesResult = KetNoi.Instance.ExecuteNonQuery(deleteRolesQuery,null);

            if (!deleteRolesResult)
            {
                return false;
            }

            // Sau đó, xóa nhân viên từ bảng NhanVien
            string deleteNhanVienQuery = $"DELETE FROM NhanVien WHERE NhanVienID = {nhanVienID}";

            return KetNoi.Instance.ExecuteNonQuery(deleteNhanVienQuery,null);
        }

        public bool ThemQuyenChoNhanVien(int nhanVienID, int quyenID)
        {
            string query = $"INSERT INTO UserRoles (UserId, RoleId) VALUES ({nhanVienID}, {quyenID})";
            return KetNoi.Instance.ExecuteNonQuery(query,null);
        }

        public List<int> LayDanhSachQuyen()
        {
            string query = "SELECT DISTINCT RoleId FROM UserRoles";
            DataTable result = KetNoi.Instance.ExecuteQuery(query);

            List<int> danhSachQuyen = new List<int>();
            foreach (DataRow row in result.Rows)
            {
                danhSachQuyen.Add(Convert.ToInt32(row["RoleId"]));
            }

            return danhSachQuyen;
        }
    }
}
