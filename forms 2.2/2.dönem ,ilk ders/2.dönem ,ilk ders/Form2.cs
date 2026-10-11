using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.dönem__ilk_ders
{
    class Ogrenciler
    {
        public int Numara { get; set; }
        public string AdSoyad { get; set; }
        public string Alan { get; set; }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = 1111;
            ogrenci.AdSoyad = "Mehmet";
            ogrenci.Alan = "Bilişim Teknolojileri";
            textBox1.DataBindings.Add("Text", ogrenci, "Numara");
            textBox2.DataBindings.Add("Text", ogrenci, "AdSoyad");
            textBox3.DataBindings.Add("Text", ogrenci, "Alan");
        }
    }
}
