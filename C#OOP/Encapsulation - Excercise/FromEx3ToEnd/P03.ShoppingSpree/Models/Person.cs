using P03.ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        private Person()
        {
            this.bag = new List<Product>();
        }
        public Person(string name , decimal money) 
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyException);
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get
            {
                return this.bag;
                ///asReadOnly
            }
        }

        public void BuyProduct(Product product)
        {
            if(this.Money < product.Cost)
            {   
                throw new InvalidCastException($"{this.Name} can't afford {product.Name}");
            }
            else
            {
               // Console.WriteLine($"{this.Name} bought {this.Name}");
                this.Money -= product.Cost;
                this.bag.Add(product);
                
            }
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ?
                String.Join(", ", this.Bag) : "Nothing bought";


            return $"{this.Name} - {productsOutput}";
        }

    }
}
