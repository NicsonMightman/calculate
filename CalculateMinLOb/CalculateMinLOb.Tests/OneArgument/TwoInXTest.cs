using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class TwoInXTest
        {
        [TestCase(3, 8)]
        [TestCase(4, 16)]
        [TestCase(5, 32)]
        public void CalculateTwoInXTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new TwoInX();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}