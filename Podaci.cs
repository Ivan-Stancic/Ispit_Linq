using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        public List<Banka> ListaBanki = new List<Banka>()
        {
            new Banka { Naziv = "Zagrebacka Banka", Simbol = "ZABA" },
            new Banka { Naziv = "Hrvatska Postanska Banka", Simbol = "HPB" },
            new Banka { Naziv = "ReiffeisenBank Hrvatska", Simbol = "RBA" },
        };

        public List<Klijent> ListaKlijenata = new List<Klijent>()
        {
            new Klijent { ImePrezime = "Ivo Ivić", Stanje = 100000, Simbol = "ZABA" },
            new Klijent { ImePrezime = "Ante antić", Stanje = 10000000, Simbol = "HPB" },
            new Klijent { ImePrezime = "Marko Markić", Stanje = 100000, Simbol = "HPB" },
            new Klijent { ImePrezime = "Pero Perič", Stanje = 100000, Simbol = "ZABA" },
            new Klijent { ImePrezime = "Jan Janić", Stanje = 100000, Simbol = "HPB" },
            new Klijent { ImePrezime = "Karla Karlić", Stanje = 100000, Simbol = "RBA" },
            new Klijent { ImePrezime = "Marija Marić", Stanje = 10000000, Simbol = "RBA" },
            new Klijent { ImePrezime = "Štefa Štefić", Stanje = 100000, Simbol = "HPB" },
            new Klijent { ImePrezime = "Branko Brankić", Stanje = 100000, Simbol = "RBA" },
            new Klijent { ImePrezime = "Mujo Mujić", Stanje = 10000000, Simbol = "ZABA" },
        };

    }
}
