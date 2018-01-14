using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Przychodnia przychodnia = new Przychodnia();
            
            przychodnia.UstawLekarza("Stefan", "Czerwony", "Onkolog");
            if (przychodnia.CzyLekarz())
            {
                przychodnia.DodajDoKolejki("jeden", "JEDEN", 12, "RAK");
                przychodnia.DodajDoKolejki("dwa", "asd", 12, "RAK");
               
                Console.WriteLine(przychodnia.CzasOczekiwania());
                Console.WriteLine(przychodnia.ToString());
                przychodnia.GenerujRaport();
            }
            else
                Console.WriteLine("Nie ma lekarza");
            Console.ReadKey();
        }
    }
}
