using System;

namespace CalculateMinLOb.OneArgumentFolder
{

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