
namespace FarkliKaydet
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tMetin = new System.Windows.Forms.RichTextBox();
            this.lDosya = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSil = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(12, 215);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(69, 29);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(69, 29);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // tMetin
            // 
            this.tMetin.Location = new System.Drawing.Point(12, 12);
            this.tMetin.Name = "tMetin";
            this.tMetin.Size = new System.Drawing.Size(370, 197);
            this.tMetin.TabIndex = 2;
            this.tMetin.Text = "";
            // 
            // lDosya
            // 
            this.lDosya.AutoSize = true;
            this.lDosya.Location = new System.Drawing.Point(12, 71);
            this.lDosya.Name = "lDosya";
            this.lDosya.Size = new System.Drawing.Size(0, 17);
            this.lDosya.TabIndex = 4;
            this.lDosya.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(312, 215);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(70, 29);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(397, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sAciklama
            // 
            this.sAciklama.Name = "sAciklama";
            this.sAciklama.Size = new System.Drawing.Size(0, 16);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(312, 250);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 29);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 320);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lDosya);
            this.Controls.Add(this.tMetin);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form1";
            this.Text = "Kaydetme İşlemleri";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RichTextBox tMetin;
        private System.Windows.Forms.Label lDosya;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sAciklama;
        private System.Windows.Forms.Button btnSil;
    }
}

