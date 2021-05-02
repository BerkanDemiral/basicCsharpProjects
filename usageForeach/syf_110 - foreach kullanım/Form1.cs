using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syf_110___foreach_kullanım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for ( int i=0; i<10; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
            foreach (string i in listBox1.Items) // listbox1 in tüm eleamanlarına in diyerek bakıyor.
            {
                toplam += Convert.ToInt16(i); // elemanlar listbox'1 in içinde string olduğu için toplama atarken çeviri yapıyoruz.
            }
            listBox1.Items.Add("Toplamları: ");
            listBox1.Items.Add(toplam.ToString());
        }
    }
}
