using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class LogXY : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            return Math.Log(firstValue, secondValue);
        }
    }
}