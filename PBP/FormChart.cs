using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;

namespace PBP
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            TampilkanChart();
        }

        private void TampilkanChart()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PBPConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT tahun_terbit, COUNT(*) AS jumlah 
                                     FROM Buku 
                                     GROUP BY tahun_terbit 
                                     ORDER BY tahun_terbit";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    chart1.Series.Clear();
                    chart1.ChartAreas[0].AxisX.Title = "Tahun Terbit";
                    chart1.ChartAreas[0].AxisY.Title = "Jumlah Buku";

                    Series series = new Series("Jumlah Buku");
                    series.ChartType = SeriesChartType.Column;

                    while (reader.Read())
                    {
                        string tahun = reader["tahun_terbit"].ToString();
                        int jumlah = Convert.ToInt32(reader["jumlah"]);

                        series.Points.AddXY(tahun, jumlah);
                    }

                    chart1.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message);
                }
            }
        }
    }
}
