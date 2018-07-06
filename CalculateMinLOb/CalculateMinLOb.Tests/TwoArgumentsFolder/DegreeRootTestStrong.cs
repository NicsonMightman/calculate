using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{

    [TestFixture]
    public class DegreeRootTestStrong

    {
        [TestCase(4, 2, 2)]
        [TestCase(27, 3, 3)]
        public void CalculateDegreeRootTestStrong(double firstValue, double secondValue, double expected)
        {

            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("degreeroot");
            double result = calculator.Calculate(25, 2);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void DegreeRootExeptionTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("degreeroot");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}