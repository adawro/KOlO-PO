using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Autor
    {
        protected string imie;
        protected string nazwisko;

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public Autor() { }

        public Autor(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public void wypiszInfo()
        {
            Console.WriteLine("Imie {0} Nazwisko {1}", imie, nazwisko);
        }

    }
}
