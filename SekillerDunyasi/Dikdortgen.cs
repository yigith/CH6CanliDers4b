using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen()
        {
            // default değer atama yöntem 1
            //KoseAdedi = 4;
        }

        //public override string Ad { get { return "Dikdörtgen"; } }
        public override string Ad => "Dikdörtgen";

        // property'ye default değer atama yöntemi 2
        public int KoseAdedi { get; } = 4;

        public override double Alan()
        {
            return Genislik * Yukseklik;
        }

        public override double Cevre()
        {
            return 2 * (Genislik + Yukseklik);
        }
    }
}
