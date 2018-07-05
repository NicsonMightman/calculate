using System;

namespace CalculateMinLOb.OneArgumentFolder
{
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