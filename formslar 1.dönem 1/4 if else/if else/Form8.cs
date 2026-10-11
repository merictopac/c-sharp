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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int derece=Convert.ToInt32(textBox1.Text);
            if (derece < 10)
            {
                 this.BackColor = Color.Aqua;
                this.label1.ForeColor = Color.Red;
                MessageBox.Show("hava soğuk");
            }
            else if (derece < 25)
            {
                 this.BackColor = Color.Tomato;
                this.label1.ForeColor= Color.Gold;
                MessageBox.Show("hava hafif sıcak");
            }
            else if (derece >25)
            {
                 this.BackColor = Color.Gold; 
                MessageBox.Show("hava sıcak");
            }

        }
    }
}
