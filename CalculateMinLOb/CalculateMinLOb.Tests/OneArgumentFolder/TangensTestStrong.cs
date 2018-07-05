using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class TangensTestStrong
    {
        [TestCase(0, 0)]

        public void CalculateTangensTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Tangens();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}