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
using tm7xco.Model;
using tm7xco.View;

namespace tm7xco
{
    public partial class MainForm : Form
    {
        private readonly Shop shop;

        public MainForm()
        {
            shop = new Shop();

            InitializeComponent();
            CenterToScreen();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var exiting = MessageBox.Show(
                            "Biztosan ki szeretne lépni?",
                            "Kilépés",
                            MessageBoxButtons.YesNo);

            if (exiting != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool successfulRead = Readfile();

            if (successfulRead)
            {
                ajánlatokToolStripMenuItem.Enabled = true;
                megnyitásToolStripMenuItem.Enabled = false;
            }
        }

        private bool Readfile()
        {
            bool successfulRead = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = null;
                try
                {
                    streamReader = new StreamReader(openFileDialog1.FileName);
                    string[] line1 = null;
                    string line2 = null;

                    while (!streamReader.EndOfStream)
                    {
                        line1 = streamReader.ReadLine().Split(';');
                        line2 = streamReader.ReadLine();

                        string name = line1[0];
                        int.TryParse(line1[1], out int price);
                        string description = line2;

                        Phone phone = new Phone(name, price, description);
                        shop.AddPhone(phone);

                    }
                    successfulRead = true;
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

            return successfulRead;
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "GL\nTM7XCO",
                "Névjegy",
                MessageBoxButtons.OK);
        }

        private void ajánlatokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OffersForm offersForm = new OffersForm(shop, this);

            Hide();
            offersForm.ShowDialog();
            Show();
        }

        public void UpdateIncome()
        {
            int totalIncome = shop.GetTotalIncome();

            if (totalIncome > 0)
            {
                labelTotalIncome.Text = totalIncome.ToString("#,##0 Ft");
            }
        }
    }
}
