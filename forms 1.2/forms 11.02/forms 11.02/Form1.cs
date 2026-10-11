using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_11._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESC tuşuna bastınız");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter tuşuna bastınız");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.ControlBox==true)
            {
                this.ControlBox = false;
            }
            else
            {
                this.ControlBox = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("form yükleniyor");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("form kapanıyor");
        }
    }
}
