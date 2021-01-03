using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nflShopSolution
{
    public class Order
    {
        private Dictionary<ShopItem, int> productToCount;

        public Order()
        {
            productToCount = new Dictionary<ShopItem, int>();
        }

        public void AddItem(ShopItem item, int count)
        {
            productToCount.Add(item, count);
        }

        public double GetTotalBeszerÁr()
        {
            double sum = 0;

            foreach (ShopItem shopItem in productToCount.Keys)
            {
                productToCount.TryGetValue(shopItem, out int count);
                sum += shopItem.BeszerzésiÁr * count;
            }

            return sum;
        }

        public double GetTotalEladásiÁr()
        {
            double sum = 0;

            foreach (ShopItem shopItem in productToCount.Keys)
            {
                productToCount.TryGetValue(shopItem, out int count);
                sum += shopItem.EladásiÁr * count;
            }

            return sum;
        }

        public double GetTotalProfit()
        {
            return GetTotalEladásiÁr() - GetTotalBeszerÁr();
        }

        public int GetCountOfItems()
        {
            return productToCount.Count();
        }
    }
}
