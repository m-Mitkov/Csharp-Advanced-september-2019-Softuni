using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Topping
    {
        private const int maxGramsTopping = 50;
        private const int baseCalories = 2;

        Dictionary<string, double> typeToppingAndCalories;
        string toppingType;
        double toppingWeight;

        public Topping(string toppingType, double toppingInGrams)
        {
            this.typeToppingAndCalories = new Dictionary<string, double>();
            FillCaloriesPerTopping(typeToppingAndCalories);

            this.ToppingType = toppingType;
            this.ToppingWeight = toppingInGrams;
        }

        public string ToppingType
        {
            get => this.toppingType;
            set
            {
                if (!typeToppingAndCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }
        public double ToppingWeight
        {
            get => this.toppingWeight;
            set
            {
                if (value < 0 || value > maxGramsTopping)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }

                this.toppingWeight = value;
            }
        }

        public double CalculateCalories()
        {
            var currentTopping = typeToppingAndCalories.FirstOrDefault(x => x.Key == this.ToppingType.ToLower());
            double grams = this.ToppingWeight;

            double calories = (grams * baseCalories) * currentTopping.Value;

            return calories;
        }
        private static void FillCaloriesPerTopping(Dictionary<string, double> typeToppingAndCalories)
        {
            typeToppingAndCalories.Add("meat", 1.2);
            typeToppingAndCalories.Add("veggies", 0.8);
            typeToppingAndCalories.Add("cheese", 1.1);
            typeToppingAndCalories.Add("sauce", 0.9);
        }
    }
}
