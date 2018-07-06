using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the ArcrTangens
    /// </summary>
    public class ArcTangens : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}