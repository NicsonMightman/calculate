using System;
using CalculateMinLOb.TwoArgumentsFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{
    public class TwoArgumentsFactoryTests
    {
        [TestCase("add", typeof(Addition))]
        [TestCase("minus", typeof(Minus))]
        [TestCase("mult", typeof(Multiplication))]
        [TestCase("div", typeof(Division))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}