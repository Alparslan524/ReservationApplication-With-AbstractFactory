using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YazılımMimarisi
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string DogumTarih { get; set; }
        public string Lokasyon{ get; set; }
        public string GidilecekTarih { get; set; }
        public string DonulecekTarih { get; set; }
        public int KonaklamaID { get; set; }
        public int UlasımID { get; set; }
        public int GeciciMusteriID { get; set; }
        public string Fiyat { get; set; }
        public string UlasimTuru { get; set; }
        public string KonaklamaTuru { get; set; }

       

    }
}
