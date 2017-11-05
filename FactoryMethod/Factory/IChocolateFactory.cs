using FactoryMethod.Chocolates;
using FactoryMethod.Chocolates.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
{
    public interface IChocolateFactory
    {
        IChocolate CreateChocolate(MainIngredient ingredient);
    }
}
