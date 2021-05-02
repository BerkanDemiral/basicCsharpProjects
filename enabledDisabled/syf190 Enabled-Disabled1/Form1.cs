using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syf190_Enabled_Disabled1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true; // button 1 görünür durumda, form açıldığı anda
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true; // button 1'e basınca buton 2 görünür olmaya başlıyor.
            MessageBox.Show("Programla bağlantı sağlandı.","Bağlantı durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            MessageBox.Show("Programla bağlantı sonlandı."," Bağlantı durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
