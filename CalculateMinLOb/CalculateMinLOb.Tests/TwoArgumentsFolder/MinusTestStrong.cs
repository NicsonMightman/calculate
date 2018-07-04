using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class MinusTestStrong

    {
        [TestCase(8, 0, 8)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateMinusTestStrong(double firstValue, double secondValue, double expected)
        {


            ITwoArgumentsCalculator calculator = new Minus();
            double result = calculator.Calculate(13, 26);
            Assert.AreEqual(-13, result);
        }
    }
}