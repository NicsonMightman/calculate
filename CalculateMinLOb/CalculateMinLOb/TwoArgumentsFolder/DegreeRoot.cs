using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class DegreeRoot : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, 1/secondValue);
        }
    }
}