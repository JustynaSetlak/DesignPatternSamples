using Strategy.Strategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    public class NoDiscountPriceStrategy : IStrategy
    {
        public double CountFinalPrice(double price)
        {
            return price;
        }
    }
}
