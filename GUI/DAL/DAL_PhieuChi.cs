using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    class DAL_PhieuChi
    {
        private static DAL_PhieuChi instance; //ctr + r + e
        public static DAL_PhieuChi Instance
        {
            get { if (instance == null) instance = new DAL_PhieuChi(); return instance; }
            private set => instance = value;
        }
        private DAL_PhieuChi() { }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select PhieuChiID,TenQuy,TenNhanVien,SoTien,LyDo,NgayChi " +
                "from PhieuChi PC " +
                "join NhanVien NV on NV.NhanVienID = PC.NhanVienID " +
                "join Quy Q on Q.QuyID = PC.QuyID");
        }
        public bool Them(int phieuid, int quyid, int nguoiid, float sotien,string lydo,string ngay)
        {

            string sql = "insert into PhieuChi values (" + phieuid + ", " + quyid + ", " + nguoiid + "," + sotien + ",N'"+lydo+"','"+ngay+"')";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { phieuid, quyid, nguoiid,sotien,lydo,ngay });
        }
        public bool Sua(int phieuid, int quyid, int nguoiid, float sotien, string lydo, string ngay)
        {

            string sql = "update PhieuChi set QuyID = "+quyid+" ,NguoiSuDungID = "+nguoiid+",SoTien ="+sotien+" ,LyDo = N'"+lydo+"',NgayChi = '"+ngay+"' where PhieuChiID = "+phieuid+"";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { phieuid, quyid, nguoiid, sotien, lydo, ngay });
        }
    }
}
