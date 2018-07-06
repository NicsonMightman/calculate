using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class XDivYTestStrong

    {
        [TestCase(5, 2, 2)]
        [TestCase(12, 8, 1)]
        [TestCase(14, 3, 4)]
        public void CalculateXDivYTestStrong(double firstValue, double secondValue, double expected)
        {

            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("xdivy");
            double result = calculator.Calculate(5, 2);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void DivisionExeptionTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("xdivy");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}