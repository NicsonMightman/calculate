using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    /// <summary>
    /// Function computes the Average of geometric
    /// </summary>
    public class GeometricMean : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            var geo = firstValue * secondValue;
            if (geo < 0)
            {
                throw new Exception("Меньше 0");
            }
            return Math.Sqrt(geo);
        }
    }
}