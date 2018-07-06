using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class LogXY : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("logxy");
            }
            return Math.Log(firstValue, secondValue);
        }
    }
}