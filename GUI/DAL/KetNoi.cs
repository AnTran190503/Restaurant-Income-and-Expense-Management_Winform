using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KetNoi
    {
        private string connectionString = "Data Source=LAPTOP-0GJ5N2UI\\SQLEXPRESS;Initial Catalog=QL_ThuChiQuanAn;Integrated Security=True";
        private static KetNoi instance;

        public static KetNoi Instance
        {
            get { return instance ?? (instance = new KetNoi()); }
            private set => instance = value;
        }

        private KetNoi() { }

        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }

       

        public bool ExecuteNonQuery(string query, object[] parameters1, params SqlParameter[] parameters)
        {
            int affectedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    affectedRows = command.ExecuteNonQuery();
                }
            }

            return affectedRows > 0;
        }

    }
}
