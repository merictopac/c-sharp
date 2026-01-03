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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkcedogru = Convert.ToDouble(textBox1.Text);
            double turkceyanlıs = Convert.ToDouble(textBox2.Text);
            double matdogru = Convert.ToDouble(textBox4.Text);
            double matyanlıs = Convert.ToDouble(textBox5.Text);
            double matnet = (matdogru-(matyanlıs / 4));
            double turkcenet= (turkcedogru-(turkceyanlıs/4));
            textBox3.Text=turkcenet.ToString();
            textBox6.Text = matnet.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
