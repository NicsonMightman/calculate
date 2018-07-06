using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class CosinusTest
    {
        [TestCase(0, 1)]

        public void CalculateCosinusTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Cosinus();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}