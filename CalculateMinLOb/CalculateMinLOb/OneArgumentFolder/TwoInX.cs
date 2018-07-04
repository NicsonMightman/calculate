using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class TwoInX : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}