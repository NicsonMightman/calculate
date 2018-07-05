using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{
    [TestFixture]
    public class ReverseTestStrong

    {

        [TestCase(2, 0.5)]
        public void CalculateDivisionTestStrong(double firstValue, double expected)
        {

            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("reverse");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void DivisionExeptionTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("reverse");
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}