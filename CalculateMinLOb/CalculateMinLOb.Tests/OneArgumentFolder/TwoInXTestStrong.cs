using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class TwoInXTestStrong

    {
        [TestCase(3, 8)]
        public void CalculateTwoInXTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new TwoInX();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}