using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav_meriç_topaç_10atp_968
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 1; i < 20; i++)
            {
                listBox1.Items.Add(rnd.Next(0, 100));
                
            }
            
            
        }
    }
}
