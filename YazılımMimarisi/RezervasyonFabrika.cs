using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisi
{
    public abstract class RezervasyonFabrika 
    {
        public abstract IKonaklama Konaklama();
        public abstract IUlasim Ulasim();

        
    }



    public class OtobusOtel : RezervasyonFabrika
    {
        public override IKonaklama Konaklama()
        {
            return new Otel();
        }

        public override IUlasim Ulasim()
        {
            return new Otobus();
        }
    }



    public class OtobusCadir : RezervasyonFabrika
    {
        public override IKonaklama Konaklama()
        {
            return new Cadir();
        }

        public override IUlasim Ulasim()
        {
            return new Otobus();
        }
    }



    public class UcakCadir : RezervasyonFabrika
    {
        public override IKonaklama Konaklama()
        {
            return new Cadir();
        }

        public override IUlasim Ulasim()
        {
            return new Ucak();
        }
    }



    public class UcakOtel : RezervasyonFabrika
    {
        public override IKonaklama Konaklama()
        {
            return new Otel();
        }

        public override IUlasim Ulasim()
        {
            return new Ucak();
        }
    }




}



