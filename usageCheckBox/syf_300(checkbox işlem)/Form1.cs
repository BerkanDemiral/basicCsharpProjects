using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syf_300_checkbox_işlem_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double birim_fiyat, adet, tutar, ara_toplam;

        private void checkBox_kdv_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_birimfiyati.Text == "")
            {
                birim_fiyat = 0;

            }
            else
            {
                birim_fiyat = Convert.ToDouble(txt_birimfiyati.Text);

            }

            if (txt_adet.Text == "")
            {
                adet = 0;
            }
            else
            {
                adet = Convert.ToDouble(txt_adet.Text);
            }
            ara_toplam = birim_fiyat * adet;

            if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
                tutar = tutar - tutar * 0.25;
            }
            else if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == false))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;

            }
            else if ((checkBox_kdv.Checked == false) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam - ara_toplam * 0.25;

            }
            else
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam;
                txt_tutar.Text = tutar.ToString();
            }
            txt_tutar.Text = tutar.ToString();
        }

        private void checkBox_indirim_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_birimfiyati.Text == "")
            {
                birim_fiyat = 0;

            }
            else
            {
                birim_fiyat = Convert.ToDouble(txt_birimfiyati.Text);

            }

            if (txt_adet.Text == "")
            {
                adet = 0;
            }
            else
            {
                adet = Convert.ToDouble(txt_adet.Text);
            }
            ara_toplam = birim_fiyat * adet;

            if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
                tutar = tutar - tutar * 0.25;
            }
            else if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == false))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;

            }
            else if ((checkBox_kdv.Checked == false) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam - ara_toplam * 0.25;

            }
            else
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam;
                txt_tutar.Text = tutar.ToString();
            }
            txt_tutar.Text = tutar.ToString();
        }

        private void txt_adet_TextChanged(object sender, EventArgs e)
        {
            if (txt_birimfiyati.Text == "")
            {
                birim_fiyat = 0;

            }
            else
            {
                birim_fiyat = Convert.ToDouble(txt_birimfiyati.Text);

            }

            if (txt_adet.Text == "")
            {
                adet = 0;
            }
            else
            {
                adet = Convert.ToDouble(txt_adet.Text);
            }
            ara_toplam = birim_fiyat * adet;

            if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
                tutar = tutar - tutar * 0.25;
            }
            else if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == false))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;

            }
            else if ((checkBox_kdv.Checked == false) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam - ara_toplam * 0.25;

            }
            else
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam;
                txt_tutar.Text = tutar.ToString();
            }
            txt_tutar.Text = tutar.ToString();
        }

        private void txt_birimfiyati_TextChanged(object sender, EventArgs e)
        {
            if (txt_birimfiyati.Text == "")
            {
                birim_fiyat = 0;

            }
            else
            {
                birim_fiyat = Convert.ToDouble(txt_birimfiyati.Text);

            }

            if (txt_adet.Text == "")
            {
                adet = 0;
            }
            else
            {
                adet = Convert.ToDouble(txt_adet.Text);
            }
            ara_toplam = birim_fiyat * adet;

            if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
                tutar = tutar - tutar * 0.25;
            }
            else if ((checkBox_kdv.Checked == true) && (checkBox_indirim.Checked == false))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;

            }
            else if ((checkBox_kdv.Checked == false) && (checkBox_indirim.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam - ara_toplam * 0.25;

            }
            else
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam;
                txt_tutar.Text = tutar.ToString();
            }
            txt_tutar.Text = tutar.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(txt_birimfiyati.Text == "")
            {
                birim_fiyat = 0;
                
            }
            else
            {
                birim_fiyat = Convert.ToDouble(txt_birimfiyati.Text);
                
            }

            if(txt_adet.Text == "")
            {
                adet = 0;
            }
            else
            {
                adet = Convert.ToDouble(txt_adet.Text);
            }
            ara_toplam = birim_fiyat * adet;
            

        }

    }
}
