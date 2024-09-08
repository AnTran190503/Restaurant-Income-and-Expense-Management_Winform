// BLL/BLL_NhanVien.cs
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class BLL_NhanVien
    {
        private static BLL_NhanVien instance;

        public static BLL_NhanVien Instance
        {
            get { if (instance == null) instance = new BLL_NhanVien(); return instance; }
            private set => instance = value;
        }

        private BLL_NhanVien() { }

        public List<int> LayDanhSachQuyen()
        {
            return DAL_NhanVien.Instance.LayDanhSachQuyen();
        }
        public DataTable KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string query = "SELECT * FROM NhanVien WHERE TenNhanVien = @tenDangNhap AND MatKhau = @matKhau";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenDangNhap", SqlDbType.NVarChar) { Value = tenDangNhap },
                new SqlParameter("@matKhau", SqlDbType.NVarChar) { Value = matKhau }
            };

            return KetNoi.Instance.ExecuteQuery(query, parameters);
        }



        public int LayVaiTroNhanVien(int nhanVienId)
        {
            return DAL_NhanVien.Instance.LayVaiTroNhanVien(nhanVienId);
        }

        public DataTable LayDanhSachNhanVien()
        {
            return DAL_NhanVien.Instance.LayDanhSachNhanVien();
        }
      
        public bool ThemNhanVien(int nhanVienID, string tenNhanVien, string matKhau, int quyenID)
        {
            return DAL_NhanVien.Instance.ThemNhanVien(nhanVienID, tenNhanVien, matKhau, quyenID);
        }

        public bool CapNhatNhanVien(int oldNhanVienID, int newNhanVienID, string tenNhanVien, string matKhau, int quyenID)
        {
            return DAL_NhanVien.Instance.CapNhatNhanVien(oldNhanVienID, newNhanVienID, tenNhanVien, matKhau, quyenID);
        }

        public bool SuaNhanVien(int nhanVienID, string tenNhanVien, string matKhau)
        {
            return DAL_NhanVien.Instance.SuaNhanVien(nhanVienID, tenNhanVien, matKhau);
        }

        public bool XoaNhanVien(int nhanVienID)
        {
            return DAL_NhanVien.Instance.XoaNhanVien(nhanVienID);
        }
    }
}
