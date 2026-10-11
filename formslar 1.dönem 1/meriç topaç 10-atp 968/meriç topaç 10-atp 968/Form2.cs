using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meriç_topaç_10_atp_968
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            if (sayi==12||sayi==1||sayi==2) 
            {
                MessageBox.Show("kış");
            }
            else if (sayi ==3 ||sayi==4||sayi==5)
            {
                MessageBox.Show("ilkbahar");
            }
            else if (sayi == 6 || sayi == 7 || sayi == 8)
            {
                MessageBox.Show("yaz");
            }
            else if (sayi == 9 || sayi == 10 || sayi == 11)
            {
                MessageBox.Show("sonbahar");
            }
            else 
            {
                MessageBox.Show("hata");
            }
        }
    }
}
