using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the Catangens
    /// </summary>
    public class Catangens : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}