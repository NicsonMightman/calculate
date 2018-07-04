using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class SquareTestStrong

    {
        [TestCase(6, 36)]
        public void CalculateSquareTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Square();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}