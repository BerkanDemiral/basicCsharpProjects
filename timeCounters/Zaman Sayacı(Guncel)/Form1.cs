using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zaman_Sayacı_Guncel_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            say.ForeColor = Color.Black;

            try
            {
                if(radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
                {
                    if (sure.Text != "")
                    {
                        if (radioButton1.Checked == true)
                        {
                            say.Text = ((Convert.ToInt32(sure.Text)) * 60 * 60).ToString();
                        }
                        else if (radioButton2.Checked == true)
                        {
                            say.Text = ((Convert.ToInt32(sure.Text)) * 60).ToString();
                        }
                        else if (radioButton3.Checked == true)
                        {
                            say.Text = ((Convert.ToInt32(sure.Text))).ToString();
                        }
                        timer1.Start();

                    }
                    else
                    {
                        MessageBox.Show("Süreyi Girin", "Hata");
                    }

                }
                else
                {
                    MessageBox.Show("Sure Tipini Seçin", "Hata");
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            say.Text = ((int.Parse(say.Text) - 1).ToString());
            this.Text = (" ŞU ANKİ ZAMAN:"+ DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second).ToString();
            if (int.Parse(say.Text) < 10)
            {
                say.ForeColor = Color.Red;
            }
            else
            {
                say.ForeColor = Color.Black;

            }
            if (int.Parse(say.Text) < 1)
            {
                timer1.Stop();
                MessageBox.Show("Süre Doldu");
            }
            
        }
    }
}
