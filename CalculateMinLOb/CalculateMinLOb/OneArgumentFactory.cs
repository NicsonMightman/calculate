using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMinLOb
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "square": return new Square();
                case "squareroot": return new SquareRoot();
                default:
                throw new Exception("Неизвестная операция");
            }
        }
    }

}
