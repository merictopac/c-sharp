using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tooltip_2022
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        ErrorProvider ep = new ErrorProvider();
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox1, out int sonuc))
            {
                ep.SetError(textBox1, "";//düzelt
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textBox1,"Numara girişi hatalı");
            }
        }
    }
}

