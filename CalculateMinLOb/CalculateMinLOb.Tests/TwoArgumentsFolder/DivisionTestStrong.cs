using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class DivisionTestStrong

    {
        [TestCase(0, 1, 0)]
        [TestCase(12, 4, 3)]
        [TestCase(14, -2, -7)]
        public void CalculateDivisionTestStrong(double firstValue, double secondValue, double expected)
        {

            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("div");
            double result = calculator.Calculate(26, 13);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void DivisionExeptionTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("div");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}