using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Program
    {
        

        static void Main(string[] args)
        {
            void menu()
            {
                Console.WriteLine("Aplikacja do zarzadzania katalogiem \nCo chcesz zrobic? Wpisz klawisz i zatwierdz enterem.");
                Console.WriteLine("A - Dodaj czasopismo\nB - Dodaj ksizke\nC - wyszukaj po tytule\nD - wyszukaj po ID\nE - pokaz zawartosc\nF - Czysci konsole\nX - Koniec");
            }

            Katalog Katalog = new Katalog("Nauki Przyrodnicze");
            string komenda =" ";

            string imie, nazwisko, tytul, wydawnictwo;

            int rokWydania, id, liczbaStron,numer;
            Katalog.Test();
            
            menu();
            do
            {
                komenda = Console.ReadLine();
                if (komenda == "A")
                {
                    
                    Console.WriteLine("Podaj tytul");
                    tytul = Console.ReadLine();
                    Console.WriteLine("Podaj ID");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj Wydawnictwo");
                    wydawnictwo= Console.ReadLine();
                    Console.WriteLine("Podaj Rok Wydania");
                    rokWydania= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj numer");
                    numer= Convert.ToInt32(Console.ReadLine());
                    Katalog.DodajPozycje(tytul,id,wydawnictwo,rokWydania,numer);
                    Console.Clear();
                    menu();
                }
                if(komenda=="B")
                {
                    Console.WriteLine("Podaj imie ");
                    imie = Console.ReadLine();
                    Console.WriteLine("Podaj nazwisko ");
                    nazwisko = Console.ReadLine();
                    Console.WriteLine("Podaj tytul");
                    tytul = Console.ReadLine();
                    Console.WriteLine("Podaj ID");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj Wydawnictwo");
                    wydawnictwo = Console.ReadLine();
                    Console.WriteLine("Podaj Rok Wydania");
                    rokWydania = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj liczbe stron ");
                    liczbaStron = Convert.ToInt32(Console.ReadLine());
                    Katalog.DodajPozycje(tytul, id, wydawnictwo, rokWydania,liczbaStron,imie,nazwisko);
                    Console.Clear();
                    menu();
                }
                if(komenda=="C")
                {
                    Console.WriteLine("Podaj tytul ktorego suzkasz.");
                    tytul = Console.ReadLine();
                    Console.WriteLine(Katalog.WyszukajPoTytule(tytul));
                    
                }
                if(komenda=="D")
                {
                    Console.WriteLine("Podaj ID ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Katalog.WyszukajPoID(id));
                    
                }

                if (komenda == "E")
                    Console.Write(Katalog.WypiszWszystko());
                if (komenda == "F")
                {
                    Console.Clear();
                    menu();
                }
                 
            } while (komenda != "X");

            
          





            
        }
    }
}
