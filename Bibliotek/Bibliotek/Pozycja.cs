using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja()
        {

        }
        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo=wydawnictwo;
            this.rokWydania = rokWydania;
        }

        public virtual string Opis()
        {
            return $"ID: {id}\nTytul: {tytul}\nWydawnictwo: {wydawnictwo}\nRok wydania {rokWydania}\n";
        }
        public string pobierzTytul()
        {
            return tytul;
        }
        public int pobierzId()
        {
            return id;
        }
    }

}
