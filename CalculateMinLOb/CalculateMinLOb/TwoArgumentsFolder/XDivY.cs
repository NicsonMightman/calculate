using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// the function divides two integer numbers
    /// </summary>
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