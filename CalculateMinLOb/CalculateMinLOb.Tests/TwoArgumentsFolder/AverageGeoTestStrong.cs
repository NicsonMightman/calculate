using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class AverageGeoTestStrong

    {
        [TestCase(0, 0, 0)]
        [TestCase(6, 6, 6)]
        [TestCase(-4, -4, 4)]
        public void CalculateAverageGeoTestStrong(double firstValue, double secondValue, double expected)
        {


            ITwoArgumentsCalculator calculator = new AverageGeo();
            double result = calculator.Calculate(4, 4);
            Assert.AreEqual(4, result);
        }
    }
}