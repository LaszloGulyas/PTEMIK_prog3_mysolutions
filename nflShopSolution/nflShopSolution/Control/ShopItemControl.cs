using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nflShopSolution
{
    class ShopItemControl
    {

        private const int BASE_POS_X = 5;
        private const int SPACING_Y = 70;
        private const int IMG_WIDTH = 50;

        private ShopItem shopItem;
        private OrderForm orderForm;

        private PictureBox teamImage;
        private Label csapat;
        private Label játékosnév;
        private Label mezszám;
        private Label méret;
        private Label eladásiÁr;
        private CheckBox ordering;
        private TextBox orderCount;

        public ShopItemControl(ShopItem shopItem, OrderForm orderForm, Panel panel, int y)
        {
            this.shopItem = shopItem;
            this.orderForm = orderForm;
            int posX = BASE_POS_X;
            int basePosY = y * SPACING_Y;
            int posY = 0;

            teamImage = new PictureBox();
            teamImage.Width = IMG_WIDTH;
            teamImage.Image = Image.FromFile(shopItem.KépfájlNév);
            teamImage.SizeMode = PictureBoxSizeMode.StretchImage;
            posY = basePosY + (SPACING_Y - teamImage.Size.Height) / 2;
            teamImage.Location = new Point(posX, posY);
            panel.Controls.Add(teamImage);

            posX += IMG_WIDTH;
            posX += 20;

            csapat = new Label();
            csapat.Text = shopItem.Csapat;
            posY = basePosY + (SPACING_Y - csapat.Size.Height) / 2;
            csapat.Location = new Point(posX, posY);
            csapat.AutoSize = true;
            panel.Controls.Add(csapat);

            posX += 80;

            játékosnév = new Label();
            játékosnév.Text = shopItem.Játékosnév;
            játékosnév.Location = new Point(posX, posY);
            játékosnév.AutoSize = true;
            panel.Controls.Add(játékosnév);

            posX += 100;

            mezszám = new Label();
            mezszám.Text = "#" + shopItem.Mezszám;
            mezszám.Location = new Point(posX, posY);
            mezszám.AutoSize = true;
            panel.Controls.Add(mezszám);

            posX += 40;

            méret = new Label();
            méret.Text = shopItem.Méret;
            méret.Location = new Point(posX, posY);
            méret.AutoSize = true;
            panel.Controls.Add(méret);

            posX += 50;

            eladásiÁr = new Label();
            eladásiÁr.Text = shopItem.EladásiÁr.ToString("$0.00");
            eladásiÁr.Location = new Point(posX, posY);
            eladásiÁr.AutoSize = true;
            panel.Controls.Add(eladásiÁr);

            posX += 50;

            ordering = new CheckBox();
            posY = basePosY + (SPACING_Y - ordering.Size.Height) / 2;
            ordering.Location = new Point(posX, posY);
            ordering.AutoSize = true;
            ordering.CheckedChanged += ordering_CheckedChanged;
            panel.Controls.Add(ordering);

            posX += 25;

            orderCount = new TextBox();
            orderCount.Width = 40;
            posY = basePosY + (SPACING_Y - orderCount.Size.Height - 10) / 2;
            orderCount.Location = new Point(posX, posY);
            orderCount.TextChanged += orderCount_TextChanged;
            panel.Controls.Add(orderCount);

            posX += 50;

            Label darabStaticText = new Label();
            darabStaticText.Text = "db";
            posY = basePosY + (SPACING_Y - darabStaticText.Size.Height) / 2;
            darabStaticText.Location = new Point(posX, posY);
            darabStaticText.AutoSize = true;
            panel.Controls.Add(darabStaticText);
        }

        private void orderCount_TextChanged(object sender, EventArgs e)
        {
            orderForm.UpdateOrderSum();
        }

        private void ordering_CheckedChanged(object sender, EventArgs e)
        {
            orderForm.UpdateOrderSum();
        }

        public bool IsOrderingChecked()
        {
            return ordering.Checked;
        }

        public int GetOrderCount()
        {
            int.TryParse(orderCount.Text, out int result);
            return result;
        }

        public double GetEladasiAr()
        {
            return shopItem.EladásiÁr;
        }

        public ShopItem GetShopItem()
        {
            return shopItem;
        }
    }
}
