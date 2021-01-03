using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm7xco.Model
{
    public class Order
    {
        private Dictionary<Phone, int> phoneToCount;

        public Order()
        {
            phoneToCount = new Dictionary<Phone, int>();
        }

        public void addOrder(Phone phone, int count)
        {
            phoneToCount.Add(phone, count);
        }

        public void updateStock()
        {
            foreach (Phone phone in phoneToCount.Keys)
            {
                phoneToCount.TryGetValue(phone, out int orderCount);
                phone.stock = phone.stock - orderCount;
            }
        }

        public int GetTotalCost()
        {
            int sum = 0;

            foreach (Phone phone in phoneToCount.Keys)
            {
                var exist = phoneToCount.TryGetValue(phone, out int orderCount);
                if (exist)
                {
                    sum += orderCount * phone.price;
                }
            }

            if (sum > 0)
            {
                sum += Shop.ORDER_PRICE;
            }

            return sum;
        }
    }
}
