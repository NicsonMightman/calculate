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
                case "sin": return new Sinus();
                case "cos": return new Cosinus();
                case "tan": return new Tangens();
                case "ctg": return new Catangens();
                case "arcsin": return new ArcSinus();
                case "arccos": return new ArcCosinus();
                case "arctan": return new ArcTangens();
                case "teninx": return new TenInX();
                case "reverse": return new Reverse();
                case "log2x": return new Log2x();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }


}
