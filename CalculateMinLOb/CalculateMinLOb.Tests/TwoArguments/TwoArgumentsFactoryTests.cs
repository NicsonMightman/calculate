using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    public class TwoArgumentsFactoryTests
    {
        [TestCase("add", typeof(Addition))]
        [TestCase("minus", typeof(Minus))]
        [TestCase("mult", typeof(Multiplication))]
        [TestCase("div", typeof(Division))]
        [TestCase("min", typeof(Minimum))]
        [TestCase("max", typeof(Maximum))]
        [TestCase("xiny", typeof(XInY))]
        [TestCase("logxy", typeof(LogXY))]
        [TestCase("degreeroot", typeof(DegreeRoot))]
        [TestCase("remaine", typeof(Remaine))]
        [TestCase("arithmeticmean", typeof(ArithmeticMean))]
        [TestCase("geometricmean", typeof(GeometricMean))]
        [TestCase("xdivy", typeof(XDivY))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
