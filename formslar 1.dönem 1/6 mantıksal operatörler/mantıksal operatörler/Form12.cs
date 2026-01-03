using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantıksal_operatörler
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i =0;i<listBox1.Items.Count;i++)
            {
                if(listBox1.Items[i].ToString()=="hoparlör"|| listBox1.Items[i].ToString() == "mikrafon"|| listBox1.Items[i].ToString() == "monitör")
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }

            }
        }
    }
}
