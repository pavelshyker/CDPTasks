namespace MSTests
{
    using System;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AbsMethodMSUnitTest : BaseClass
    {
        private string arg1;
        private double arg2;
        private double arg3;

        [TestInitialize]
        public void TestInit()
        {
            arg1 = "-5";
            arg2 = -5.1;
            arg3 = 0;
        }

        [TestMethod]
        public void Abs_IntValuesAreEqual()
        {
            double expected = 5;
            double result = calc.Abs(Convert.ToDouble(arg1));
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Abs_DoubleValuesAreEqual()
        {
            double expected = 5.1;
            double result = calc.Abs(arg2);
            Assert.AreEqual(expected, result, "Possibly, it returns int value, not double");
        }

        //I believe that it's an issue that it doesn't return an absoulute value of the double number.
        [TestMethod]
        public void Abs_ValueIsNull()
        {
            double result = calc.Abs(arg3);
            Assert.IsNull(result);
        }

        [TestCleanup]
        public void TestClean()
        {
            arg1 = "";
            arg2 = 0;
            arg3 = 0;
        }
    }
}
