using DecoratorSample.Coffee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample.Coffee
{
    public class Espresso : ICoffee
    {
        private readonly ICoffee _baseCaffee;
        public int Calories { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();

        public Espresso(ICoffee caffee)
        {
            _baseCaffee = caffee;
            ModifyCaffee();
        }

        public void ModifyCaffee()
        {
           Calories = _baseCaffee.Calories + 100;
           foreach(var ingredient in _baseCaffee.Ingredients)
            {
                Ingredients.Add(ingredient);
            }
            Ingredients.Add("Esspresso");
        }

    }
}
