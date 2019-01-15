namespace MSTests
{
    using System;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CosMethodMSUnitTest : BaseClass
    {
        private double arg1;
        private double arg2;

        [TestInitialize]
        public void TestInit()
        {
            arg1 = 0;
            arg2 = -1;
        }

        [TestMethod]
        public void Cos_ValuesAreEqual()
        {
            double expected = 1;
            double result = calc.Cos(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cos_NegativeValuesAreEqual()
        {
            double expected = Math.Cos(arg2);
            double result = calc.Cos(arg2);
            Assert.AreEqual(expected, result);
        }

        [TestCleanup]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = 0;
        }
    }
}
