using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantıksal_operatörler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo =Convert.ToDouble(textBox1.Text);
            double boy=Convert.ToDouble(maskedTextBox1.Text);
            double hesap =(kilo / (boy * boy));
            if (hesap < 18.49)
            {
                MessageBox.Show(hesap+"  zayıf");
            }
            else if (hesap > 18.50 && hesap < 24.99)
            {
                MessageBox.Show(hesap+"  ideal");
            }
            else if (hesap > 25 && hesap < 29.99)
            {
                MessageBox.Show(hesap + "  obez");
            }
            else if (hesap>30)
            {
                MessageBox.Show(hesap+"  aşırı obez");
            }
            
          
        }
    }
}
