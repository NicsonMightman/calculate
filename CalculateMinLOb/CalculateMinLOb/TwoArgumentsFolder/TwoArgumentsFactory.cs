using System;

namespace CalculateMinLOb.TwoArgumentsFolder
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "add": return new Addition();
                case "minus": return new Minus();
                case "mult": return new Multiplication();
                case "div": return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }

}
