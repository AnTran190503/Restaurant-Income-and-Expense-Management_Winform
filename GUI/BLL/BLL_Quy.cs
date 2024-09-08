// BLL_Quy
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class BLL_Quy
    {
        private static BLL_Quy instance;

        public static BLL_Quy Instance
        {
            get { if (instance == null) instance = new BLL_Quy(); return instance; }
            private set => instance = value;
        }

        private BLL_Quy() { }

        public DataTable DanhSachQuy()
        {
            return DAL_Quy.Instance.DanhSachQuy();
        }

        // Trong BLL_Quy
        public bool ThemQuy(int quyID, string tenQuy, string loaiQuy, float soDu)
        {
            return DAL_Quy.Instance.ThemQuy(quyID, tenQuy, loaiQuy, soDu);
        }


        public bool SuaQuy(int quyID, string tenQuy, string loaiQuy, float soDu)
        {
            return DAL_Quy.Instance.SuaQuy(quyID, tenQuy, loaiQuy, soDu);
        }

        public bool CapNhatQuy(int quyID, string tenQuy, string loaiQuy, float soDu)
        {
            return DAL_Quy.Instance.SuaQuy(quyID, tenQuy, loaiQuy, soDu);
        }

        public bool XoaQuy(int quyID)
        {
            return DAL_Quy.Instance.XoaQuy(quyID);
        }

        public void LoadComboBoxQuy(ComboBox comboBox)
        {
            DataTable data = DAL_Quy.Instance.DanhSachQuy();
            comboBox.DataSource = data;
            comboBox.DisplayMember = "TenQuy";
            comboBox.ValueMember = "QuyID";
        }

        // Phương thức để load dữ liệu Loại Quỹ vào ComboBox
        public void LoadComboBoxLoaiQuy(ComboBox comboBox)
        {
            DataTable data = DAL_Quy.Instance.DanhSachQuy();
            comboBox.DataSource = data;
            comboBox.DisplayMember = "LoaiQuy";
            comboBox.ValueMember = "QuyID";
        }
    }
}

