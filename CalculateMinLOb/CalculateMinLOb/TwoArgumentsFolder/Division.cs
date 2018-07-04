using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("div");
            }

            return firstArgument / secondArgument;
        }
    }
}