using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    [TestFixture]
    public class LogXYTest
    {
        [TestCase(8, 2, 3)]
        [TestCase(16, 0, 1)]
        public void CalculateLogXYTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("logxy");
            double result = calculator.Calculate(8, 2);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void LogXYExeptionTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("logxy");
            Assert.Throws<Exception>(() => calculator.Calculate(0, 5));
        }
    }
}