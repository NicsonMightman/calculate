using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    [TestFixture]
    public class XInYTest
    {
        [TestCase(3, 0, 1)]
        [TestCase(3, 2, 9)]
        [TestCase(-7, 2, 49)]
        public void CalculateXInYTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new XInY();
            double result = calculator.Calculate(3, 0);
            Assert.AreEqual(1, result);
        }
    }
}