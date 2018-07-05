using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class Tangens : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}