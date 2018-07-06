using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class Log2xTest
    {
        [TestCase(8, 3)]
        [TestCase(4, 2)]
        [TestCase(2, 1)]

        public void CalculateLog2xTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("log2x");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Log2xExeptionTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("log2x");
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}