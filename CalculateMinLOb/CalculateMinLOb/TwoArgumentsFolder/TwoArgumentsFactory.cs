using System;
using System.Runtime.Remoting.Messaging;

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
                case "average": return new Average();
                case "averagegeo": return new AverageGeo();
                case "xdivy": return new XDivY();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }

}
