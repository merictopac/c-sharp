using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_hata_ayıklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, karesi;
            try
            {
                sayi1 = Convert.ToInt16(textBox1.Text);
                karesi = sayi1 * sayi1;
                MessageBox.Show(karesi.ToString());

            }
            catch
            {
                MessageBox.Show("hatalı giriş yaptınız");
            }
            finally
            { 
                textBox1.Clear();
            }
        }
    }
}
