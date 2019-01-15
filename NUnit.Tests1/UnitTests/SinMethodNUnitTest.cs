namespace NUnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SinMethodNUnitTest : BaseClass
    {
        private double arg1 = 1;
        private double arg2 = 0;

        [OneTimeSetUp]
        public void TestInit()
        {
            arg1 = 1;
            arg2 = 0;
        }

        [Test]
        public void Sin_ValuesAreEqual()
        {
            double expected = Math.Sin(arg1);
            double result = calc.Sin(arg1);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Sin_ResultIsZero()
        {
            double result = calc.Sin(arg2);
            Assert.Zero(result);
        }

        [OneTimeTearDown]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = 0;
        }
    }
}
