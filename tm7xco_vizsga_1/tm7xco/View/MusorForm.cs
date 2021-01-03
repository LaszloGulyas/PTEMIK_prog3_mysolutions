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
    public partial class MusorForm : Form
    {

        private Szinhaz szinhaz;

        public MusorForm(Szinhaz szinhaz)
        {
            this.szinhaz = szinhaz;
            InitializeComponent();
            CenterToScreen();
            InitUI();
        }

        private void InitUI()
        {
            eloadasokListBox.Items.Clear();

            for (int i = 0; i < szinhaz.getSize(); i++)
            {
                eloadasokListBox.Items.Add(szinhaz.getSzindarab(i).Cim);
            }
        }

        private void eloadasokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = eloadasokListBox.SelectedIndex;

            textBoxCim.Text = szinhaz.getSzindarab(index).Cim;
            textBoxIrta.Text = szinhaz.getSzindarab(index).SzerzoNeve;

            szereposztasListBox.Items.Clear();
            List<Szerep> szerepek = szinhaz.getSzindarab(index).Szerepek;
            szerepek.ForEach(item => szereposztasListBox.Items.Add(item.SzerepNev + ":" + item.SzineszNev));

            imageBox.Image = Image.FromFile(szinhaz.getSzindarab(index).KepFajlnev + ".jpg");
        }
    }
}
