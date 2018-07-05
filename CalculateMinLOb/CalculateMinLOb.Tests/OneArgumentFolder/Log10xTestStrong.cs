using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class Log10xTestStrong
    {
        [TestCase(100, 2)]

        public void CalculateLog10xTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("log10x");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Log2xExeptionTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("log10x");
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}