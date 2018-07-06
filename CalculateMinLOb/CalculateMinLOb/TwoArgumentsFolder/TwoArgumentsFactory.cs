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
                case "min": return new Minimum();
                case "max": return new Maximum();
                case "xiny":return new XInY();
                case "logxy": return new LogXY();
                case "degreeroot": return new DegreeRoot();
                case "remaine": return new Remaine();
                case "arithmeticmean": return new ArithmeticMean();
                case "geometricmean": return new GeometricMean();
                case "xdivy": return new XDivY();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }

}
