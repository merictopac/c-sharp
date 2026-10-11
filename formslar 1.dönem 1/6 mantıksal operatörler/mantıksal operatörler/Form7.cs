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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim=listBox1.SelectedItem.ToString();
            bool yanıt1=radioButton1.Checked;
            bool yanıt2=radioButton2.Checked;
            if(yanıt1==true && (secim=="MP4"||secim=="MOV"))
            {
                MessageBox.Show("doğru");
            }
            if(yanıt1==false &&(secim=="MP4"||secim=="MOV"))
            {
                MessageBox.Show("yanlış");
            }

            if (yanıt2 == true && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("doğru");
            }
            if (yanıt2 == false && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("yanlış");
            }
        }
    }
}
