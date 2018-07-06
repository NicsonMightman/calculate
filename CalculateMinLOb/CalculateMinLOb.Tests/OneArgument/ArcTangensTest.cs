using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgument
{
    [TestFixture]
    public class ArcTangensTest
    {
        [TestCase(0, 0)]

        public void CalculateArcTangensTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new ArcTangens();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}