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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            Listele();
        }
        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.Insert(indexNo, textBox1.Text);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indekNo = listBox1.SelectedIndex;
            sehirler[indekNo]=textBox1.Text;
            Listele();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
