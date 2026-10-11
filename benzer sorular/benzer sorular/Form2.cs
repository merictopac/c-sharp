using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benzer_sorular
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2=Convert.ToInt32(textBox2.Text);
            int sayi3=Convert.ToInt32(textBox3.Text);
            int toplam = sayi1 + sayi2+sayi3;
            int ortalama = toplam/3;
            textBox4.Text = toplam.ToString();
            textBox5.Text=ortalama.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
                    temizleme butonu 
             */
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
    }
}
