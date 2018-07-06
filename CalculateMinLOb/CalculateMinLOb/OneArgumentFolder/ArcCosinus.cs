using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public class ArcCosinus : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
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