using Strategy.Strategies;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 10;

            FinalPriceCounter finalPriceCounter = new FinalPriceCounter();
            double finalPrice = finalPriceCounter.CountFinalPrice(price);
            Console.WriteLine("No discount strategy");
            Console.WriteLine($"Final price: {finalPrice}");
            Console.WriteLine("-----");

            finalPriceCounter.ChangeStrategyOfCountingFinalPrice(new FivePercentDiscountPriceStrategy());
            double finalPriceWithFivePercentDiscount = finalPriceCounter.CountFinalPrice(price);
            Console.WriteLine("5% discount strategy");
            Console.WriteLine($"Final price: {finalPriceWithFivePercentDiscount}");
            Console.WriteLine("-----");

            finalPriceCounter.ChangeStrategyOfCountingFinalPrice(new TenPercentDiscountPriceStrategy());
            double finalPriceWithTenPercentDiscount = finalPriceCounter.CountFinalPrice(price);
            Console.WriteLine("10% discount strategy");
            Console.WriteLine($"Final price: {finalPriceWithTenPercentDiscount}");
            Console.WriteLine("-----");

            Console.ReadKey();
        }
    }
}
