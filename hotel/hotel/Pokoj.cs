using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Pokoj : IComparable<Pokoj>
    {
        protected int numerPokoju;
        private double cenaZaDzien;

        public Pokoj(int numerPokoju, double cenaZaDzien)
        {
            this.numerPokoju = numerPokoju;
            this.cenaZaDzien = cenaZaDzien;
        }

        public override string ToString()
        {
            return $"Pokoj, nr {numerPokoju} cena za dzien {cenaZaDzien}";
        }

        public int PobierzNrPokoju(int numerPokju)
        {
            return numerPokoju;
        }

        public double PobierzCene(double cenaZaDzien)
        {
            return cenaZaDzien;
        }

        public int CompareTo(Pokoj other)
        {
            return this.numerPokoju.CompareTo(other.numerPokoju);
        }
    }
}
