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
using tm7xco.View;

namespace tm7xco
{
    public partial class MainForm : Form
    {
        private Szinhaz szinhaz;

        public MainForm()
        {
            this.szinhaz = new Szinhaz();
            InitializeComponent();
            CenterToScreen();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "Gulyás László\nTM7XCO",
           "Névjegy",
           MessageBoxButtons.OK);
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    szinhaz.addAll(Operations.ReadFile(openFileDialog1.FileName));
                }
                catch (Exception er)
                {
                    MessageBox.Show("A fájl olvasása során hiba keletkezett!" + Environment.NewLine + er.Message, "Hiba");
                }
            }

            műsorToolStripMenuItem.Enabled = true;
            jegyeladásToolStripMenuItem.Enabled = true;
            megnyitásToolStripMenuItem.Enabled = false;
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var exiting = MessageBox.Show("Biztosan ki akar lépni?", "Kilépés megerősítése", MessageBoxButtons.YesNo);

            if (exiting != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void műsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusorForm musorForm = new MusorForm(szinhaz);

            Hide();
            musorForm.ShowDialog();
            Show();
        }

        private void jegyeladásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JegyeladasForm jegyeladasForm = new JegyeladasForm(szinhaz);

            Hide();
            jegyeladasForm.ShowDialog();
            Show();
        }
    }
}
