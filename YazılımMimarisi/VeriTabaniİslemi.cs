using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace YazılımMimarisi
{
    public class VeriTabaniİslemi
    {
        public List<Musteri> Rapor=new List<Musteri>();
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader oku;

        public VeriTabaniİslemi()
        {
            Baglan();
        }
        
        private void Baglan()
        {
            baglanti = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=YazilimMimarisiveTasarimi;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        public void MusteriEkle(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("insert into tblMusteri (MusteriAd,MusteriSoyad,TC,DogumTarihi) values (@pMusteriAd,@pMusteriSoyad,@pTC,@pDogumTarihi)");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pMusteriAd",m.Ad);
                komut.Parameters.AddWithValue("@pMusteriSoyad", m.Soyad);
                komut.Parameters.AddWithValue("@pTC",m.TC);
                komut.Parameters.AddWithValue("@pDogumTarihi",m.DogumTarih);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Müşteri eklerken hatası alındı");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();
                }
            }
        }

        public int MusteriIDCekme(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText=("select MusteriID from tblMusteri where TC = @ptece");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@ptece",m.TC);
                oku = komut.ExecuteReader();
                
                while (oku.Read())
                {
                    m.GeciciMusteriID = Convert.ToInt32(oku["MusteriID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "MusteriID okuma sırasında bu hatayı aldınız.");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();

                }
            }

            return m.GeciciMusteriID;
        }

        public void SeyahatEkle(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("insert into tblSeyahat (DonusTarihi,GidisTarihi,Lokasyon,MusteriID,KonaklamaID,UlasimID,Fiyat) values(@pDonusTarihi, @pGidisTarihi, @pLokasyon, @pMusteriID, @pKonaklamaID, @pUlasimID,@pFiyat)");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pDonusTarihi",m.DonulecekTarih);
                komut.Parameters.AddWithValue("@pGidisTarihi", m.GidilecekTarih);
                komut.Parameters.AddWithValue("@pLokasyon", m.Lokasyon);
                komut.Parameters.AddWithValue("@pMusteriID", m.GeciciMusteriID);
                komut.Parameters.AddWithValue("@pKonaklamaID",m.KonaklamaID);
                komut.Parameters.AddWithValue("@pUlasimID", m.UlasımID);
                komut.Parameters.AddWithValue("@pFiyat", m.Fiyat);
                komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Seyahat eklerken bu hatayı aldınız ");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();
                }
            }


        }
        
        public void SeyahatSil(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("delete from tblSeyahat where MusteriID=@pMusteriID");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pMusteriID",m.GeciciMusteriID);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Rezervasyon silme sırasında bu hatayı aldınız.");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();
                }
            }
        
        
        
        
        
        
        }

        public void MusteriSil(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("delete from tblMusteri where MusteriID=@pMusteriID2");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pMusteriID2", m.GeciciMusteriID);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Müşteri silme sırasında bu hatayı aldınız");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();
                }
            }


        }
       
        public bool TCArama(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("select * from tblMusteri where TC = @ptece1");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@ptece1",m.TC);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (m.TC==oku["TC"].ToString())
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "TC arama sırasında bu hatayı aldınız");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();
                }
            }
            return false;
        }

        public void BilgiCekme()
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("select s.GidisTarihi ,s.DonusTarihi ,s.Lokasyon, m.MusteriAd ," +
                                     "m.MusteriSoyad , u.UlasimAdi , k.KonaklamaAdi ,s.Fiyat " +
                                     "from tblSeyahat S inner join tblMusteri M on s.MusteriID=m.MusteriID " +
                                     "inner join tblKonaklamaAdi K on s.KonaklamaID=k.KonaklamaID " +
                                     "inner join tblUlasimAdi U on u.UlasimID=s.UlasimID");
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Musteri m1 = new Musteri();
                    m1.GidilecekTarih = oku["GidisTarihi"].ToString();
                    m1.DonulecekTarih = oku["DonusTarihi"].ToString();
                    m1.Lokasyon = oku["Lokasyon"].ToString();
                    m1.Ad = oku["MusteriAd"].ToString();
                    m1.Soyad= oku["MusteriSoyad"].ToString();
                    m1.UlasimTuru = oku["UlasimAdi"].ToString();
                    m1.KonaklamaTuru = oku["KonaklamaAdi"].ToString();
                    m1.Fiyat = oku["Fiyat"].ToString();
                    Rapor.Add(m1);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Bilgi çekme sırasında bu hatayı aldınız");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();
                }
            }
        }

        public void BilgiCekmeXML(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("select s.GidisTarihi ,s.DonusTarihi ,s.Lokasyon, m.MusteriAd ," +
                                     "m.MusteriSoyad , u.UlasimAdi , k.KonaklamaAdi ,s.Fiyat " +
                                     "from tblSeyahat S inner join tblMusteri M on s.MusteriID=m.MusteriID " +
                                     "inner join tblKonaklamaAdi K on s.KonaklamaID=k.KonaklamaID " +
                                     "inner join tblUlasimAdi U on u.UlasimID=s.UlasimID");
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    m.GidilecekTarih = oku["GidisTarihi"].ToString();
                    m.DonulecekTarih = oku["DonusTarihi"].ToString();
                    m.Lokasyon = oku["Lokasyon"].ToString();
                    m.Ad = oku["MusteriAd"].ToString();
                    m.Soyad = oku["MusteriSoyad"].ToString();
                    m.UlasimTuru = oku["UlasimAdi"].ToString();
                    m.KonaklamaTuru = oku["KonaklamaAdi"].ToString();
                    m.Fiyat = oku["Fiyat"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Bilgi çekme sırasında bu hatayı aldınız");
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }

    }
}
