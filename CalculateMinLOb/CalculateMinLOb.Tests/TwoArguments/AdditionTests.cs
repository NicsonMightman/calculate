using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void Addition()
        {
            ITwoArgumentsCalculator calculator = new Addition();
            double result = calculator.Calculate(13, 26);
            Assert.AreEqual(39, result);
        }
    }
}