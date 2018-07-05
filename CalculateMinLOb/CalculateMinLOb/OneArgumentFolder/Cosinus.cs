﻿using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class Cosinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}