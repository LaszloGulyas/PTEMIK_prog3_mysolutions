using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tm7xco.Model;

namespace tm7xco.View
{
    public partial class JegyeladasForm : Form
    {
        private Szinhaz szinhaz;
        private List<JegyeladasControl> jegyeladasControls;

        public JegyeladasForm(Szinhaz szinhaz)
        {
            this.szinhaz = szinhaz;
            this.jegyeladasControls = new List<JegyeladasControl>();

            InitializeComponent();
            CenterToScreen();
        }

        private void InitUI()
        {
            // generalnia kellene model szerint a controlokat
        }

        private void buttonJegyvasarlas_Click(object sender, EventArgs e)
        {
            //rendeles funkcio implementalasa
        }

        private void ClearUI()
        {
            //vásárlás után reseteli a UI elemeket
        }
    }
}
