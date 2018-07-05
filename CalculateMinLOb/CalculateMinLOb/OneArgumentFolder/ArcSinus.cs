using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class ArcSinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}