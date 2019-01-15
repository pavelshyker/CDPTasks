using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTests
{

    [TestFixture]
    public class MultiplyMettodUnitTests
    {
        private Calculator calc => new Calculator();

        double arg1 = 2;
        double arg2 = 5;
        double arg3 = 0;
        double arg4 = -2;
        string arg5 = "5";

        [SetUp]
        public static void TestInit()
        {
        }

        [Test]
        public void MultiplyAreEqual()
        {
            double expected = 10;
            double result = calc.Multiply(arg1, Convert.ToDouble(arg5));
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MultiplyZero()
        {
            double result = calc.Multiply(arg1, arg3);
            Assert.Zero(result);
        }

        [Test]
        public void MultiplyNegative()
        {
            double result = calc.Multiply(arg1, arg4);
            Assert.Negative(result);
        }

        [TearDown]
        public static void TestClean()
        {
        }
    }
    //------------------------------------------------------

    [TestFixture]
    public class PowMettodUnitTests
    {
        private Calculator calc => new Calculator();

        double arg1 = 2;
        double arg2 = 5;
        double arg3 = 0;
        double arg4 = -5;
        double arg5 = 1;

        [SetUp]
        public static void TestInit()
        {
        }

        [Test]
        public void PowAreEqualPositive()
        {
            double expected = 32;
            double result = calc.Pow(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PowZero()
        {
            double result = calc.Pow(arg3, arg1);
            Assert.Zero(result);
        }

        [Test]
        public void PowIsTrue()
        {
            double expected = 1;
            double result = calc.Pow(arg5, arg2);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void PowAreEqualNegative()
        {
            double expected = Math.Pow(arg1, arg4);
            double result = calc.Pow(arg1, arg4);
            Assert.AreEqual(expected, result);
        }

        [TearDown]
        public static void TestClean()
        {
        }

        //Tests are not passed for the Pow method. According to the Info it's due to wrong input. I believe that it something wrong with type of the input value. 
    }
    //-----------------------------------------------------------------------

    [TestFixture]
    public class SinMettodUnitTests
    {
        private Calculator calc => new Calculator();

        double arg1 = 1;
        double arg2 = 0;

        [SetUp]
        public static void TestInit()
        {
        }

        [Test]
        public void SinIsTrue()
        {
            double expected = Math.Sin(arg1);
            double result = calc.Sin(arg1);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void SinZero()
        {
            double result = calc.Sin(arg2);
            Assert.Zero(result);
        }

        [TearDown]
        public static void TestClean()
        {
        }


    }

    //--------------------------------------------------

    [TestFixture]
    public class SqrtMettodUnitTests
    {
        private Calculator calc => new Calculator();

        double arg1 = 4;
        double arg2 = 0;
        double arg3 = 1;
        //double arg4 = -25;
        double arg5 = 0.09;

        [SetUp]
        public static void TestInit()
        {
        }

        [Test]
        public void SqrtIsTrue()
        {
            double expected = 0.3;
            double result = calc.Sin(arg5);
            Assert.IsTrue(expected == result, "Possibly, an issue that it doesn't show correct value if a number is double.");

        }
        //I believe that it's an issue that it doesn't show correct value if a number is double.

        [Test]
        public void SqrtZero()
        {
            double result = calc.Sqrt(arg2);
            Assert.Zero(result);
        }

        [Test]
        public void SqrtAreEqualPositive()
        {
            double expected = 2;
            double result = calc.Sqrt(arg1);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SqrtAreEqualSameValue()
        {
            double expected = 1;
            double result = calc.Sqrt(arg3);
            Assert.AreEqual(expected, result);
        }

        //[Test]
        //public void SqrtAreEqual3()
        //{
        //    double expected = 5;
        //    double result = calc.Sqrt(arg4);
        //    Assert.AreEqual (expected, result);
        //}

        [TearDown]
        public static void TestClean()
        {
        }

    }
}