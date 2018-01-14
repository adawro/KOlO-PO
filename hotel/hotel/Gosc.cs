﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Gosc
    {
        private string imie;
        private string nazwisko;

        public Gosc()
        {

        }

        public Gosc(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public override string ToString()
        {
            return $"Gosc, {imie} {nazwisko}";
        }
    }
}
