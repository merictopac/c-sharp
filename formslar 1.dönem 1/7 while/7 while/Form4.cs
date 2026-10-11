using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_while
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int say = 1;
            int toplam = 0;
            while (toplam <= 1000)
            {
                toplam = toplam + say;
                say += 1;
            }
            listBox1.Items.Add(toplam);
            MessageBox.Show("toplam " + say.ToString() + " kez çalıştı");
        }
    }
}
