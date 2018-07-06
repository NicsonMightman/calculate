using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the construction of two to the power of number
    /// </summary>
    public class TwoInX : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}