using System;

namespace CalculateMinLOb
{
    public class TwoInX : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}