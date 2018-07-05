using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class XInY : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}