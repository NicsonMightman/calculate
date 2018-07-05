using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class AverageGeo : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double geo;
            geo = firstValue * secondValue;
            if (geo < 0)
            {
                throw new Exception("Меньше 0");
            }
            return Math.Sqrt(geo);
        }
    }
}