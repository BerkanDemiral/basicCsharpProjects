using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syf_411_Yazdırma_İşlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print(); // Otomatik olarak yazdırma işleminin açılması sağlanır.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }
        int sayi = 1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // kağıdın tam yüksekliği ile şu anki sayfanın yüksekliği hesaplanıp gerçek alan boyutu bulunuyor.
            int sayfa_yuksekliği;
            System.Drawing.Printing.PageSettings sayfa_ayari;
            sayfa_ayari = printDocument1.DefaultPageSettings;
            sayfa_yuksekliği = sayfa_ayari.PaperSize.Height - sayfa_ayari.Margins.Top - sayfa_ayari.Margins.Bottom;

            // Bir satırın yüksekliği Graphics sınıfındaki MeasureString metodu ile öğrenilebilir.
            // Bu şekilde kullanılan yazı fontuna ait satır yüksekliği öğrenilebilir.
            Font fnt = new Font("Tahoma", 14, FontStyle.Regular);
            int satir_yuksekliği;
            satir_yuksekliği = (int)e.Graphics.MeasureString("1", fnt).Height;

            // sayfada yazdırılabilecek toplam alan tespit edilir.
            int maksimum_satir;
            maksimum_satir = sayfa_yuksekliği / satir_yuksekliği;
            int i, satir_no = 0;

            //100 sayısına ulaşıncaya kadar bu sayafaya yazdır sonrasında yazılanları ise diğer sayfaya geçerek yazdır.
            for (i = sayi; i<sayi+maksimum_satir; i++)
            {
                if (i > 200)
                {
                    e.HasMorePages = false;
                    sayi = 1;
                    return;
                }

                e.Graphics.DrawString(i.ToString() + ". satır", fnt, new SolidBrush(Color.Black),
                    printDocument1.DefaultPageSettings.Margins.Left,
                    printDocument1.DefaultPageSettings.Margins.Top + satir_no * satir_yuksekliği);

                satir_no++;
                    
            }

            sayi = i;
            if(i< 200)
            {
                e.HasMorePages = true;
            }


        }
    }
}
