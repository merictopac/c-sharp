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

namespace Meriç_Topaç_10ATP_968
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           /* string sayi1=textBox1.Text;
            string sayi2 = textBox2.Text;
            
            if (radioButton1.Checked) 
            {
                sayi1+sayi2 = Convert.ToInt32(textBox3.Text);
                
            }*/
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
           // MessageBox.Show(MessageBoxButtons.OKCancel("çıkmak istediğinizden emin misiniz"));
            Close();
        }
        ArrayList liste= new ArrayList();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0;i<=0;i++)
            {
                listBox1.Items.Add(liste);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 0; i++)
            {
                listBox1.Items.Remove();
            }
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 0; i++)
            {
                listBox1.Items.Remove(liste); listBox1.Items.Add(liste);
            }
        }*/

        /*private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string sayi1 = textBox1.Text;
            string sayi2 = textBox2.Text;

            if (radioButton2.Checked)
            {
                sayi1 - sayi2 = Convert.ToInt32(textBox3.Text);

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string sayi1 = textBox1.Text;
            string sayi2 = textBox2.Text;

            if (radioButton3.Checked)
            {
                sayi1 * sayi2 = Convert.ToInt32(textBox3.Text);

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string sayi1 = textBox1.Text;
            string sayi2 = textBox2.Text;

            if (radioButton4.Checked)
            {
                sayi1 / sayi2 = Convert.ToInt32(textBox3.Text);

            }
        }*/
    }
}
