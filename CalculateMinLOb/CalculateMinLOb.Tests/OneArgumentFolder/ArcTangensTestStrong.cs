using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class ArcTangensTestStrong
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