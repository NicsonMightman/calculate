using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class XInYTestStrong

    {
        [TestCase(3, 0, 1)]
        [TestCase(3, 2, 9)]
        [TestCase(-7, 2, 49)]
        public void CalculateXInYTestStrong(double firstValue, double secondValue, double expected)
        {


            ITwoArgumentsCalculator calculator = new XInY();
            double result = calculator.Calculate(3, 0);
            Assert.AreEqual(1, result);
        }
    }
}