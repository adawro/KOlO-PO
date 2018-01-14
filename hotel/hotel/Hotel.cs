using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Hotel : IHotel, IData
    {
        private double zysk;
        private DateTime data;
        private SortedDictionary<Pokoj, Gosc> rezerwacje = new SortedDictionary<Pokoj, Gosc>();
        public Hotel()
        {
            zysk = -80;
        }
        public void DodajRezerwacje(string imie, string nazwisko, int numerPokoju, double cenaZaDzien)
        {
            rezerwacje.Add(new Pokoj(numerPokoju, cenaZaDzien), new Gosc(imie, nazwisko));
            zysk += cenaZaDzien;
        }

        public void OdwolajRezerwacje()
        {
            rezerwacje.Remove(rezerwacje.Last().Key);
        }

        public bool SprawdzDate()
        {
            if (data > DateTime.Now)
                return true;
            else return false;
        }

        public void UstawDate(DateTime data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            string opis = $"Rezerwacje:\n";
            foreach (var e in rezerwacje)
            {
                opis += String.Format($"[{e.Key.ToString()}; {e.Value.ToString()}]\n");
            }
            opis += String.Format($"Zysk: {zysk}");
            return $"Data {data.ToShortDateString()} {opis}";
        }
        public int IloscRezerwacji()
        {
            return rezerwacje.Count;
        }
    }
}
