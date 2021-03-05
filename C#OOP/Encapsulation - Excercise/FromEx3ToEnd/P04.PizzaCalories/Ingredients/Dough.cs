using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace P04.PizzaCalories.Ingredients
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private const double caloriesPerGram = 2;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if(value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
                
            }
        }
        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if(value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }
        public double DoughCalories()
        {
            double flourModifier = 0;
            double bakingModifier = 0;

            flourModifier = FindFlourModifier();
            bakingModifier = FindBakingModifier();

            return caloriesPerGram * this.Weight * flourModifier * bakingModifier;
        }

        private double FindFlourModifier()
        {
            double flourModifier = 0;
            if (this.FlourType.ToLower() == "white")
            {
                flourModifier = 1.5;
            }
            else if(this.FlourType.ToLower() == "wholegrain")
            {
                flourModifier = 1;
            }

            return flourModifier;
        }

        private double FindBakingModifier()
        {
            double bakingModifier;
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                bakingModifier = 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                bakingModifier = 1.1;
            }
            else
            {
                bakingModifier = 1.0;
            }

            return bakingModifier;
        }
    }
}
