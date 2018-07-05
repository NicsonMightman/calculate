using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.OneArgumentFolder
{

    [TestFixture]
    public class CosinusTestStrong
    {
        [TestCase(0, 1)]

        public void CalculateCosinusTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Cosinus();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}