using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarkliKaydet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGetir.Click += BtnGetir_Click;
            btnKaydet.Click += BtnKaydet_Click;
            btnKapat.Click += BtnKapat_Click;
            btnSil.Click += BtnSil_Click;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lDosya.Text != "")
            {
                DialogResult asd = MessageBox.Show(lDosya.Text+"\nDosyasını Silmek İstediğinize Emin Misiniz?","Uyari",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                if (asd == DialogResult.Yes)
                {                  
                    sAciklama.Text = "Dosya Başarıyla Silindi.";
                    tMetin.Clear();
                    File.Delete(lDosya.Text);
                    lDosya.Text = "";
                }
                else
                {
                    sAciklama.Text = "Dosya Silme İşlemi İptal Edildi.";
                }
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Dosyayı Açınız!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            lDosya.Text = "";
            tMetin.Text = "";
            sAciklama.Text = "Dosya Kapatildi.";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (tMetin.Text == string.Empty)
            {
                sAciklama.Text = "Dosya Boş";
            }
            else if (lDosya.Text == "")
            {
                SaveFileDialog pencere = new SaveFileDialog();
                DialogResult sonuc = pencere.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    FileStream fs = File.Create(pencere.FileName);
                    StreamWriter yazici = new StreamWriter(fs);
                    yazici.Write(tMetin.Text);
                    yazici.Close();
                    fs.Close();
                    sAciklama.Text = "Basariyla Kaydedildi.";
                    lDosya.Text = pencere.FileName.ToString();
                }
                else
                {
                    sAciklama.Text = "Kaydetme İşlemi İptal Edildi.";
                }
            }           
            else
            {
                StreamWriter yazici = new StreamWriter(lDosya.Text);
                yazici.Write(tMetin.Text);
                yazici.Close();
                sAciklama.Text = "Dosyanin Uzerine Yazildi.";
            }
        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            OpenFileDialog pencere = new OpenFileDialog();
            DialogResult sonuc = pencere.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(pencere.FileName);
                StreamReader okuyucu = new StreamReader(fs);
                tMetin.Text = okuyucu.ReadToEnd();
                okuyucu.Close();
                fs.Close();

                lDosya.Text = pencere.FileName.ToString();
                sAciklama.Text = "Dosya Acildi.";
            }
        }
    }
}
