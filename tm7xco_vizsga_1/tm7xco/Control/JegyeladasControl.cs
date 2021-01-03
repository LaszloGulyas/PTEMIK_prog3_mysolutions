using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tm7xco.Model;

namespace tm7xco.View
{

    public class JegyeladasControl
    {
        private Image szindarabKep;
        private CheckBox rendeles;
        private string szindarabNev;
        private TextBox rendelesDarab;
        private Label darab;
        private const int JEGY_AR = 3300;

        public JegyeladasControl(Szindarab szindarab)
        {
            szindarabKep = Image.FromFile(szindarab.KepFajlnev + ".jpg");
            szindarabNev = szindarab.Cim;
        }
    }
}
