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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger1=Convert.ToInt32(textBox1.Text);
            int deger2=Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked==true)
            {
               label2.Text=(deger1+deger2).ToString();
            }
            else
            {
                label2.Text = (deger1 * deger2).ToString();
            }


        }
    }
}
