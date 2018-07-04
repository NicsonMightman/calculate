using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class Square : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}