using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgele_sayi_ornegi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button_baslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = rnd.Next(100);
            if (sayi % 2 == 0) listBox_cift.Items.Add(sayi);
            else listBox_tek.Items.Add(sayi);
        }

        int ort = 0;
        int elemanSayisi = 0;
        private void button_cift_sayilarin_ortalamasi_Click(object sender, EventArgs e)
        {
            foreach (int item in listBox_cift.Items)
            {
                ort = ort + item;
                elemanSayisi++;
            }
            if (elemanSayisi > 0)
            {
                labelControl3.Text = (ort / elemanSayisi).ToString();
            }
            elemanSayisi = 0;
            ort = 0;
        }

        private void button_tek_sayilarin_ortalamasi_Click(object sender, EventArgs e)
        {
            foreach (int item in listBox_tek.Items)
            { 
                ort = ort + item;
                elemanSayisi++;
            }
            if (elemanSayisi > 0)
            {
                labelControl4.Text = (ort / elemanSayisi).ToString();
            }
            elemanSayisi = 0;
            ort = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
