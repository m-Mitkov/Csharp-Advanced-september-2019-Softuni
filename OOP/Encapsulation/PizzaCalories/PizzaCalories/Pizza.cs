using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 1 || value.Length > 15 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough { get; private set; }

        public List<Topping> Toppings { get; private set; }

        public double CalculateCalories()
        {
            double doughCalories = this.Dough.CalculateCalories();
            double toppingCalories = this.toppings.Select(x => x.CalculateCalories()).Sum();

            return doughCalories + toppingCalories;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count + 1 == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }
    }
}
