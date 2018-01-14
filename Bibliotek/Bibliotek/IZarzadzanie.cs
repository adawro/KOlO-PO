using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    interface IZarzadzanie
    {
        string WyszukajPoTytule(string tytul);
        string WyszukajPoID(int id);
        string WypiszWszystko();


    }
}
