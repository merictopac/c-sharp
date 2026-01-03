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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            byte sinif;
            sinif = Convert.ToByte(comboBox1.Text);
            if (sinif > 0 && sinif < 5)
            {
                MessageBox.Show("ilkokul");
                this.BackColor =Color.Green ;
            }
            else if (sinif > 4 && sinif < 9)
            {
                this.BackColor = Color.Yellow;
                MessageBox.Show("ortaokul");
          
            }
            else if (sinif > 8 && sinif < 13)
            {
                MessageBox.Show("lise");
                this.BackColor = Color.Red;
            }
        }
    }
    }
    

