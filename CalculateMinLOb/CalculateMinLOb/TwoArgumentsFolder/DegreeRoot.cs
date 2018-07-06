using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the Degree Root
    /// </summary>
    public class DegreeRoot : ITwoArgumentsCalculator
    {
        double ITwoArgumentsCalculator.Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("div");
            }

            return Math.Pow(firstValue, 1/secondValue);
        }
    }
}