using Decorator.Pizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizza
{
    public class SalamiPizza : IPizza
    {
        private readonly IPizza _pizzaToBeDecorated;
        public double Cost { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();

        public SalamiPizza(IPizza pizza)
        {
            _pizzaToBeDecorated = pizza;
            AddIngredient();
        }

        public double CalculateCost()
        {
            Cost = _pizzaToBeDecorated.CalculateCost() + 5;
            return Cost;
        }

        public void AddIngredient()
        {
            Ingredients.Add("salami");
            foreach (var ingredient in _pizzaToBeDecorated.Ingredients)
            {
                Ingredients.Add(ingredient);
            }
        }
    }
}
