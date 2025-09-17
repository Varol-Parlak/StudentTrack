using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Drawing;
using Google.Protobuf.WellKnownTypes;

namespace denemeGrafik
{
    public partial class grafikForm : Form
    {
        public grafikForm()
        {
            InitializeComponent();
        }

        ConnectionString conn = new ConnectionString();
        MySqlCommand cmd = new MySqlCommand();

        string graph = @"SELECT soruSayisi, yanlisSayisi 
            FROM library.notlar 
            WHERE ogrenciNo = @ogrenciNo AND ders = 'Matematik'
            LIMIT @son;";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grafikForm_Load(object sender, EventArgs e)
        {
            colGraph.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            colGraph.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
            colGraph.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
            colGraph.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
            colGraph.ChartAreas[0].AxisY.Title = "Yanlış Yüzdesi (%)";
            colGraph.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            colGraph.ChartAreas[0].AxisX.Interval = 1;
            
            lineGraph.ChartAreas[0].AxisX.Interval = 1;
            lineGraph.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            lineGraph.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            lineGraph.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
            lineGraph.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
            lineGraph.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
            lineGraph.ChartAreas[0].AxisY.Title = "Yanlış Yüzdesi (%)";

            cbLast.SelectedIndex = 0;
            cbDers.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try { 

                using (MySqlConnection connection = conn.Baglan())
                using (MySqlCommand cmd = new MySqlCommand(graph, connection))
                {
                    cmd.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt16(txtNo.Text));
                    cmd.Parameters.AddWithValue("@ders", cbDers.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@son", Convert.ToInt16(cbLast.SelectedItem));

                    using (MySqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        if (!reader.HasRows) 
                        {
                            MessageBox.Show("Veri Bulunamadı."); 
                            return; 
                        }

                        colGraph.Series.Clear();
                        var seriesCol = new Series 
                        { 
                            Name = "YanlisYuzdesi", 
                            ChartType = SeriesChartType.Column, 
                            Color= Color.FromArgb(2, 62, 71),
                            IsValueShownAsLabel = true,
                            LabelFormat = "0.0 '%'"
                        };
                        colGraph.Series.Add(seriesCol);

                        lineGraph.Series.Clear();
                        var seriesLine = new Series
                        {
                            Name = "YanlisYuzdesi",
                            ChartType = SeriesChartType.Line,
                            Color = Color.FromArgb(2, 62, 71),
                            IsValueShownAsLabel = true,
                            LabelFormat = "0.00 '%'"
                        };
                        lineGraph.Series.Add(seriesLine);

                        while (reader.Read()) 
                        {
                            int soruSayisi = reader.GetInt32("soruSayisi");
                            int yanlisSayisi = reader.GetInt32("yanlisSayisi");
                            double yanlisYuzdesi = (soruSayisi > 0) ? ((double)yanlisSayisi / soruSayisi) * 100 : 0;
                            double yuzde = Math.Round(yanlisYuzdesi, 2);
                            seriesCol.Points.AddXY($"{soruSayisi}", yuzde);
                            seriesLine.Points.AddXY($"{soruSayisi}", yuzde);
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            label5.Visible = false;
            label6.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNo.Text))
            {
                allData all = new allData(Convert.ToInt16(txtNo.Text));
                all.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bir Öğrenci Numarası Yazınız.");
            }
        }
    }
}
