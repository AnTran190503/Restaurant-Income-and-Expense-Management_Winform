using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class BLL_PhieuChi
    {
        private static BLL_PhieuChi instance; //ctr + r + e
        public static BLL_PhieuChi Instance
        {
            get { if (instance == null) instance = new BLL_PhieuChi(); return instance; }
            private set => instance = value;
        }
        private BLL_PhieuChi() { }

        public DataTable DanhSach()
        {
            return DAL_PhieuChi.Instance.DanhSach();
        }
        public bool Them(int phieuid, int quyid, int nguoiid, float sotien, string lydo, string ngay)
        {
            return DAL_PhieuChi.Instance.Them(phieuid, quyid, nguoiid, sotien, lydo, ngay);
        }
        public bool Sua(int phieuid, int quyid, int nguoiid, float sotien, string lydo,string ngay)
        {
            return DAL_PhieuChi.Instance.Sua(phieuid, quyid, nguoiid, sotien, lydo, ngay);
        }

        public static implicit operator BLL_PhieuChi(BLL_PhieuThu v)
        {
            throw new NotImplementedException();
        }
    }
}
