﻿using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class Remaine : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("remaine");
            }
            return firstValue % secondValue;
        }
    }
}