using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class Log10XTest
    {
        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        [TestCase(10000, 4)]

        public void CalculateLog10xTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("log10x");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Log2XExeptionTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("log10x");
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}