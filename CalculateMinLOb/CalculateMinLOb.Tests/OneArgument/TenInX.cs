using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class TenInXTest
    {
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        [TestCase(4, 10000)]
        public void CalculateTenInXTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new TenInX();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}