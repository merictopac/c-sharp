using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_sınavda_çıkar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ArrayList sehirler=new ArrayList();
        private void listele()
        {
            listBox1.Items.Clear();
            for(int i=0;i<sehirler.Count;i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            textBox1.Clear();
            listele();
        }
    }
}
