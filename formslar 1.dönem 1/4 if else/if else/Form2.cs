using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else
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
            int sayi2 = Convert.ToInt32(textBox2.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show(sayi1 + " sayısı " + sayi2 + " sayısındından büyüktür");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show(sayi1 + " sayısı " + sayi2 + " sayısındından küçüktür");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show(sayi1 + " sayısı " + sayi2 + " sayısındına eşittir");
            }

        }
    }
}
