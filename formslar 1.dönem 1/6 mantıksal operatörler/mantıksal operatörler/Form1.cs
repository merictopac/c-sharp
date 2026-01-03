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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            {
                int ses = trackBar1.Value;
                if (ses == 0)
                {
                    label1.Text = "ses yok";
                }
                if(ses>0&& ses<=10)
                {
                    label1.Text = "normal ses";
                }
                if(ses>=11)
                {
                    label1.Text = "yüksek ses";
                }




            }
        }
    }
}
