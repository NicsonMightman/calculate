using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void Multiplication()
        {
            ITwoArgumentsCalculator calculator = new Multiplication();
            double result = calculator.Calculate(3, 2);
            Assert.AreEqual(6, result);
        }
    }
}