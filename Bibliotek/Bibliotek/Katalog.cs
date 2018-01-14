using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Katalog:IZarzadzanie
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje;

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
            pozycje = new List<Pozycja>();
        }
        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            pozycje.Add(new Czasopismo(tytul, id, wydawnictwo, rokWydania, numer));
        }

        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string imie, string nazwisko)
        {
            pozycje.Add(new Ksiazka(tytul, id, wydawnictwo, rokWydania, liczbaStron, imie, nazwisko));
        }

        public string WypiszWszystko()
        {
            string wszystko = dzialTematyczny.ToUpper() + Environment.NewLine;
            foreach (var e in pozycje)
            {
                wszystko += e.Opis() + Environment.NewLine;
            }
            return wszystko;
        }

        public string WyszukajPoID(int id)
        {
            string temp = "";
            foreach (var e in pozycje)
            {
                if (e.pobierzId() == id)
                    temp = e.Opis();
                else temp = "Nie ma takiejpozycji.";
            }
            return temp;
        }

        public string WyszukajPoTytule(string tytul)
        {
            string temp="";
            foreach (var e in pozycje)
            {
                if (e.pobierzTytul() == tytul)
                    temp = e.Opis();
                else
                    temp = "Nie ma takiej pozycji";
            }
            return temp;
        }
        public void Test()
        {
            DodajPozycje("Gazeta Olsztyńska", 200, "Edytor", 1992, 7);
            DodajPozycje("Gazeta Wyborcza", 123, "Agora", 2010, 23);
            DodajPozycje("Krzyżacy", 220, "Znak", 2010, 300, "Henryk", "Sienkiewicz");
            DodajPozycje("Krzyżacy", 221, "Znak", 2011, 298, "Henryk", "Sienkiewicz");
        }
    }
}
