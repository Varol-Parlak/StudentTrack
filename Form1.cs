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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Notgir_Click(object sender, EventArgs e)
        {
            notKayit notKayit = new notKayit();
            notKayit.ShowDialog();
        }

        private void Sorgu_Click(object sender, EventArgs e)
        {
            grafikForm graphForm = new grafikForm();   
            graphForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dersProgram dersProgram = new dersProgram();   
            dersProgram.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notGiris notGiris = new notGiris();
            notGiris.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
