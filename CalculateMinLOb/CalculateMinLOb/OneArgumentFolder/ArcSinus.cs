using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the Arcsinus
    /// </summary>
    public class ArcSinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            if ((-1.0 <= firstArgument) && (firstArgument <= 1.0))
            {

                return Math.Asin(firstArgument);
            }

            else
            {
                throw new Exception("arcsin");
            }
        }
    }
}