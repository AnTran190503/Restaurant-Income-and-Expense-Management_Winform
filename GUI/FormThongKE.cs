using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormThongKE : Form
    {
        string strcon = "Data Source=LAPTOP-0GJ5N2UI\\SQLEXPRESS;Initial Catalog=QL_ThuChiQuanAn;Integrated Security=True";
        public FormThongKE()
        {
            InitializeComponent();
        }
        private void loadcomboboxQuy()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strcon);
                connection.Open();
                string query = "select TenQuy,QuyID from Quy";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(read);
                cbQuy.DataSource = tb;
                cbQuy.DisplayMember = "TenQuy";
                cbQuy.ValueMember = "QuyID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DisplayDataOnChartNgay()
        {
            // Lấy dữ liệu từ DataGridView
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in dgvThongKe.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            // Thiết lập nguồn dữ liệu cho Chart
            chart1.DataSource = dataTable;

            // Đặt tên trục X và Y
            chart1.Series[0].XValueMember = "TenQuy";
            chart1.Series[0].YValueMembers = "GiaTri";

            // Hiển thị dạng biểu đồ (Column là biểu đồ cột)
            
        }
        private void DisplayDataOnChartQuy()
        {
            // Lấy dữ liệu từ DataGridView
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in dgvThongKe.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            // Thiết lập nguồn dữ liệu cho Chart
            chart1.DataSource = dataTable;

            // Đặt tên trục X và Y
            chart1.Series[0].XValueMember = "NgayThongKe";
            chart1.Series[0].YValueMembers = "GiaTri";

            // Hiển thị dạng biểu đồ (Column là biểu đồ cột)

        }
        private void FormThongKE_Load(object sender, EventArgs e)
        {
            loadcomboboxQuy();
        }
        private void SearchDataGridViewNgay(string searchValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    connection.Open();

                    string query = "SELECT TenQuy,NgayThongKe,GiaTri from ThongKe TK" +
                        " join Quy Q on Q.QuyID = TK.QuyID" +
                        " Where NgayThongKe =  @SearchValue ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvThongKe.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SearchDataGridViewQuy(string searchValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strcon))
                {
                    connection.Open();

                    string query = "SELECT TenQuy,NgayThongKe,GiaTri from ThongKe TK" +
                        " join Quy Q on Q.QuyID = TK.QuyID" +
                        " Where TenQuy =  @SearchValue ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvThongKe.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            try
            {
                string loaithongke = cbLoaiThongKe.Text;
                string Quy = cbQuy.Text;
                DateTime ngay = dtPNgayChi.Value; // Sử dụng Value thay vì Text để lấy giá trị DateTimePicker

                if (cbLoaiThongKe.Text == "Tròn")
                {
                    if (dtPNgayChi.Enabled == false && cbQuy.Enabled == false)
                    {
                        MessageBox.Show("Vui lòng chọn các dữ liệu cần thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dtPNgayChi.Enabled == false)
                    {
                        SearchDataGridViewQuy(Quy);
                        DisplayDataOnChartQuy();
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        chart1.DataBind();
                    }
                    else if (cbQuy.Enabled == false)
                    {
                        SearchDataGridViewNgay(ngay.ToString("yyyy/MM/dd"));
                        DisplayDataOnChartNgay();
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        chart1.DataBind();
                    }
                }
                else if (cbLoaiThongKe.Text == "Cột")
                {
                    if (dtPNgayChi.Enabled == false && cbQuy.Enabled == false)
                    {
                        MessageBox.Show("Vui lòng chọn các dữ liệu cần thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dtPNgayChi.Enabled == false)
                    {
                        SearchDataGridViewQuy(Quy);
                        DisplayDataOnChartQuy();
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.DataBind();
                    }
                    else if (cbQuy.Enabled == false)
                    {
                        SearchDataGridViewNgay(ngay.ToString("yyyy/MM/dd"));
                        DisplayDataOnChartNgay();
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.DataBind();
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu Loại Thống Kê không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbQuy.Enabled = false;
            dtPNgayChi.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbQuy.Enabled = true;
            dtPNgayChi.Enabled = false;
        }
    }
}
