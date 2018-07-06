using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the Logarithm at the base of two
    /// </summary>
    public class Log2x : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("log2x");
            }

            return Math.Log(firstArgument,2);
        }
    }
}