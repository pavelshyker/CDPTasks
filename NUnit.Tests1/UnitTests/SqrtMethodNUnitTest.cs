namespace NUnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class SqrtMethodNUnitTest : BaseClass
    {
        double arg1 = 4;
        double arg2 = 0;
        double arg3 = 1;
        double arg4 = 0.09;

        [OneTimeSetUp]
        public void TestInit()
        {
            arg1 = 4;
            arg2 = 0;
            arg3 = 1;
            arg4 = 0.09;
        }

        [Test]
        public void Sqrt_ValuesAreEqual()
        {
            double expected = 0.3;
            double result = calc.Sqrt(arg4);
            Assert.AreEqual(expected, result, "Possibly, an issue that it doesn't show correct value if a number is double.");
        }

        //I believe that it's an issue that it doesn't show correct value if a number is double.
        [Test]
        public void Sqrt_ResultIsZero()
        {
            double result = calc.Sqrt(arg2);
            Assert.Zero(result);
        }

        [Test]
        public void Sqrt_PositiveValuesAreEqual()
        {
            double expected = 2;
            double result = calc.Sqrt(arg1);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Sqrt_ValuesAreEqual2()
        {
            double expected = 1;
            double result = calc.Sqrt(arg3);
            Assert.AreEqual(expected, result);
        }

        [OneTimeTearDown]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = 0;
            arg3 = 0;
            arg4 = 0;
        }
    }
}

