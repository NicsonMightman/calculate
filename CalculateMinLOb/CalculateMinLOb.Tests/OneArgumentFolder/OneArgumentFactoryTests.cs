using System;
using CalculateMinLOb.OneArgumentFolder;
using NUnit.Framework;

namespace CalculateMinLOb.Tests.TwoArgumentsFolder
{
    public class OneArgumentFactoryTests
    {
        [TestCase("square", typeof(Square))]
        [TestCase("twoinx", typeof(TwoInX))]
        [TestCase("sin", typeof(Sinus))]
        [TestCase("cos", typeof(Cosinus))]
        [TestCase("tan", typeof(Tangens))]
        [TestCase("ctg", typeof(Catangens))]
        [TestCase("arcsin", typeof(ArcSinus))]
        [TestCase("arccos", typeof(ArcCosinus))]
        [TestCase("arctan", typeof(ArcTangens))]
        [TestCase("teninx", typeof(TenInX))]
        [TestCase("reverse", typeof(Reverse))]
        [TestCase("log2x", typeof(Log2x))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}