using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Chocolates.Interface;
using FactoryMethod.Chocolates;

namespace FactoryMethod.Factory
{
    public class ChocolateFactory : IChocolateFactory
    {
        public IChocolate CreateChocolateInstance(MainIngredient ingredient)
        {
            IChocolate chocolate = null;
            switch (ingredient)
            {
                case MainIngredient.Cacao:
                    chocolate = new DarkChocolate();
                    break;
                case MainIngredient.Milk:
                    chocolate = new MilkChocolate();
                    break;
                case MainIngredient.Nuts:
                    chocolate = new NutsChocolate();
                    break;
                default:
                    throw new ArgumentNullException("ingredient", "Such ingredient does not exist");
            }
            return chocolate;
        }
    }
}
