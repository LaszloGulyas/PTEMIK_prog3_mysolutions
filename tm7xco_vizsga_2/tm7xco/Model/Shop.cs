using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm7xco.Model
{
    public class Shop
    {
        private readonly List<Phone> phones;
        private readonly List<Order> orders;

        public static readonly int ORDER_PRICE = 2099;

        public Shop()
        {
            phones = new List<Phone>();
            orders = new List<Order>();
        }

        public void AddPhone(Phone phone)
        {
            phones.Add(phone);
        }

        public int GetItemCount()
        {
            return phones.Count();
        }

        public Phone FindById(int id)
        {
            return phones[id];
        }

        public void RegisterOrder(Order order)
        {
            orders.Add(order);
        }

        public int GetTotalIncome()
        {
            int sum = 0;

            foreach (Order order in orders)
            {
                sum += order.GetTotalCost();
            }

            return sum;
        }
    }
}
