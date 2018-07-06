using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the construction of ten to the power of number
    /// </summary>
    public class TenInX : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}