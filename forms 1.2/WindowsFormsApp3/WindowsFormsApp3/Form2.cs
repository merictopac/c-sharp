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

namespace WindowsFormsApp3
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
            for (int i = 0; i < sehirler.Count; i++)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int indekNo = listBox1.SelectedIndex;
            sehirler.Insert(indekNo,textBox1.Text);
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indekNo = listBox1.SelectedIndex;
            sehirler[indekNo]=textBox1.Text;
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indekNo=listBox1.SelectedIndex;
            sehirler.RemoveAt(indekNo);
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(textBox1.Text))
            {
                label2.Text = "aranan veri bulundu";
                listBox1.SelectedIndex=sehirler.IndexOf(textBox1.Text);

            }
            else
            {
                label2.Text = "aranan veri buluınamadı";
            }
        }
    }
}
