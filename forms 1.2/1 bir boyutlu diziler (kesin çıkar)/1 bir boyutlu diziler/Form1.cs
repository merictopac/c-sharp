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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[3];
        int[]notlar=new int[3];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            isimler[index] = textBox1.Text;
            notlar[index]=Convert.ToInt32(textBox2.Text);
            index++;
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text=index+"/3".ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i< isimler.Length;i++)
            {
                if (isimler[i]!=null)
                {
                    listBox1.Items.Add(isimler[i] + ">" + notlar[i]);
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int enYuksek=notlar[0];
            for(int i=0;i<notlar.Length;i++)
            {
                if (notlar[i]>enYuksek)
                {
                    enYuksek = notlar[i];
                }
            }
            textBox4.Text=enYuksek.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int enDUsuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] >enDUsuk)
                {
                    enDUsuk = notlar[i];
                }
            }
            textBox5.Text = enDUsuk.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama;
            for(int i=0;i<notlar.Length;i++)
            {
                toplam = toplam+notlar[i];
            }
            ortalama=toplam/notlar.Length;
            textBox5.Text = toplam.ToString();
        }
      
    }
}
