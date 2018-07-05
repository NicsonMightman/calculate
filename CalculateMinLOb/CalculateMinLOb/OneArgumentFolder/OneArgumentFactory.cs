using System;
using System.Runtime.Remoting.Messaging;

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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }


}
