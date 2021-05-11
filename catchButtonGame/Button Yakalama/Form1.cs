using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Yakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int boyutx, boyuty;
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            boyutx = this.Width;
            boyuty = this.Height;
            Random r = new Random();
            int rastgele1 = r.Next(boyutx - (button1.Width) * 3);
            int rastgele2 = r.Next(boyuty - (button1.Height) * 3);

            button1.Location = new Point(rastgele1, rastgele2);
        }
    }
}
