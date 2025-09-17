using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeGrafik
{
    public partial class allData : Form
    {
        public allData(int ogrenciNo)
        {
            InitializeComponent();
            this.ogrenciNo = ogrenciNo;
        }
        private int ogrenciNo;
        ConnectionString conn = new ConnectionString();
        string sorgu = "SELECT ders, soruSayisi, yanlisSayisi FROM library.notlar where ogrenciNo = @ogrenciNo;";
        DataTable dt;
        private void allData_Load(object sender, EventArgs e)
        {
            try
            {
                using(MySqlCommand cmd = new MySqlCommand(sorgu, conn.Baglan()))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFull.DataSource = dt;

                        dgvFull.RowHeadersVisible = false;  
                        dgvFull.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvFull.EnableHeadersVisualStyles = false;
                        dgvFull.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(2, 62, 71);
                        dgvFull.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 240, 234);
                        dgvFull.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                        dgvFull.DefaultCellStyle.Font = new Font("Arial", 9);
                        dgvFull.Columns[0].HeaderText = "Ders";
                        dgvFull.Columns[1].HeaderText = "Soru Sayısı";
                        dgvFull.Columns[2].HeaderText = "Yanlış Sayısı";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
