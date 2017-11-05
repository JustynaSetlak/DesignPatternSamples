using FactoryMethod.Chocolates;
using FactoryMethod.Chocolates.Interface;
using FactoryMethod.Factory;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IChocolateFactory chocolateFactory = new ChocolateFactory();
            IChocolate darkChocolate = chocolateFactory.CreateChocolate(MainIngredient.Cacao);
            Console.WriteLine("Dark chocolate:");
            Console.WriteLine(darkChocolate.DescribeItself());
            Console.WriteLine("----------------------------");

            IChocolate milkChocolate = chocolateFactory.CreateChocolate(MainIngredient.Milk);
            Console.WriteLine("Milk chocolate:");
            Console.WriteLine(milkChocolate.DescribeItself());
            Console.WriteLine("----------------------------");

            IChocolate nutsChocolate = chocolateFactory.CreateChocolate(MainIngredient.Nuts);
            Console.WriteLine("Nuts chocolate:");
            Console.WriteLine(nutsChocolate.DescribeItself());
            Console.WriteLine("----------------------------");

            Console.ReadKey();
        }
    }
}
