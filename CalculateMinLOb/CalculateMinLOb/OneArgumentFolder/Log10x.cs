using System;

namespace CalculateMinLOb.OneArgumentFolder
{
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