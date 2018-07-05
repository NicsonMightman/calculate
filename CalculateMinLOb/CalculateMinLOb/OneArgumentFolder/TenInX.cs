using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class TenInX : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}