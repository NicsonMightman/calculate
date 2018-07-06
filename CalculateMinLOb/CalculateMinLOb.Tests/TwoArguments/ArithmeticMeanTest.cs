using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    [TestFixture]
    public class GeometricMeanTest
        {
        [TestCase(0, 0, 0)]
        [TestCase(6, 6, 6)]
        [TestCase(-4, -4, 4)]
        public void CalculateGeometricMeanTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new GeometricMean();
            double result = calculator.Calculate(4, 4);
            Assert.AreEqual(4, result);
        }
    }
}