using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace denemeGrafik
{
    public partial class notKayit : Form
    {
        public notKayit()
        {
            InitializeComponent();
        }
        ConnectionString conn = new ConnectionString();
        MySqlCommand cmd = new MySqlCommand();
        string ogrSil = "delete from library.ogrenciler where ogrenciNo=@ogrenciNo";
        string ogrSil2 = "delete from library.ders_program where ogrenciNo=@ogrenciNo";
        string notSil = "delete from library.notlar where ogrenciNo=@ogrenciNo";
        string ogrEkle = "INSERT INTO library.ogrenciler(ogrenciNo, ogrenciAd) VALUES(@ogrenciNo, @ogrenciAd)";
        public void ogrenci_islem(string sorgu)
        {
            try
            {
                using (MySqlConnection connection2 = conn.Baglan())
                {
                    cmd = new MySqlCommand(sorgu, connection2);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ogrenciNo", studentId.Text);
                    cmd.Parameters.AddWithValue("@ogrenciAd", adSoyad.Text);
                    cmd.ExecuteNonQuery();

                    studentId.Clear();
                    adSoyad.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik Bir Hata Oluştu! " + ex.Message);
            }
            MessageBox.Show("İşlem Başarıyla Gerçekleştirildi");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notGir_Click(object sender, EventArgs e)
        {
            ogrenci_islem(ogrEkle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void notKayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = conn.Baglan())
                {
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        MySqlCommand cmd1 = new MySqlCommand(ogrSil2, connection, transaction);
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@ogrenciNo", studentId.Text);
                        cmd1.ExecuteNonQuery();

                        MySqlCommand cmd2 = new MySqlCommand(ogrSil, connection, transaction);
                        cmd2.Parameters.Clear();
                        cmd2.Parameters.AddWithValue("@ogrenciNo", studentId.Text);
                        cmd2.ExecuteNonQuery();

                        MySqlCommand cmd3 = new MySqlCommand(notSil, connection, transaction);
                        cmd3.Parameters.Clear();
                        cmd3.Parameters.AddWithValue("@ogrenciNo", studentId.Text);
                        cmd3.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Öğrenci başarıyla silindi!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }

                studentId.Clear();
                adSoyad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }
    }
}
