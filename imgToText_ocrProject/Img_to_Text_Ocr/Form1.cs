// 24.10.2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr; // you should include in project for using ocr module.
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

using Patagames.Ocr;
using System.Drawing;

namespace Img_to_Text_Ocr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) // open openfiledialog
            {
              
                pictureBox1.Load(openFileDialog1.FileName); // load to picturebox, file name of openfiledialog(selected file) 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Please select a file";
            openFileDialog1.FileName = "Select File";
            openFileDialog1.InitialDirectory = @"C:\Users\Public\Pictures";
            openFileDialog1.Filter = "Jpeg Files (*.jpeg)|*.jpg|BitMap Resimler(*bmp)|*.bmp|Gif Files (*.gif)|*.gif|All Files(*)|*|" +
                "Png Files (*.png)|*.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using(var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(openFileDialog1.FileName);
                richTextBox1.Text = plainText;
            }

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(richTextBox1.Text));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
