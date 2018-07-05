using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class ArcCosinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}