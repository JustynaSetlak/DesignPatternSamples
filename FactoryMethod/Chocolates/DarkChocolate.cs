using FactoryMethod.Chocolates.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Chocolates
{
    public class DarkChocolate : IChocolate
    {
        public string DescribeItself()
        {
            return "It's a plain chocolate consisting of 70% cacao";
        }
    }
}
