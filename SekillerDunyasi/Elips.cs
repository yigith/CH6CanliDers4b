﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi
{
    public class Elips : Sekil
    {
        public override string Ad => "Elips";

        public double A => (double)Genislik / 2; // double bölme işlemi

        public double B => Yukseklik / 2d; // double bölme işlemi

        public override double Alan()
        {
            return Math.PI * A * B;
        }

        public override double Cevre()
        {
            return 2 * Math.PI * Math.Sqrt((A * A + B * B) / 2);
        }
    }
}
