// DAL_Quy
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Quy
    {
        private static DAL_Quy instance;

        public static DAL_Quy Instance
        {
            get { if (instance == null) instance = new DAL_Quy(); return instance; }
            private set => instance = value;
        }
        
        private DAL_Quy() { }

        public DataTable DanhSachQuy()
        {
            string query = "SELECT * FROM Quy";
            return KetNoi.Instance.ExecuteQuery(query);
        }

        public bool ThemQuy(int quyID, string tenQuy, string loaiQuy, float soDu)
        {
            string query = $"INSERT INTO Quy (QuyID, TenQuy, LoaiQuy, SoDu) VALUES ({quyID}, N'{tenQuy}', N'{loaiQuy}', {soDu})";
            return KetNoi.Instance.ExecuteNonQuery(query, null);

        }

        public bool SuaQuy(int quyID, string tenQuy, string loaiQuy, float soDu)
        {
            string query = $"UPDATE Quy SET TenQuy = N'{tenQuy}', LoaiQuy = N'{loaiQuy}', SoDu = {soDu} WHERE QuyID = {quyID}";
            return KetNoi.Instance.ExecuteNonQuery(query, null);

        }

        public bool XoaQuy(int quyID)
        {
            string query = $"DELETE FROM Quy WHERE QuyID = {quyID}";
            return KetNoi.Instance.ExecuteNonQuery(query, null);

        }

    }
}
