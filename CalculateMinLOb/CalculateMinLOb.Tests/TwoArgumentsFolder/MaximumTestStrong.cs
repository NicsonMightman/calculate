using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class MaximumTestStrong

    {
        [TestCase(6, 7, 7)]
        [TestCase(3, 5, 5)]
        [TestCase(-7, -2, -2)]
        public void CalculateMaximumTestStrong(double firstValue, double secondValue, double expected)
        {


            ITwoArgumentsCalculator calculator = new Maximum();
            double result = calculator.Calculate(3, 5);
            Assert.AreEqual(5, result);
        }
    }
}