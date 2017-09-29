using Strategy.Strategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    public class FivePercentDiscountPriceStrategy : IStrategy
    {
        private readonly double discount = 0.05;

        public double CountFinalPrice(double price)
        {
            return price - discount * price;
        }
    }
}
