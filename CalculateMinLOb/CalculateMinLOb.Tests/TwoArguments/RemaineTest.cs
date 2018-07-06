using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{
    [TestFixture]
    public class RemaineTestStrong
    {
        [TestCase(5, 2, 1)]
        [TestCase(12, 8, 4)]
        [TestCase(14, 3, 2)]
        public void CalculateRemaineTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("remaine");
            double result = calculator.Calculate(5, 2);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void DivisionExeptionTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("remaine");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}