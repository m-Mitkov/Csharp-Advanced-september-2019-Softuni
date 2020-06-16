using System;
using System.Collections.Generic;
using System.Linq;

namespace shoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }
        public decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public bool BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                products.Add(product);
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            if (this.products.Count != 0)
            {
                return $"{this.name} - {string.Join(", ", this.products.Select(x => x.Name))}";
            }

            else
            {
                return $"{this.name} - Nothing bought";
            }
        }
    }
}
