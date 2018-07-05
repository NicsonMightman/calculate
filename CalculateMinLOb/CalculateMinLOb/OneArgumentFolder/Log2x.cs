using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class Log2x : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument, 2);
        }
    }
}