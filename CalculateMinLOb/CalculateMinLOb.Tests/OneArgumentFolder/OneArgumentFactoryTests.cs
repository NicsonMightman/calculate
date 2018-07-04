using System;
using CalculateMinLOb.OneArgumentFolder;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{
    public class OneArgumentFactoryTests
    {
        [TestCase("square", typeof(Square))]
        [TestCase("twoinx", typeof(TwoInX))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}