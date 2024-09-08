
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    class BLL_PhieuThu
    {
        private static BLL_PhieuThu instance;
        public static BLL_PhieuThu Instance
        {
            get { if (instance == null) instance = new BLL_PhieuThu(); return instance; }
            private set => instance = value;
        }
        private BLL_PhieuThu() { }

        public DataTable DanhSach()
        {
            return DAL_PhieuThu.Instance.DanhSach();
        }

        public bool Them(int phieuid, int quyid, int nguoiid, float sotien, string lydo, string ngay)
        {
            return DAL_PhieuThu.Instance.Them(phieuid, quyid, nguoiid, sotien, lydo, ngay);
        }

        public bool Sua(int phieuid, int quyid, int nguoiid, float sotien, string lydo, string ngay)
        {
            return DAL_PhieuThu.Instance.Sua(phieuid, quyid, nguoiid, sotien, lydo, ngay);

        }
    }
}
