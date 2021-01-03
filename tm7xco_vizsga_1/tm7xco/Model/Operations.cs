using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm7xco.Model
{
    public class Operations
    {
     
        public static List<Szindarab> ReadFile(string fileName)
        {
            List<Szindarab> beolvasottDarabok = new List<Szindarab>();
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(fileName);
                string[] line1 = null;
                string[] line2 = null;
                string[] line3 = null;

                while (!streamReader.EndOfStream)
                {
                    line1 = streamReader.ReadLine().Split(';');
                    string cim = line1[0];
                    string kepFajlNev = line1[1];
                    int.TryParse(line1[2], out int eladhatoJegyekSzama);

                    line2 = streamReader.ReadLine().Split(':');
                    string szerzoStatusza = line2[0];
                    string szerzoneve = line2[1];

                    line3 = streamReader.ReadLine().Split(';');
                    List<Szerep> szerepek = new List<Szerep>();
                    for (int i=0; i<line3.Length; i++)
                    {
                        string[] szerepAdatok = line3[i].Split(':');
                        szerepek.Add(new Szerep(szerepAdatok[0], szerepAdatok[1]));
                    }

                    beolvasottDarabok.Add(new Szindarab(cim, kepFajlNev, eladhatoJegyekSzama, szerzoStatusza, szerzoneve, szerepek));
                }

                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            catch (Exception e)
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }

                throw e;
            }

            return beolvasottDarabok;
        }
    }
}
