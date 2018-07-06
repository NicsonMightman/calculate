using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class SquareTest
        {
        [TestCase(6, 36)]
        [TestCase(7, 49)]
        [TestCase(8, 64)]
        public void CalculateSquareTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Square();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}