using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{
    [TestFixture]
    public class MultiplicationTestStrong

    {
        [TestCase(7, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        public void CalculateMultiplicationTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Multiplication();
            double result = calculator.Calculate(13, 2);
            Assert.AreEqual(26, result);
        }
    }
}