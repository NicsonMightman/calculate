using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    /// <summary>
    /// Function computes the Arccosinus
    /// </summary>
    public class ArcCosinus : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            if ((-1.0 <= firstArgument) && (firstArgument <= 1.0))
            {

                return Math.Acos(firstArgument);
            }
            else
            {
                throw new Exception("arccos");
            }
        }
    }
}