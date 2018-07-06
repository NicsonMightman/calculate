using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// function performs exponentiation
    /// </summary>
    public class XInY : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}