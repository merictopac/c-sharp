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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            for (int i = 0;i<20;i++)
            {
                int sayi = (rnd.Next(50, 100));
                listBox1.Items.Add(sayi);
                if(sayi%2==0)
                {
                    listBox2.Items.Add(sayi);
                }
                else
                {
                    listBox3.Items.Add(sayi);
                }


            }
                
                
           
               
                    
            
            

            
        }
    }
}
