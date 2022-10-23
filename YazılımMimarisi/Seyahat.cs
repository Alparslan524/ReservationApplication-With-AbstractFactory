using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisi
{
    public class Seyahat
    {
        private RezervasyonFabrika _rezervasyonFabrika;
        private IUlasim _ulasim;
        private IKonaklama _konaklama;
        public Seyahat(RezervasyonFabrika rezervasyonFabrika)
        {
            _rezervasyonFabrika = rezervasyonFabrika;
            _ulasim = _rezervasyonFabrika.Ulasim();
            _konaklama = _rezervasyonFabrika.Konaklama();
        }

        public List<int> TipSecimleri()
        {
            List<int> liste = new List<int>();
            int a = _ulasim.UlasimTipi();
            int b = _konaklama.KonaklamaTipi();
            liste.Add(a);
            liste.Add(b);
            return liste;
        }



    }
}
