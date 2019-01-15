namespace NUnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class MultiplyMethodNUnitTest : BaseClass
    {
        private double arg1;
        private string arg2;
        private double arg3;
        private double arg4;

        [OneTimeSetUp]
        public void TestInit()
        {
            arg1 = 2;
            arg2 = "5";
            arg3 = 0;
            arg4 = -2;
        }

        [Test]
        public void Multiply_ValuesAreEqual()
        { 
            double expected = 10;
            double result = calc.Multiply(arg1, Convert.ToDouble(arg2));
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Multiply_ZeroResult()
        {
            double result = calc.Multiply(arg1, arg3);
            Assert.Zero(result);
        }

        [Test]
        public void Multiply_NegativeResult()
        {
            double result = calc.Multiply(arg1, arg4);
            Assert.Negative(result);
        }

        [OneTimeTearDown]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = "";
            arg3 = 0;
            arg4 = 0;
        }
    }
}
