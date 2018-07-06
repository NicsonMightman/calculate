using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    [TestFixture]
    public class MinimumTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 5, 3)]
        [TestCase(-7, -2, -7)]
        public void CalculateMinimumTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Minimum();
            double result = calculator.Calculate(3, 5);
            Assert.AreEqual(3, result);
        }
    }
}