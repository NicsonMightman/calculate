using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class CatangensTest
    {
        [TestCase(3.141592 / 2, 0)]

        public void CalculateCatangensTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Catangens();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}