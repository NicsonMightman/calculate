using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{
    [TestFixture]
    public class MinusTests
    {
        [Test]
        public void Minus()
        {
            ITwoArgumentsCalculator calculator = new Minus();
            double result = calculator.Calculate(13, 26);
            Assert.AreEqual(-13, result);
        }
    }
}