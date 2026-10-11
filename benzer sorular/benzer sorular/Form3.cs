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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int i = 1; i <11; i++)
            { 
                for (int j = 1; j < 11; j++)
                {
                    listBox1.Items.Add(i + "*" + j + "=" + (i * j));
                    
                }
                listBox1.Items.Add("=========================");
            }
            
        }
    }
}
