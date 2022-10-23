using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisi
{
    public class Otel : IKonaklama
    {
        public int KonaklamaTipi()
        {
            return 1;
        }
    }
}
