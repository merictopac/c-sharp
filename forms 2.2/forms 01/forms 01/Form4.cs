using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        class Ogrenciler
        {
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
            public int DersNotu { get; set; }
        }
        List<Ogrenciler> liste = new List<Ogrenciler>();
        private void Bagla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = liste;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(textBox1.Text);
            ogrenci.AdSoyad = textBox2.Text;
            ogrenci.DersNotu = int.Parse(textBox3.Text);
            liste.Add(ogrenci);
            Bagla();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

    }
}

