using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBar
{
    internal class Item
    {
        /// <summary>
        /// The name of the Item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The price of the Item
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Constructor with Name of item and the its corresponding price
        /// </summary>
        /// <param name="name">The name of the item to be sold</param>
        /// <param name="price">The price of the item</param>
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
