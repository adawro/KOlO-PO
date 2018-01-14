using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    interface IHotel
    {
         void DodajRezerwacje(string imie, string nazwisko, int numerPokoju, double cenaZaDzien);
         void OdwolajRezerwacje();
    }
}
