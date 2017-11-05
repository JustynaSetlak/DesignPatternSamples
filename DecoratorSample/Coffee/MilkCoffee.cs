using DecoratorSample.Coffee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample.Coffee
{
    public class MilkCoffee : ICoffee
    {
        private readonly ICoffee _baseCaffee;
        public int Calories { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();

        public MilkCoffee(ICoffee caffee)
        {
            _baseCaffee = caffee;
            ModifyCaffee();
        }

        public void ModifyCaffee()
        {
            Calories = _baseCaffee.Calories + 300;
            foreach (var ingredient in _baseCaffee.Ingredients)
            {
                Ingredients.Add(ingredient);
            }
            Ingredients.Add("Milk");
        }
    }
}
