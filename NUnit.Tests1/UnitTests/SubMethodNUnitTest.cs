namespace NUnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class SubMethodNUnitTest : BaseClass
    {
        private double arg1;
        private double arg2;

        [OneTimeSetUp]
        public void TestInit()
        {
            arg1 = 5.1;
            arg2 = 5;
        }

        [Test]
        public void Sub_ValuesAreEqual()
        {
            double expected = arg1 - arg2;
            double result = calc.Sub(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Sub_ResultIsNegative()
        {
            double result = calc.Sub(arg2, arg1);
            Assert.Less(result, 0);
        }

        [Test]
        public void Sub_ResultIsZero()
        {
            double result = calc.Sub(arg1, arg1);
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


