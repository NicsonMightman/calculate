using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class ArcSinusTest
    {
        [TestCase(0, 0)]

        public void CalculateArcSinusTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("arcsin");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ArcSinusExeptionTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("arcsin");
            Assert.Throws<Exception>(() => calculator.Calculate(5));
        }
    }
}