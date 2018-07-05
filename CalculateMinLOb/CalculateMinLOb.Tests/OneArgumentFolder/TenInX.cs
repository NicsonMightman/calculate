using CalculateMinLOb;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{


    [TestFixture]
    public class TenInXTestStrong

    {
        [TestCase(2, 100)]
        public void CalculateTenInXTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new TenInX();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}