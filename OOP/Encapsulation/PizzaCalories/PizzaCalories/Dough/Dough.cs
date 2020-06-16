using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Dough
    {
        private const int baseCalories = 2;

        private string flourType;
        private double weight;
        private string bakingTechnique;
        private Dictionary<string, double> typeFlourAndCalories;
        private Dictionary<string, double> bakingTechniqueAndCalories;

        public Dough(string flour, string bakingTechnique, double weight)
        {
            this.typeFlourAndCalories = new Dictionary<string, double>();
            FillFlourTypesAndCalories(typeFlourAndCalories);

            this.bakingTechniqueAndCalories = new Dictionary<string, double>();
            FillBakingTechniqueCalories(bakingTechniqueAndCalories);

            this.FlourType = flour.ToLower();
            this.BakingTechnique = bakingTechnique.ToLower();
            this.Weight = weight;


        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (!typeFlourAndCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (!bakingTechniqueAndCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double caloriesFlourType = typeFlourAndCalories[this.FlourType.ToLower()];
            double calorierBakingTechnique = bakingTechniqueAndCalories[this.BakingTechnique.ToLower()];

            double calories = (this.weight * baseCalories) * caloriesFlourType * calorierBakingTechnique;

            return calories;
        }
        private void FillFlourTypesAndCalories(Dictionary<string, double> flourAndCalories)
        {
            flourAndCalories.Add("white", 1.5);
            flourAndCalories.Add("wholegrain", 1.0);
        }

        private void FillBakingTechniqueCalories(Dictionary<string, double> bakingTechnique)
        {
            bakingTechnique.Add("crispy", 0.9);
            bakingTechnique.Add("chewy", 1.1);
            bakingTechnique.Add("homemade", 1.0);
        }
    }
}
