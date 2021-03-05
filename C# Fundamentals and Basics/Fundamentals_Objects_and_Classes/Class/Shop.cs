using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Shop
    {
        public List<string> Items { get; set; }

        public decimal Price { get; set; }
       
        public decimal TotalPrice 
        {
            get
            {
                return this.Items.Count * Price;
            }

            // return this.Item
        }

    }
}
