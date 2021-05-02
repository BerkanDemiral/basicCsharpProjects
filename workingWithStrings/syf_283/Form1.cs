using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syf_283
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.HideSelection = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.SelectionLength > 0)
            {
                textBox2.SelectedText = textBox2.SelectedText.ToUpper();
            }
            else
            {
                textBox2.Text = textBox2.Text.ToUpper();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.SelectionLength > 0)
            {
                textBox2.SelectedText = textBox2.SelectedText.ToLower();
            }
            else
            {
                textBox2.Text = textBox2.Text.ToLower();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yer = 0;
            string aranan_kelime;
            aranan_kelime = textBox1.Text;
            if (textBox1.SelectionLength > 0)
            {
                yer = textBox2.SelectionStart + textBox2.SelectedText.IndexOf(aranan_kelime);
            }
            else
            {
                yer = textBox2.Text.IndexOf(aranan_kelime);
            }
            if(yer == 0)
            {
                MessageBox.Show("Aranan ifade bulunamadı");
            }
            else
            {
                textBox2.Select(yer, aranan_kelime.Length);
                textBox2.ScrollToCaret();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.SelectionLength > 0)
            {
                textBox2.SelectedText = "";
            }
            else
            {
                textBox2.Text = "";
            }
        }
    }
}
