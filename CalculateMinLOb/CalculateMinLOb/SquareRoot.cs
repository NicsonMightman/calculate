using System;

namespace CalculateMinLOb
{
    public class SquareRoot : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}