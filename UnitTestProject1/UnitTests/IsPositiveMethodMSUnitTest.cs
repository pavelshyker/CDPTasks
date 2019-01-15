namespace MSTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;

    [TestClass]
    public class IsPositiveMethodMSUnitTest : BaseClass
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
        public void IsPositive_PositiveValuesTesIsTrue()
        {
            Assert.IsTrue(calc.isPositive(arg1));
        }

        [TestMethod]
        public void IsPositive_NegativeValueTestIsFalse()
        {
            Assert.IsFalse(calc.isPositive(arg2));
        }

        [TestMethod]
        public void IsPositive_ZeroVelaueTestIsTrue()
        {
            Assert.IsTrue(calc.isPositive(arg3), "Possibly, an issue that 0 is negative value.");
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
