using Decorator.Pizza.Interfaces;
using Decorator.Pizza;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new BasePizza();
            Console.WriteLine("basic pizza:");
            Console.WriteLine($"Cost: {pizza.CalculateCost()}");
            Console.Write($"Ingredients: ");
            pizza.getIngredients().ForEach(i => Console.Write(i + ", "));
            Console.WriteLine("\n");

            pizza = new HawaiiPizza(pizza);
            Console.WriteLine("pizza with pineapple:");
            Console.WriteLine($"Cost: {pizza.CalculateCost()}");
            Console.Write($"Ingredients: ");
            pizza.getIngredients().ForEach(i => Console.Write(i + ", "));            
            Console.WriteLine("\n");

            pizza = new HawaiiPizza(pizza);
            Console.WriteLine("pizza with double pineapple:");
            Console.WriteLine($"Cost: {pizza.CalculateCost()}");
            Console.Write($"Ingredients: ");
            pizza.getIngredients().ForEach(i => Console.Write(i + ", "));
            Console.WriteLine("\n");

            pizza = new SalamiPizza(pizza);
            Console.WriteLine("pizza with double pineapple and salami:");
            Console.WriteLine($"Cost: {pizza.CalculateCost()}");
            Console.Write($"Ingredients: ");
            pizza.getIngredients().ForEach(i => Console.Write(i + ", "));
            Console.WriteLine("\n");

            pizza = new SalamiPizza(pizza);
            Console.WriteLine("pizza with double pineapple and double salami:");
            Console.WriteLine($"Cost: {pizza.CalculateCost()}");
            Console.Write($"Ingredients: ");
            pizza.getIngredients().ForEach(i => Console.Write(i + ", "));

            Console.ReadKey();
        }
    }
}
