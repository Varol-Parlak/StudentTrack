using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeGrafik
{
    public partial class dersProgram : Form
    {
        public dersProgram()
        {
            InitializeComponent();
        }
        ConnectionString conn = new ConnectionString();
        MySqlCommand cmd = new MySqlCommand();
        string insert = "INSERT INTO library.ders_program (ogrenciNo,gun,gorev) VALUES (@ogrenciNo,@gun,@gorev)";
        string delete = "DELETE FROM library.ders_program WHERE ogrenciNo = @ogrenciNo";
        string noExists = "SELECT COUNT(*) FROM library.ders_program WHERE ogrenciNo = @ogrenciNo";
        string filldgv = "select * from library.ders_program where ogrenciNo = @ogrenciNo";
        bool noVarMi;

        public void dgvFill()
        {
            try
            {
                using (MySqlConnection connection2 = conn.Baglan())
                {
                    MySqlCommand command2 = new MySqlCommand(filldgv, connection2);
                    command2.Parameters.Clear();
                    command2.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(textBox1.Text));
                    command2.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command2);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvClear();

                    foreach (DataRow dr in dt.Rows) 
                    {  
                        string gun1 = dr["gun"].ToString();
                        string gorev1 = dr["gorev"].ToString();

                        int columnIndex = -1;
                        
                        foreach (DataGridViewColumn col in dersProgrami.Columns)
                        {
                            if(col.HeaderText == gun1)
                            {
                                columnIndex = col.Index;
                                break;
                            }
                        }
                        if (columnIndex != -1)
                        {
                            for (int i = 0; i < dersProgrami.Rows.Count; i++)
                            {
                                if (dersProgrami.Rows[i].Cells[columnIndex].Value == null)
                                {
                                    dersProgrami.Rows[i].Cells[columnIndex].Value = gorev1;
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            catch(Exception ex2) 
            {
                MessageBox.Show("Verileri Yüklerken Bir Hata Oluştu. "+ ex2.Message);
            }
        }
        public void dgvClear()
        {
            foreach (DataGridViewRow row in dersProgrami.Rows)
            {
                if (!row.IsNewRow)  
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Value = null;  
                    }
                }
            }
        }
        public void deleteData()
        {
            try
            {
                using (MySqlConnection connection1 = conn.Baglan())
                {
                    cmd = new MySqlCommand(delete, connection1);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(textBox1.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }
        public void insertData()
        {
            try
            {
                using (MySqlConnection connection = conn.Baglan())
                {
                    
                    foreach (DataGridViewRow row in dersProgrami.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            {
                                cmd = new MySqlCommand(insert, connection);
                                string gun = dersProgrami.Columns[cell.ColumnIndex].HeaderText;
                                string gorev = cell.Value.ToString();
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(textBox1.Text));
                                cmd.Parameters.AddWithValue("@gun", gun);
                                cmd.Parameters.AddWithValue("@gorev", gorev);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Başarıyla Gerçekleştirildi.");
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Bir Hata Oluştu"+ ex1.Message);
            }
            
        }
        private void dersProgrami_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void btnProg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (noVarMi == false)
                {
                    insertData();
                }
                else if (noVarMi == true)
                {
                    deleteData();
                    insertData();
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Öğrenci Numarası Giriniz.");
            }
            dgvClear();
        }
        
        private void dersProgram_Load(object sender, EventArgs e)
        {
            dersProgrami.ColumnCount = 7;
            dersProgrami.RowCount = 15;

            dersProgrami.GridColor = Color.FromArgb(2, 62, 71);
            dersProgrami.Columns[0].HeaderText = "Pazartesi";
            dersProgrami.Columns[1].HeaderText = "Salı";
            dersProgrami.Columns[2].HeaderText = "Çarşamba";
            dersProgrami.Columns[3].HeaderText = "Perşembe";
            dersProgrami.Columns[4].HeaderText = "Cuma";
            dersProgrami.Columns[5].HeaderText = "Cumartesi";
            dersProgrami.Columns[6].HeaderText = "Pazar";

            foreach (DataGridViewColumn column in dersProgrami.Columns)
            {
                column.DividerWidth = 2;
                column.ReadOnly = false;
            }
            foreach (DataGridViewRow row in dersProgrami.Rows)
            {
                row.DividerHeight = 2;
            }

            dersProgrami.RowTemplate.Height = 40;
            dersProgrami.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dersProgrami.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dersProgrami.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dersProgrami.RowHeadersVisible = false;
            dersProgrami.AllowUserToResizeColumns = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                try
                {
                    using (cmd = new MySqlCommand(noExists, conn.Baglan()))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(textBox1.Text));
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        noVarMi = count > 0;
                    }
                    dgvClear();
                }
                catch 
                {
                     MessageBox.Show("Bir Sayı Giriniz");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printDialog.Document = printDocument;
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dersProgrami.Width, dersProgrami.Height);
            dersProgrami.DrawToBitmap(bitmap, new Rectangle(0, 0, dersProgrami.Width, dersProgrami.Height));

            e.Graphics.DrawImage(bitmap, 50, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteData();
            dgvClear();
            MessageBox.Show("Başarıyla Gerçekleşti !");
        }

        private void dersProgrami_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
