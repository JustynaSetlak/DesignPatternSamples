using Decorator.Pizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizza
{
    public class HawaiiPizza : IPizza
    {
        private readonly IPizza _pizzaToBeDecorated;
        public double Cost { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();

        public HawaiiPizza(IPizza pizza)
        {
            _pizzaToBeDecorated = pizza;
            AddIngredient();
        }

        public double CalculateCost()
        {
            Cost = _pizzaToBeDecorated.CalculateCost() + 3;
            return Cost;
        }

        public void AddIngredient()
        {
            Ingredients.Add("pineapple");
            foreach (var ingredient in _pizzaToBeDecorated.Ingredients)
            {
                Ingredients.Add(ingredient);
            }
        }
    }
}
