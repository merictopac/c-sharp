using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_bir_boyutlu_diziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] dizikaynak = new int[100];
        int[] dizikopya = new int[100];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for(var i=0;i<dizikaynak.Length;i++)
            {
                dizikaynak[i]= rnd.Next(1,101);
            }
            for (var i = 0; i < dizikaynak.Length; i++)
            {
                listBox1.Items.Add(dizikaynak[i]);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (var i = 0; i < dizikopya.Length; i++)
            {
                dizikopya[i] = dizikaynak[i];
            }
            
            for (var i = 0; i < dizikopya.Length; i++)
            {
                listBox2.Items.Add(dizikaynak[i]);
            }
        }
    }
}
