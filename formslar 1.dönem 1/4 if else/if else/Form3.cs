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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 1) 
                {
                MessageBox.Show("bu sayı tek sayıdır");
                }
            if (sayi % 2 == 0)
            {
                MessageBox.Show("bu sayı çift sayıdır");
            }
            
                
        }
    }
}
