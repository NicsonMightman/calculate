using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes of the Sinus
    /// </summary>
    public class Sinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}