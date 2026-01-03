using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_while
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int i = 0;
            int toplam = 0;
            while (i < 20)
            {
                listBox1.Items.Add(x.Next(0,100));
                toplam = toplam + Convert.ToInt32(listBox1.Items[i]);
                i++;
            }
            MessageBox.Show(toplam.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
