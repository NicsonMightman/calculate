using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMinLOb
{
    class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "add": return new Add();
                case "minus": return new minus();
                case "mult": return new div();
                case "div": return new div();
                default:
                throw new Exception("Неизвестная операция");
            }
        }
    }

}
