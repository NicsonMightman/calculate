using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class LogXYTestStrong

    {
        [TestCase(8, 2, 3)]
        [TestCase(16, 0, 1)]
        public void CalculateLogXYTestStrong(double firstValue, double secondValue, double expected)
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