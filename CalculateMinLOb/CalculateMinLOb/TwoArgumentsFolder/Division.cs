using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the Division of two numbers
    /// </summary>
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("div");
            }

            return firstArgument / secondArgument;
        }
    }
}