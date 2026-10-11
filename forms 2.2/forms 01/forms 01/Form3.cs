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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        class Sehirler
        {
            public string Plaka { get; set; }
            public string SehirAdi { get; set; }
        }
        List<Sehirler> listSehirler = new List<Sehirler>();
        private void Bagla()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = listSehirler;
            comboBox1.DisplayMember = "SehirAdi";
            comboBox1.ValueMember = "Plaka";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.Plaka = textBox1.Text;
            sehir.SehirAdi = textBox2.Text;
            listSehirler.Add(sehir);
            Bagla();

        }
    }
}
