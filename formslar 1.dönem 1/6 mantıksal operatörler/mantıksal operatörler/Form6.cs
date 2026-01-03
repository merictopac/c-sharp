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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sec=listBox1.SelectedItem.ToString();
            if(sec=="fare"|| sec == "klavye"|| sec == "kemera"|| sec == "tarayıcı")
            {
                MessageBox.Show("giriş");
            }
            if(sec=="yazıcı"||sec=="hoparlör"||sec== "projeksyon")
            {
                MessageBox.Show("çıkış");
            }
        }
    }
}
