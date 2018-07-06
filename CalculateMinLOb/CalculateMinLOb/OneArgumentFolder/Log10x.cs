using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the Logarithm at the base of ten
    /// </summary>
    public class Log10x : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("log10x");
            }

            return Math.Log(firstArgument, 10);
        }
    }
}