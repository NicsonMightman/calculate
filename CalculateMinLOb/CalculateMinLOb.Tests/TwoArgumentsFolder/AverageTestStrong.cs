using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class AverageTestStrong

    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 5, 4)]
        [TestCase(-7, -2, -4.5)]
        public void CalculateAverageTestStrong(double firstValue, double secondValue, double expected)
        {


            ITwoArgumentsCalculator calculator = new Average();
            double result = calculator.Calculate(3, 5);
            Assert.AreEqual(4, result);
        }
    }
}