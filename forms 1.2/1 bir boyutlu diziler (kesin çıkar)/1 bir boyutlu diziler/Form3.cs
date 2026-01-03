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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int[]sayilar=new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd= new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0,10);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
            label1.Text="Length:"+sayilar.Length.ToString();

            label2.Text= "Rank:"+sayilar.Rank.ToString();

            label3.Text = "Max:" + sayilar.Max().ToString();

            label4.Text = "Min:" + sayilar.Min().ToString();

            label5.Text = "Sum:" + sayilar.Sum().ToString();

            label6.Text = "Average:" + sayilar.Average().ToString();

            label7.Text = "First:" + sayilar.First().ToString();

            label8.Text = "Last:" + sayilar.Last().ToString();
        }
    }
}
