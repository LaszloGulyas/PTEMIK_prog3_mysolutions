using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm7xco.Model
{
    public class Szinhaz
    {
        private List<Szindarab> szindarabok;

        public Szinhaz()
        {
            this.szindarabok = new List<Szindarab>();
        }

        public void addNewSzindarab(Szindarab szindarab)
        {
            szindarabok.Add(szindarab);
        }

        public void addAll(List<Szindarab> szindarabokBulk)
        {
            for (int i = 0; i < szindarabokBulk.Count; i++)
            {
                addNewSzindarab(szindarabokBulk[i]);
            }
        }

        public int getSize()
        {
            return szindarabok.Count();
        }

        public Szindarab getSzindarab(int i)
        {
            return szindarabok[i];
        }
    }
}
