using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class Log2xTestStrong
    {
        [TestCase(8, 3)]

        public void CalculateLog2xTestStrong(double firstValue, double expected)
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