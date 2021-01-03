using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tm7xco.Model;
using tm7xco.View;

namespace tm7xco.Control
{
    class PhoneControl
    {

        private const int BASE_POS_X = 5;
        private const int SPACING_Y = 70;


        private Phone phone;
        private OffersForm offersForm;

        private Label name;
        private Label description;
        private Label price;
        private TextBox orderCount;
        private Label db;

        public PhoneControl(Phone phone, OffersForm offersForm, Panel panel, int y)
        {
            this.phone = phone;
            this.offersForm = offersForm;

            int posX = BASE_POS_X;
            int basePosY = y * SPACING_Y;
            int posY = 0;

            name = new Label();
            name.Text = phone.name;
            name.Width = 250;
            name.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            posY = basePosY + (SPACING_Y - name.Size.Height) / 2;
            name.Location = new Point(posX, posY);
            panel.Controls.Add(name);

            posX += 260;

            description = new Label();
            description.Text = phone.description;
            description.Width = 230;
            description.AutoSize = false;
            description.Height = 60;
            description.BackColor = Color.Silver;
            description.TextAlign = ContentAlignment.MiddleCenter;
            posY = basePosY;
            description.Location = new Point(posX, posY);
            panel.Controls.Add(description);

            posX += 250;

            price = new Label();
            price.Text = phone.price.ToString("#,##0 Ft");
            price.Width = 60;
            posY = basePosY + (SPACING_Y - price.Size.Height) / 2;
            price.Location = new Point(posX, posY);
            panel.Controls.Add(price);

            posX += 70;

            orderCount = new TextBox();
            orderCount.Width = 60;
            posY = basePosY + (SPACING_Y - orderCount.Size.Height - 10) / 2;
            orderCount.Location = new Point(posX, posY);
            panel.Controls.Add(orderCount);

            posX += 70;

            db = new Label();
            db.Text = "db";
            db.Width = 20;
            posY = basePosY + (SPACING_Y - db.Size.Height) / 2;
            db.Location = new Point(posX, posY);
            panel.Controls.Add(db);
        }

        public Phone GetPhone()
        {
            return phone;
        }

        public string GetOrderCount()
        {
            return orderCount.Text;
        }

        public void ClearCount()
        {
            orderCount.Text = "";
        }

        public void UpdateStatus()
        {
            if (phone.stock <= 0)
            {
                name.Enabled = false;
                description.Enabled = false;
                price.Enabled = false;
                orderCount.Enabled = false;
                db.Enabled = false;
            }
            else
            {
                name.Enabled = true;
                description.Enabled = true;
                price.Enabled = true;
                orderCount.Enabled = true;
                db.Enabled = true;
            }
        }
    }
}
