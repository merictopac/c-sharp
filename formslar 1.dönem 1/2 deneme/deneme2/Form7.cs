using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "merhaba dünya";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
