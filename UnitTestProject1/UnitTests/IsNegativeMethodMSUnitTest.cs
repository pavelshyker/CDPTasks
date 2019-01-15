namespace MSTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;

    [TestClass]
    public class IsNegativeMethodMSUnitTest : BaseClass
    {
        private double arg1;
        private double arg2;
        private double arg3;

        [TestInitialize]
        public void TestInit()
        {
            arg1 = 100;
            arg2 = -1.1;
            arg3 = 0;
        }

        [TestMethod]
        public void IsNegative_PositiveValueTestIsFalse()
        {
            Assert.IsFalse(calc.isNegative(arg1));
        }

        [TestMethod]
        public void IsNegative_NegativeValueTestIsTrue()
        {
            Assert.IsTrue(calc.isNegative(arg2));
        }

        [TestMethod]
        public void IsNegative_ZeroValueTestIsFalse()
        {
            Assert.IsFalse(calc.isNegative(arg3), "Possibly, an issue that 0 is negative value.");
        }

        //I believe that it's an issue that 0 is negative value.
        [TestCleanup]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = 0;
            arg3 = 0;
        }
    }
}
