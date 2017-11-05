﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizza.Interfaces
{
    public interface IPizza
    {
        List<string> Ingredients { get; set; }
        double CalculateCost();
    }
}
