using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantıksal_operatörler
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2=Convert.ToInt32(textBox2.Text);
            int sayi3=Convert.ToInt32(textBox3.Text);
            if (sayi1 > sayi2 && sayi1 > sayi3 && sayi2<sayi3) 
            {
                MessageBox.Show("sayi "+sayi1+" büyük ve "+sayi2+"küçük");
            }
            if (sayi2 > sayi1 && sayi2 > sayi3 && sayi1<sayi3) 
            {
                MessageBox.Show("sayi "+sayi2+" büyük sayi "+sayi1 +" küçük");
            }
            if (sayi3 > sayi2 && sayi3 > sayi1) 
            {
                MessageBox.Show("sayi "+sayi3+" büyük");
            }

            if (sayi1 <sayi2 && sayi1<sayi3)
            {
                MessageBox.Show("sayi " + sayi1 + " küçük");
            }
            if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                MessageBox.Show("sayi " + sayi2 + " küçük");
            }
            if (sayi3 < sayi2 && sayi3 < sayi1)
            {
                MessageBox.Show("sayi " + sayi3 + " küçük");
            }
        }
    }
}
