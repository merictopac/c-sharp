using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forms_2022_önemli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Text += textBox1.Text + "\r\n";
            textBox4.Text += textBox2.Text + "\r\n";
            textBox4.Text += textBox3.Text + "\r\n";
            textBox4.Text += "-----------------"+"\r\n";
            decimal hesap = 0;
            if (numericUpDown1.Value > 0)
            {
                hesap += numericUpDown1.Value * 60;//Adet fiyatı 12 lira.
                textBox4.Text += string.Format("Çorba {0:C}",numericUpDown1.Value * 60) + "\r\n";
            }
            if (numericUpDown2.Value > 0)
            {
                hesap += numericUpDown2.Value * 30;//Adet fiyatı 12 lira.
                textBox4.Text += string.Format("salata {0:C}", numericUpDown2.Value * 30) + "\r\n";
            }
            if (numericUpDown3.Value > 0)
            {
                hesap += numericUpDown3.Value * 300;//Adet fiyatı 12 lira.
                textBox4.Text += string.Format("ana yemek {0:C}", numericUpDown3.Value * 300) + "\r\n";
            }
            if (numericUpDown4.Value > 0)
            {
                hesap += numericUpDown4.Value * 12;//Adet fiyatı 12 lira.
                textBox4.Text += string.Format("tatlı {0:C}", numericUpDown4.Value * 12) + "\r\n";
            }
            textBox4.Text += "-----------------";
            textBox4.Text += string.Format("Toplam {0:C}",hesap);

        }
    }
}
