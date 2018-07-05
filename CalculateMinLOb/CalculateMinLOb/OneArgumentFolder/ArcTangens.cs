using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class ArcTangens : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}