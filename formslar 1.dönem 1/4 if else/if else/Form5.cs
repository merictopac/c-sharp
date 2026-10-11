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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(checkBox1.Checked==true)
            {
                listBox1.Items.Add("açık");  
            }
            else
            {
                listBox1.Items.Add("kapalı");
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("açık");
            }
            else
            {
                listBox1.Items.Add("kapalı");
            }

        }
    }
}
