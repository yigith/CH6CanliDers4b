using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimSirket
{
    public class Calisan
    {
        private static decimal _vergiOran = 0.15m;

        // parametresiz constructor
        public Calisan()
        {
            
        }

        public Calisan(string ad, string pozisyon, decimal netMaas)
        {
            Ad = ad;
            Pozisyon = pozisyon;
            NetMaas = netMaas;
        }

        public static void VergiOraniniGuncelle(decimal yeniOran)
        {
            _vergiOran = yeniOran;
        }

        public string Ad { get; set; }

        public string Pozisyon { get; set; }

        public decimal NetMaas { get; set; }

        // read-only property
        public decimal BrutMaas => NetMaas + NetMaas * _vergiOran;

        //public decimal BrutMaas
        //{
        //    get
        //    {
        //        return NetMaas + NetMaas * _vergiOran;
        //    }
        //}

        public override string ToString()
        {
            return $"{Ad} adlı çalışan {Pozisyon} pozisyonunda çalışır. Net Maaşı = {NetMaas:c2} | Brüt Maaşı = {BrutMaas:c2}";
        }

    }
}
