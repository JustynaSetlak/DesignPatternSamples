using Decorator.Pizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizza
{
    public class BasePizza : IPizza
    {
        public double Cost { get; set; }
        public List<string> Ingredients { get; set; }

        public BasePizza()
        {
            Cost = 20;
            Ingredients = new List<string> { "cheese" };
        }

        public double CalculateCost()
        {
            return Cost;
        }

        public List<string> getIngredients()
        {
            return Ingredients;
        }
    }
}
