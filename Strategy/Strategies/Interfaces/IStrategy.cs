using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies.Interfaces
{
    public interface IStrategy
    {
        double CountFinalPrice(double price);
    }
}
