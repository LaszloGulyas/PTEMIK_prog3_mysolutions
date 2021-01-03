using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nflShopSolution
{
    public class Shop
    {
        private readonly List<ShopItem> shopItems;
        private readonly List<Order> orders;

        public Shop()
        {
            shopItems = new List<ShopItem>();
            orders = new List<Order>();
        }

        public void AddItem(ShopItem newItem)
        {
            shopItems.Add(newItem);
        }

        public ShopItem FindItemById(int id)
        {
            return shopItems[id];
        }

        public int GetItemCount()
        {
            return shopItems.Count;
        }

        public void RegisterOrder(Order order)
        {
            orders.Add(order);
        }

        public int GetOrdersCount()
        {
            return orders.Count();
        }

        public double GetTotalBeszerzesiAr()
        {
            double sum = 0;

            foreach (Order order in orders)
            {
                sum += order.GetTotalBeszerÁr();
            }

            return sum;
        }

        public double GetTotalEladasiAr()
        {
            double sum = 0;

            foreach (Order order in orders)
            {
                sum += order.GetTotalEladásiÁr();
            }

            return sum;
        }

        public double GetTotalProfit()
        {
            return GetTotalEladasiAr() - GetTotalBeszerzesiAr();
        }
    }
}
