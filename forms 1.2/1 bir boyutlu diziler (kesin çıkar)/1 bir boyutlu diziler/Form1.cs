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
<<<<<<< HEAD
            textBox3.Text=enYuksek.ToString();
=======
            textBox4.Text=enYuksek.ToString();
>>>>>>> 9c2edc11ac176e8787008a9558f1dfa2556d6731
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int enDUsuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
<<<<<<< HEAD
                if (notlar[i] <enDUsuk)
=======
                if (notlar[i] >enDUsuk)
>>>>>>> 9c2edc11ac176e8787008a9558f1dfa2556d6731
                {
                    enDUsuk = notlar[i];
                }
            }
<<<<<<< HEAD
            textBox4.Text = enDUsuk.ToString();
=======
            textBox5.Text = enDUsuk.ToString();
>>>>>>> 9c2edc11ac176e8787008a9558f1dfa2556d6731
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
<<<<<<< HEAD
            textBox5.Text = ortalama.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
=======
            textBox5.Text = toplam.ToString();
        }
      
>>>>>>> 9c2edc11ac176e8787008a9558f1dfa2556d6731
    }
}
