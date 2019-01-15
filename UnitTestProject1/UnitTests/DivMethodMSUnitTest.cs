namespace MSTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;

    [TestClass]
    public class DivMethodMSUnitTest : BaseClass
    {
        private double arg1;
        private double arg2;
        private double arg3;
        private double arg4;

        [TestInitialize]
        public void TestInit()
        {
            arg1 = 10;
            arg2 = -2;
            arg3 = 0;
            arg4 = 3;
        }

        [TestMethod]
        public void Divide_NegativeValuesAreEqual()
        {        
            double expected = -5;
            double result = calc.Divide(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_DoubleResultsAreEqual()
        {       
            double expected = arg1 / arg4;
            double result = calc.Divide(arg1, arg4);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_ValuesAreNotEqual()
        {
            double expected = 0;
            double result = calc.Divide(arg1, arg3);
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void Divide_CompareIsEqual()
        {
            double expected = 1;
            double result = calc.Divide(arg1, arg1);
            Assert.AreEqual(expected, result);
        }

        [TestCleanup]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = 0;
            arg3 = 0;
            arg4 = 0;
        }
    }
}
