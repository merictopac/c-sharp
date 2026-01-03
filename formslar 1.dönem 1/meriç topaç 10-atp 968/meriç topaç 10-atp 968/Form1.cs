using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meriç_topaç_10_atp_968
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilk=Convert.ToInt32(textBox1.Text);
            int son=Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < 31; i++) 
            { 
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int not1=Convert.ToInt32(textBox7.Text);
            int not2=Convert.ToInt32(textBox8.Text);
            int not3=Convert.ToInt32(textBox9.Text);
            int ortalama = (not1+not2 +not3)/3;
            textBox12.Text = ortalama.ToString();
            if (ortalama  < 45 && ortalama>25) 
            {
                textBox11.Text = "1";textBox10.Text = "kaldı";
            }
            else if (ortalama < 55 && ortalama > 45)
            {
                textBox11.Text = "2"; textBox10.Text = "geçti";
            }
            else if (ortalama < 55 && ortalama > 70)
            {
                textBox11.Text = "3"; textBox10.Text = "geçti";
            }
            else if (ortalama < 70 && ortalama > 84)
            {
                textBox11.Text = "4"; textBox10.Text = "geçti";
            }
            else if (ortalama < 85 && ortalama > 101)
            {
                textBox11.Text = "5"; textBox10.Text = "geçti";
            }
            else
            {
                textBox11.Text = "0"; textBox10.Text = "kaldı";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(textBox5.Text);
            if (a == 90 || b == 90 || c == 90)
            {
                textBox6.Text = "dik kenar";
            }
            else if (a > 90 || b > 90 || c > 90)
            {
                textBox6.Text = "geniş kenar";
            }
            else 
            {
                textBox6.Text = "dar kenar";
            }

        }
    }
}
