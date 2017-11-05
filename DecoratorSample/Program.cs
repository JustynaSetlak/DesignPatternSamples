using DecoratorSample.Coffee;
using DecoratorSample.Coffee.Interfaces;
using System;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new BaseCoffee();
            Console.WriteLine("basic coffee:");
            Console.WriteLine($"Calories: {coffee.Calories}");
            Console.Write($"Ingredients: ");
            coffee.Ingredients.ForEach(i => Console.Write(i + ", "));
            Console.WriteLine("\n");

            coffee = new Espresso(coffee);
            Console.WriteLine("coffee with esspresso:");
            Console.WriteLine($"Calories: {coffee.Calories}");
            Console.Write($"Ingredients: ");
            coffee.Ingredients.ForEach(i => Console.Write(i + ", "));
            Console.WriteLine("\n");

            coffee = new Espresso(coffee);
            Console.WriteLine("coffee with double espresso:");
            Console.WriteLine($"Calories: {coffee.Calories}");
            Console.Write($"Ingredients: ");
            coffee.Ingredients.ForEach(i => Console.Write(i + ", "));
            Console.WriteLine("\n");

            coffee = new MilkCoffee(coffee);
            Console.WriteLine("coffee with double esspresso and milk:");
            Console.WriteLine($"Calories: {coffee.Calories}");
            Console.Write($"Ingredients: ");
            coffee.Ingredients.ForEach(i => Console.Write(i + ", "));
            Console.WriteLine("\n");

            coffee = new MilkCoffee(coffee);
            Console.WriteLine("coffee with double esspresso and double milk:");
            Console.WriteLine($"Calories: {coffee.Calories}");
            Console.Write($"Ingredients: ");
            coffee.Ingredients.ForEach(i => Console.Write(i + ", "));

            Console.ReadKey();
        }
    }
}
