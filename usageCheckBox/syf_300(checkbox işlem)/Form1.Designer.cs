namespace syf_300_checkbox_işlem_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_malzemeadi = new System.Windows.Forms.TextBox();
            this.txt_birimfiyati = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.checkBox_indirim = new System.Windows.Forms.CheckBox();
            this.checkBox_kdv = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim Fiyat: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tutar";
            // 
            // txt_malzemeadi
            // 
            this.txt_malzemeadi.Location = new System.Drawing.Point(158, 51);
            this.txt_malzemeadi.Name = "txt_malzemeadi";
            this.txt_malzemeadi.Size = new System.Drawing.Size(100, 20);
            this.txt_malzemeadi.TabIndex = 4;
            // 
            // txt_birimfiyati
            // 
            this.txt_birimfiyati.Location = new System.Drawing.Point(158, 85);
            this.txt_birimfiyati.Name = "txt_birimfiyati";
            this.txt_birimfiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_birimfiyati.TabIndex = 5;
            this.txt_birimfiyati.TextChanged += new System.EventHandler(this.txt_birimfiyati_TextChanged);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(158, 120);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(100, 20);
            this.txt_adet.TabIndex = 6;
            this.txt_adet.TextChanged += new System.EventHandler(this.txt_adet_TextChanged);
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(158, 222);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(100, 20);
            this.txt_tutar.TabIndex = 7;
            // 
            // checkBox_indirim
            // 
            this.checkBox_indirim.AutoSize = true;
            this.checkBox_indirim.Location = new System.Drawing.Point(158, 186);
            this.checkBox_indirim.Name = "checkBox_indirim";
            this.checkBox_indirim.Size = new System.Drawing.Size(104, 17);
            this.checkBox_indirim.TabIndex = 9;
            this.checkBox_indirim.Text = "%25 Bayi İndirimi";
            this.checkBox_indirim.UseVisualStyleBackColor = true;
            this.checkBox_indirim.CheckedChanged += new System.EventHandler(this.checkBox_indirim_CheckedChanged);
            // 
            // checkBox_kdv
            // 
            this.checkBox_kdv.AutoSize = true;
            this.checkBox_kdv.Location = new System.Drawing.Point(158, 163);
            this.checkBox_kdv.Name = "checkBox_kdv";
            this.checkBox_kdv.Size = new System.Drawing.Size(67, 17);
            this.checkBox_kdv.TabIndex = 10;
            this.checkBox_kdv.Text = "%18 kdv";
            this.checkBox_kdv.UseVisualStyleBackColor = true;
            this.checkBox_kdv.CheckedChanged += new System.EventHandler(this.checkBox_kdv_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 380);
            this.Controls.Add(this.checkBox_kdv);
            this.Controls.Add(this.checkBox_indirim);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_birimfiyati);
            this.Controls.Add(this.txt_malzemeadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_malzemeadi;
        private System.Windows.Forms.TextBox txt_birimfiyati;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.CheckBox checkBox_indirim;
        private System.Windows.Forms.CheckBox checkBox_kdv;
    }
}

