using Strategy.Strategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    public class TenPercentDiscountPriceStrategy : IStrategy
    {
        private readonly double discount = 0.1;

        public double CountFinalPrice(double price)
        {
            return price - discount * price;
        }
    }
}
