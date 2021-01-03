using nflShopSolution.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nflShopSolution
{
    public partial class MainForm : Form
    {

        private readonly Shop shop = new Shop();
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void openFileStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFile();
        }  //OpenFile browser

        private void ReadFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = null;
                try
                {
                    streamReader = new StreamReader(openFileDialog1.FileName);
                    string[] line = null;

                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine().Split(';');
                        if (line.Length == 7)
                        {
                            string csapat = line[0];
                            string játékosnév = line[1];
                            string mezszám = line[2];
                            string méret = line[3];
                            double.TryParse(line[4], out double beszerzésiÁr);
                            double.TryParse(line[5], out double eladásiÁr);
                            string képfájlNév = line[6];

                            ShopItem currentItem = new ShopItem(csapat, játékosnév, mezszám, méret, beszerzésiÁr, eladásiÁr, képfájlNév);
                            shop.AddItem(currentItem);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("A fájl olvasása során hiba keletkezett!" + Environment.NewLine + e.Message, "Hiba");
                }
                finally
                {
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }
                }
            }
        }  //adat beolvasása txt fileból

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "2020.12.19\nTM7XCO",
                "Névjegy",
                MessageBoxButtons.OK);
        }  //about névjegy

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        } //exit gomb

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var exiting = MessageBox.Show(
                            "Biztosan ki akar lépni?",
                            "Figyelem",
                            MessageBoxButtons.YesNo);

            if (exiting != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        } //confirm exit dialog felugrik


        private void printMsg(string msg)
        {
            MessageBox.Show(msg, "ConsoleAlert");
        }

        private void kettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(shop);

            Hide();
            orderForm.ShowDialog();
            Show();
        }

        private void könyvelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountingForm accountingForm = new AccountingForm(shop);

            Hide();
            accountingForm.ShowDialog();
            Show();
        }
    }
}
