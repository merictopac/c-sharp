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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            int yaricap = Convert.ToInt32(textBox1.Text);
            double pisayisi = 3.14, alan = pisayisi * yaricap * yaricap, cevre = 2 * pisayisi * yaricap;
            MessageBox.Show(" alan " + alan+" çevre "+ cevre.ToString());
        }
    }
}
