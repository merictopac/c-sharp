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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte ortalama = Convert.ToByte(textBox1.Text);
            if (ortalama >= 50)
            {
                if (ortalama >= 85)
                {
                    this.BackColor = Color.Gold;
                    label1.Text = "taktir belgesi almaya hak kazandınız";
                }
                else if (ortalama >= 70)
                {
                    this.BackColor = Color.Green;
                    label1.Text = "teşekkür blgesi alamaya hak kazandınız";
                }
                else

                { label1.Text = "belge almadan sınıfı geçtiniz"; }
            }
            else

            { this.BackColor = Color.Red;label1.Text = "sınıfı geçemediniz"; }
                
            }
        }
    }

