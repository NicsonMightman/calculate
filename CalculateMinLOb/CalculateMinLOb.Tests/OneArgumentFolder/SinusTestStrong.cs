using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class SinusTestStrong
    {
        [TestCase(0, 0)]

        public void CalculateSinusTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Sinus();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}