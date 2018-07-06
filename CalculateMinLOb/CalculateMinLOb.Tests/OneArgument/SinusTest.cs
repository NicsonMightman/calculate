using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class SinusTest
    {
        [TestCase(0, 0)]

        public void CalculateSinusTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Sinus();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}