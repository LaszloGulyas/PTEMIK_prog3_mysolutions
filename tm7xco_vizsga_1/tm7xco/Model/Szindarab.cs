using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm7xco.Model
{
    public class Szindarab
    {



        public string Cim { get; private set; }

        public string KepFajlnev { get; private set; }

        public int EladhatoJegyekSzama { get; private set; }

        public string SzerzoStatusza { get; private set; }

        public string SzerzoNeve { get; private set; }

        public List<Szerep> Szerepek { get; private set; }

        public Szindarab(string cim, string kepFajlnev, int eladhatoJegyekSzama, string szerzoStatusza, string szerzoNeve, List<Szerep> szerepek)
        {
            Cim = cim;
            KepFajlnev = kepFajlnev;
            EladhatoJegyekSzama = eladhatoJegyekSzama;
            SzerzoStatusza = szerzoStatusza;
            SzerzoNeve = szerzoNeve;
            Szerepek = szerepek;
        }
    }
}
