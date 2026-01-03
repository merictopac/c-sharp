using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memocansınavhazırlık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* listBox1.Items.Clear();
             int sayı1 = Convert.ToInt32(textBox1.Text);
             int sayı2 = Convert.ToInt32(textBox2.Text);
             Random rnd = new Random ();
             for ( int i = 1; i <= 30; i++) 
             {
                 listBox1.Items.Add(rnd.Next(sayı1,sayı2));
             }*/
            int S1,S2;
            S1=Convert.ToInt32(textBox1.Text);
            S2 = Convert.ToInt32(textBox2.Text);
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                listBox1.Items.Add(rnd.Next(S1,S2));
            }

        }
    }
}
