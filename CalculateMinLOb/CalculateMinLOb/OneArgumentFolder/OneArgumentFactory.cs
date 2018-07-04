using System;

namespace CalculateMinLOb.OneArgumentFolder
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "square": return new Square();
                case "twoinx": return new TwoInX();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }

}
