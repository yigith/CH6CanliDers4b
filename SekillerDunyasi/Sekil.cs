using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public abstract class Sekil
    {
        public virtual string Ad { get { return "Şekil"; } }

        public int Genislik { get; set; }

        public int Yukseklik { get; set; }

        public abstract double Alan();

        public abstract double Cevre();

        public override string ToString()
        {
            return $"{Ad} ({Genislik}x{Yukseklik})";
        }
    }
}
