using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.dönem__ilk_ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Binding bagla = new Binding("text", textBox1, "text");
            textBox2.DataBindings.Add(bagla);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
