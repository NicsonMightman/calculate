using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void Division()
        {
            ITwoArgumentsCalculator calculator = new Division();
            double result = calculator.Calculate(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}