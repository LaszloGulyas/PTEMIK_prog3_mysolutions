using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm7xco.Model
{
    public class Phone
    {
        private const int DEFAULT_STOCK = 30;

        public Phone(string name, int price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.stock = DEFAULT_STOCK;
        }

        public string name { get; private set; }

        public int price { get; private set; }

        public string description { get; private set; }

        public int stock { get; set; }
    }
}
