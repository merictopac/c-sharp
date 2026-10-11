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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            if (radioButton2.Checked == true || radioButton3.Checked == true)
            {
                fiyat = fiyat + (fiyat * 0.05);
            }
            if (radioButton4.Checked == true || radioButton5.Checked == true)
            {
                fiyat = fiyat + (fiyat * 0.10);
            }
            MessageBox.Show("ödenecek tutar " + fiyat.ToString() + " tl");



        }
    }
}
