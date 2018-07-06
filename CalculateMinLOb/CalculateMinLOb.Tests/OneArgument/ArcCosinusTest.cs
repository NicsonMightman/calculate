using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class ArcCosinusTest
    {
        [TestCase(1, 0)]

        public void CalculateArcSinusTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("arccos");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ArcSinusExeptionTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("arccos");
            Assert.Throws<Exception>(() => calculator.Calculate(5));
        }
    }
}