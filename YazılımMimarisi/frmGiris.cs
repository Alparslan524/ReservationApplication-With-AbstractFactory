using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace YazılımMimarisi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyisim.Text;
            musteri.TC = txtTC.Text;
            musteri.DogumTarih = txtDogumTarih.Text;
            musteri.GidilecekTarih = maskedTextBoxGidisTarih.Text;
            musteri.DonulecekTarih = maskedTextBoxDonusTarih.Text;
            musteri.Lokasyon = txtGidilecekLokasyon.Text;
            


            
            if (comboBoxPaketSeciniz.SelectedIndex + 1 == 1)
            {
                Seyahat seyahat = new Seyahat(new OtobusOtel());
                List<int> liste1 = new List<int>();
                liste1 = seyahat.TipSecimleri();
                musteri.UlasımID = liste1[0];
                musteri.KonaklamaID = liste1[1];
                musteri.Fiyat = lblFiyat.Text;
            }
           
            if (comboBoxPaketSeciniz.SelectedIndex + 1 == 2)
            {
                Seyahat seyahat = new Seyahat(new OtobusCadir());
                List<int> liste1 = new List<int>();
                liste1 = seyahat.TipSecimleri();
                musteri.UlasımID = liste1[0];
                musteri.KonaklamaID = liste1[1];
                musteri.Fiyat = lblFiyat.Text;
            }
            
            if (comboBoxPaketSeciniz.SelectedIndex + 1 == 3)
            {
                Seyahat seyahat = new Seyahat(new UcakOtel());
                List<int> liste1 = new List<int>();
                liste1 = seyahat.TipSecimleri();
                musteri.UlasımID = liste1[0];
                musteri.KonaklamaID = liste1[1];
                musteri.Fiyat = lblFiyat.Text;
            }
        
            if (comboBoxPaketSeciniz.SelectedIndex + 1 == 4)
            {
                Seyahat seyahat = new Seyahat(new UcakCadir());
                List<int> liste1 = new List<int>();
                liste1 = seyahat.TipSecimleri();
                musteri.UlasımID = liste1[0];
                musteri.KonaklamaID = liste1[1];
                musteri.Fiyat = lblFiyat.Text;
            }

            VeriTabaniİslemi veriTabaniİslemi = new VeriTabaniİslemi();
            veriTabaniİslemi.MusteriEkle(musteri);
            musteri.GeciciMusteriID =veriTabaniİslemi.MusteriIDCekme(musteri);
            veriTabaniİslemi.SeyahatEkle(musteri);
            MessageBox.Show("Kaydınız Başarıyla Tamamlandı");
            Temizle();
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyisim.Text = "";
            txtTC.Text = "";
            txtDogumTarih.Text = "";
            txtGidilecekLokasyon.Text = "";
            maskedTextBoxDonusTarih.Text = "";
            maskedTextBoxGidisTarih.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabaniİslemi veriTabaniİslemi = new VeriTabaniİslemi();
            Musteri musteri = new Musteri();
            musteri.TC = txtVeriSilmeTC.Text;
            bool TCVarmi = veriTabaniİslemi.TCArama(musteri);

            if (TCVarmi)
            {
                musteri.GeciciMusteriID = veriTabaniİslemi.MusteriIDCekme(musteri);
                veriTabaniİslemi.SeyahatSil(musteri);
                veriTabaniİslemi.MusteriSil(musteri);
                MessageBox.Show("Seyahat Başarıyla Silindi");
                txtVeriSilmeTC.Text = "";
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz rezervasyon bulunamadı!!");
            }

            
        }

        private void comboBoxPaketSeciniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPaketSeciniz.Text== "Otobüs - Otel")
            {
                lblFiyat.Text = "500 TL";
            }
            else if (comboBoxPaketSeciniz.Text == "Otobüs - Çadır")
            {
                lblFiyat.Text = "200 TL";
            }
            else if (comboBoxPaketSeciniz.Text == "Uçak - Otel")
            {
                lblFiyat.Text = "800 TL";
            }
            else if (comboBoxPaketSeciniz.Text == "Uçak - Çadır")
            {
                lblFiyat.Text = "600 TL";
            }

        }

        private void btnJsonOlustur_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            VeriTabaniİslemi veriTabaniİslemi = new VeriTabaniİslemi();
            veriTabaniİslemi.BilgiCekme();
            
            string JsonData = Newtonsoft.Json.JsonConvert.SerializeObject(veriTabaniİslemi.Rapor);
            File.WriteAllText(@"C:\Users\MONSTER\Desktop\Raporlar\MusteriBilgi.json", JsonData);
            MessageBox.Show("JSON Tipinde Rapor oluşturuldu");
        }

        private void btnXmlOlustur_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            VeriTabaniİslemi veriTabaniİslemi = new VeriTabaniİslemi();
            veriTabaniİslemi.BilgiCekmeXML(m);
            string xmlDosyasi = (@"C:\Users\MONSTER\Desktop\Raporlar\MusteriBilgi.xml");
            FileStream fileStream = new FileStream(xmlDosyasi, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(m.GetType());
            xmlSerializer.Serialize(fileStream, m);
            fileStream.Close();
            MessageBox.Show("XML Tipinde Rapor oluşturuldu");
        }
    }
}
