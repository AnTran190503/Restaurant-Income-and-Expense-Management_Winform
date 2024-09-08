using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace DAL
{
    class DAL_PhieuThu
    {
        private static DAL_PhieuThu instance; //ctr + r + e
        public static DAL_PhieuThu Instance
        {
            get { if (instance == null) instance = new DAL_PhieuThu(); return instance; }
            private set => instance = value;
        }
       
        private DAL_PhieuThu() { }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select PhieuThuID,TenQuy,TenNhanVien,SoTien,LyDo,NgayThu " +
         "from PhieuThu PT " +
         "join NhanVien NV on NV.NhanVienID = PT.NhanVienID " + 
         "join Quy Q on Q.QuyID = PT.QuyID");
        }
        public bool Them(int phieuid, int quyid, int nguoiid, float sotien, string lydo, string ngay)
        {

            string sql = "insert into PhieuThu values (" + phieuid + ", " + quyid + ", " + nguoiid + "," + sotien + ",N'" + lydo + "','" + ngay + "')";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { phieuid, quyid, nguoiid, sotien, lydo, ngay });
        }
        public bool Sua(int phieuid, int quyid, int nguoiid, float sotien, string lydo, string ngay)
        {

            string sql = "update PhieuThu set QuyID = " + quyid + " ,NhanVienID = " + nguoiid + ",SoTien =" + sotien + " ,LyDo = N'" + lydo + "',NgayThu = '" + ngay + "' where PhieuChiID = " + phieuid + "";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { phieuid, quyid, nguoiid, sotien, lydo, ngay });
        }
    }
}
