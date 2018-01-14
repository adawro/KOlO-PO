using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace przychodnia
{
    class Przychodnia:IPrzychodnia
    {
        private Lekarz lekarz;
        private Queue<Pacjent> pacjenci = new Queue<Pacjent>();

        public void UstawLekarza(string imie, string nazwisko, string specjalnosc)
        {
             lekarz = new Lekarz(imie, nazwisko, specjalnosc);
        }
        
        public int CzasOczekiwania()
        {
            return  pacjenci.Count() / 4;
        }

        public void DodajDoKolejki(string imie, string nazwisko, int wiek, string choroba)
        {
            pacjenci.Enqueue(new Pacjent(imie, nazwisko, wiek, choroba));
        }

        public void GenerujRaport()
        {
            DateTime data;
            data = DateTime.Now.Year;


            string path = "C:\\20180114135.txt";




            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(ToString());

            }
            
        }

        public string WykonajBadanie()
        {
            return $"Wykonano Badanie: {String.Format(pacjenci.Peek().ToString())}";
        }

        public string WykonajPorade()
        {

            return $"Wykonano Porade: {String.Format(pacjenci.Dequeue().ToString())}";
        }

        public override string ToString()
        {
            string wynik = "";
            if (pacjenci.Count() == 0)
            {
                wynik = "Kolejka jest Pusta";
                return $"Lekarz {lekarz.ToString()}\n{wynik}";
            }
            else
            {
                foreach (var e in pacjenci)
                {
                    wynik += e.ToString() + Environment.NewLine;
                }
                return $"\nLekarz {lekarz.ToString()}"+Environment.NewLine+$"{wynik}";
            }
        }
        public bool CzyLekarz()
        {
            if (lekarz == null)
                return false;
            else
                return true;
        }
    }
}
