using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class Sinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}