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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace denemeGrafik
{
    public partial class notGiris : Form
    {
        public notGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ConnectionString conn = new ConnectionString();
        MySqlCommand cmd = new MySqlCommand();
        string sorguKaydet = "insert into library.notlar (ders,soruSayisi,yanlisSayisi,ogrenciNo) values(@ders,@soruSayisi,@yanlisSayisi,@ogrenciNo);";
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNo.Text.Length > 0 && txtSoru.Text.Length > 0 && txtYanlis.Text.Length > 0)
            {
                try
                {
                    using (MySqlConnection connection = conn.Baglan())
                    {
                        cmd = new MySqlCommand(sorguKaydet, connection);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ders", cbDers.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@soruSayisi", Convert.ToInt32(txtSoru.Text));
                        cmd.Parameters.AddWithValue("@yanlisSayisi", Convert.ToInt32(txtYanlis.Text));
                        cmd.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(txtNo.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("İşlem Başarıyla Gerçekleştirildi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Oluştu." + ex.Message);
                }
            }
        }

        private void notGiris_Load(object sender, EventArgs e)
        {
            cbDers.SelectedIndex = 0; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
