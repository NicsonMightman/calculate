using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class XDivY : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("xdivy");
            }
            return (int) firstValue / (int) secondValue;
        }
    }
}