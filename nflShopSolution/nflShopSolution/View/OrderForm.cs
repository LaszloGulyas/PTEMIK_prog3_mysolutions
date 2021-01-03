using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace nflShopSolution
{
    public partial class OrderForm : Form
    {

        private const double ORDERSUM_DEFAULT_VALUE = 0.00;
        private const string FORMAT_DOUBLE_USD = "$0.00";

        private Shop shop;
        private List<ShopItemControl> shopItemControls = new List<ShopItemControl>();

        public OrderForm(Shop shop)
        {
            this.shop = shop;

            InitializeComponent();
            CenterToScreen();
            InitUI();
        }

        private void InitUI()
        {
            ordersContainer.Controls.Clear();

            for (int i = 0; i < shop.GetItemCount(); i++)
            {
                int y = i;
                shopItemControls.Add(new ShopItemControl(shop.FindItemById(i), this, ordersContainer, y));
            }

            labelOrderSum.Text = ORDERSUM_DEFAULT_VALUE.ToString(FORMAT_DOUBLE_USD);
        }

        public void UpdateOrderSum()
        {
            double orderSum = 0;

            foreach (ShopItemControl shopItemControl in shopItemControls)
            {
                bool ordering = shopItemControl.IsOrderingChecked();
                int orderCount = shopItemControl.GetOrderCount();
                double price = shopItemControl.GetEladasiAr();

                orderSum += ordering ? orderCount * price : 0;
            }

            labelOrderSum.Text = orderSum.ToString(FORMAT_DOUBLE_USD);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            foreach (ShopItemControl shopItemControl in shopItemControls)
            {
                bool isOrdered = shopItemControl.IsOrderingChecked();
                int orderCount = shopItemControl.GetOrderCount();

                if (isOrdered && orderCount > 0)
                {
                    order.AddItem(shopItemControl.GetShopItem(), orderCount);
                }
            }

            if (order.GetCountOfItems() > 0)
            {
                shop.RegisterOrder(order);
            }

            Close();
        }
    }
}
