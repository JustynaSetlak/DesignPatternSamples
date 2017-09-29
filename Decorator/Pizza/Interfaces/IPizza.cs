using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizza.Interfaces
{
    public interface IPizza
    {
        double CalculateCost();
        List<string> getIngredients();
    }
}
