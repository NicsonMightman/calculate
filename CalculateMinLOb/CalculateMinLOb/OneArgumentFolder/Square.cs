using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes of the Square function
    /// </summary>
    public class Square : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}