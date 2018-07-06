using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the Cosinus
    /// </summary>
    public class Cosinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}