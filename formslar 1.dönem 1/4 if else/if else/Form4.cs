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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifre=Convert.ToInt32(textBox2.Text);   
            string kullanıcı = textBox1.Text;
            if(kullanıcı=="meriç")
            {
                if(sifre==2424)
                {
                    MessageBox.Show("kullanıcı adı ve şifre doğru");
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("kullanıcı adı  yanlış");
            }
        }
    }
}
