namespace NUnitTests
{
    using System;
    using System.Threading;
    using NUnit.Framework;

    [TestFixture]
    public class PowMethodNUnitTest : BaseClass
    {
        private double arg1;
        private double arg2;
        private double arg3;
        private double arg4;
        private double arg5;

        [OneTimeSetUp]
        public void TestInit()
        {
            arg1 = 2;
            arg2 = 5;
            arg3 = 0;
            arg4 = -5;
            arg5 = 1;
        }

        [Test]
        public void Pow_PositiveValueAreEqual()
        {
            double expected = 32;
            double result = calc.Pow(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Pow_ZeroResult()
        {
            double result = calc.Pow(arg3, arg1);
            Assert.Zero(result);
        }

        [Test]
        public void Pow_ValuesAreEqual1()
        {
            double expected = 1;
            double result = calc.Pow(arg5, arg2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Pow_NegativeValuesResultsAreEqual()
        {
            double expected = Math.Pow(arg1, arg4);
            double result = calc.Pow(arg1, arg4);
            Assert.AreEqual(expected, result);
        }

        [OneTimeTearDown]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = 0;
            arg3 = 0;
            arg4 = 0;
            arg5 = 0;
        }

        //Tests are not passed for the Pow method. According to the Info it's due to wrong input. I believe that it's something wrong with type of the input value. 
    }
}
