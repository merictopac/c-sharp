using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meriç_topaç_10_atp_968
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text);
            int b=Convert.ToInt32(textBox2.Text);
            int alan = a * b;
            MessageBox.Show(alan.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yari=Convert.ToInt32(textBox3.Text);
            double alan = 3.14 * yari * yari;
            MessageBox.Show(alan.ToString());
        }
    }
}
