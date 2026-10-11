using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text= toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cikar;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            cikar = sayi1 - sayi2;
            textBox3.Text = cikar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carp;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            carp = sayi1 * sayi2;
            textBox3.Text = carp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, bol;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            bol = sayi1 / sayi2;
            textBox3.Text = bol.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, mod;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            mod = sayi1 % sayi2;
            textBox3.Text = mod.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
