using DecoratorSample.Coffee.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample.Coffee
{
    public class BaseCoffee : ICoffee
    {
        public int Calories { get; set; }
        public List<string> Ingredients { get; set; }

        public BaseCoffee()
        {
            Calories = 200;
            Ingredients = new List<string>() { "basic coffee" };
        }
    }
}
