using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMinLOb
{
    public class Square : IOneArgumentCalculator
    {

        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument,2);
        }
    }
}