using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class ReverseTest

    {
        [TestCase(2, 0.5)]
        [TestCase(1, 1)]
        [TestCase(4, 0.25)]
        public void CalculateReverseTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("reverse");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ReverseExeptionTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("reverse");
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}