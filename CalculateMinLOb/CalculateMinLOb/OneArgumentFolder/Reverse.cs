using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the Reverse function
    /// </summary>
    public class Reverse : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("reverse");
            }

            return 1/firstArgument;
        }
    }
}