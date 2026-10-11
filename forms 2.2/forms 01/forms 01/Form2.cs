using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forms_01
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        class Kitaplar
        {
            public string KitapAdi { get; set; }
            public string KitapYazari { get; set; }
            public string KitapTuru { get; set; }
        }
        ArrayList kaynakVeri = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar  kitap = new Kitaplar();
            kitap.KitapAdi = textBox1.Text;
            kitap.KitapYazari = textBox2.Text;
            kitap.KitapTuru = textBox3.Text;
            kaynakVeri.Add(kitap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = kaynakVeri;
            listBox1.DisplayMember = "KitapAdi";

            listBox2.DataSource = null;
            listBox2.DataSource = kaynakVeri;
            listBox2.DisplayMember = "KitapYazari";

            listBox3.DataSource = null;
            listBox3.DataSource = kaynakVeri;
            listBox3.DisplayMember = "KitapTuru";
        }
    }
}
