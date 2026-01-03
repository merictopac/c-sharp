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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            if (sayi < 0)
            {
                MessageBox.Show("sayi negatif");
            }
            else if (sayi == 0)
            {
                MessageBox.Show("sayi 0 ");
            }
            else
            {
                MessageBox.Show("sayi pozitif");
            }
        }
    }
}
