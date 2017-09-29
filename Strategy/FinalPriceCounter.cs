using Strategy.Strategies;
using Strategy.Strategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class FinalPriceCounter
    {
        private IStrategy strategy;

        public FinalPriceCounter(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public FinalPriceCounter()
        {
            strategy = new NoDiscountPriceStrategy();
        }

        public double CountFinalPrice(double price)
        {
            return strategy.CountFinalPrice(price);
        }

        public void ChangeStrategyOfCountingFinalPrice(IStrategy newStrategy)
        {
            strategy = newStrategy;
        }
    }
}
