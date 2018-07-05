using System;

namespace CalculateMinLOb
{
    public class Catangens : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}