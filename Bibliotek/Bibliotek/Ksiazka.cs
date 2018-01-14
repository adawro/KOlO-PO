using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Ksiazka: Pozycja
    {
        private int liczbaStron;
        private Autor autor = new Autor();
        public Ksiazka() { }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string imie, string nazwisko )
            :base (tytul, id,wydawnictwo,rokWydania)
        {
            this.liczbaStron = liczbaStron;
            autor.Imie = imie;
            autor.Nazwisko = nazwisko;
        }
        public override string Opis()
        {
            return $"ID: {id}\nTytul: {tytul}\nAutor {autor.Imie} {autor.Nazwisko} \nWydawnictwo: {wydawnictwo}\nRok wydania {rokWydania}\n";
        }
        public void wypiszAutor()
        {
            autor.wypiszInfo();
        }
    }
}
