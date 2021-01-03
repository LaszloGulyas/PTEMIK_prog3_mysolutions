using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm7xco.Model
{
    public struct Szerep
    {

        public Szerep(string szerepNev, string szineszNev)
        {
            this.SzerepNev = szerepNev;
            this.SzineszNev = szineszNev;
        }

        public string SzerepNev { get; set; }

        public string SzineszNev { get; set; }
    }
}
