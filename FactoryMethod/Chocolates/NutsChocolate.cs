using FactoryMethod.Chocolates.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Chocolates
{
    public class NutsChocolate : IChocolate
    {
        public string DescribeItself()
        {
            return "It's a pure chocolate with nuts";
        }
    }
}
