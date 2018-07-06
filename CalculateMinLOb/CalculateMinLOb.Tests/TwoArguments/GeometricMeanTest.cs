using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    [TestFixture]
    public class ArithmeticMeanTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 5, 4)]
        [TestCase(-7, -2, -4.5)]
        public void CalculateArithmeticMeanTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new ArithmeticMean();
            double result = calculator.Calculate(3, 5);
            Assert.AreEqual(4, result);
        }
    }
}