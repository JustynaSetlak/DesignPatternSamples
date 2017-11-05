using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample.Coffee.Interfaces
{
    public interface ICoffee
    {
        int Calories { get; set; }
        List<string> Ingredients { get; set; }
    }
}
