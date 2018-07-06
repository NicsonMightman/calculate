using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes of the Tangens fuction
    /// </summary>
    public class Tangens : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}