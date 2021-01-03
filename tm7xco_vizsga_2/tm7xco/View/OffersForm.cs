using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tm7xco.Control;
using tm7xco.Model;

namespace tm7xco.View
{
    public partial class OffersForm : Form
    {

        private Shop shop;
        private List<PhoneControl> phoneControls = new List<PhoneControl>();
        private MainForm mainForm;

        public OffersForm(Shop shop, MainForm mainForm)
        {
            this.shop = shop;
            this.mainForm = mainForm;

            InitializeComponent();
            CenterToScreen();
            InitUI();
        }

        private void InitUI()
        {
            phoneContainer.Controls.Clear();

            for (int i = 0; i < shop.GetItemCount(); i++)
            {
                phoneControls.Add(new PhoneControl(shop.FindById(i), this, phoneContainer, i));
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var ordering = MessageBox.Show(
                            "Véglegesíti rendelését?\nRendelés összege: " + GetTotalOrderCost() + " Ft",
                            "Megerősítés",
                            MessageBoxButtons.YesNo);

            if (ordering == DialogResult.Yes)
            {
                MakeOrder();
            }
        }

        private int GetTotalOrderCost()
        {
            int sum = 0;

            foreach (PhoneControl phoneControl in phoneControls)
            {
                int.TryParse(phoneControl.GetOrderCount(), out int amount);

                sum += amount * phoneControl.GetPhone().price;
            }

            if (sum > 0)
            {
                sum += Shop.ORDER_PRICE;
            }

            return sum;
        }

        private void MakeOrder()
        {
            Order order = new Order();

            foreach (PhoneControl phoneControl in phoneControls)
            {
                string userInput = phoneControl.GetOrderCount();
                Phone phone = phoneControl.GetPhone();

                var isNumeric = int.TryParse(userInput, out int orderCount);

                if (isNumeric == false && userInput != "")
                {
                    MessageBox.Show(
                        "A bevitt adatok formátuma helytelen!",
                        "Hiba");
                    return;
                } 

                if (orderCount < 0)
                {
                    MessageBox.Show(
                        "A rendelt nem lehet negatív!",
                        "Hiba");
                    return;
                }

                if (orderCount > phone.stock)
                {
                    MessageBox.Show(
                        "A rendelt mennyiség nem áll rendelkezésre!",
                        "Hiba");
                    return;
                }

                order.addOrder(phone, orderCount);
            }



            order.updateStock();
            shop.RegisterOrder(order);

            foreach (PhoneControl phoneControl in phoneControls)
            {
                phoneControl.ClearCount();
                phoneControl.UpdateStatus();
            }

            mainForm.UpdateIncome();
        }


    }
}
