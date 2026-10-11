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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi;
                long parola;
                try
                {
                    kullaniciAdi = textBox1.Text.ToString();
                    parola = long.Parse(textBox2.Text.ToString());
                    MessageBox.Show("Giriş Başarılı.Hoşgeldiniz " +kullaniciAdi);
                }
                catch (Exception)
                {
                    MessageBox.Show("Şifreniz Sadece Sayılardan Oluşmalıdır.Tekrar Deneyiniz.");
                    textBox2.Text= "";
                }
                finally
                {
                textBox1.Clear();
                textBox2.Clear();
                }
        }
    }
}
