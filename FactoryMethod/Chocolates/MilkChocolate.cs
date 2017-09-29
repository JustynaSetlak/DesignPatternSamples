using FactoryMethod.Chocolates.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Chocolates
{
    public class MilkChocolate : IChocolate
    {
        public string DescribeItself()
        {
            return "It's a plain chocolate with milky taste";
        }
    }
}
