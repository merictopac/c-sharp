using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace vermente_virüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("çıkmak istediğinizdem emin misiniz", "çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf=new SaveFileDialog();
            sdf.Filter = "text dosyası|*.txt|tüm dosyalar|*.*";
            DialogResult cevap= sdf.ShowDialog();
            if (cevap == DialogResult.OK) 
            {
                richTextBox1.SaveFile(sdf.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları | *.txt";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
