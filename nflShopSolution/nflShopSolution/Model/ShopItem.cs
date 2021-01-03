using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nflShopSolution
{
    public class ShopItem
    {
        public ShopItem(string csapat, string játékosnév, string mezszám, string méret, double beszerzésiÁr, double eladásiÁr, string képfájlNév)
        {
            Csapat = csapat;
            Játékosnév = játékosnév;
            Mezszám = mezszám;
            Méret = méret;
            BeszerzésiÁr = beszerzésiÁr;
            EladásiÁr = eladásiÁr;
            KépfájlNév = képfájlNév;
        }

        public string Csapat { get; private set; }

        public string Játékosnév { get; private set; }

        public string Mezszám { get; private set; }

        public string Méret { get; private set; }

        public double BeszerzésiÁr { get; private set; }

        public double EladásiÁr { get; private set; }

        public string KépfájlNév { get; private set; }

    }
}
