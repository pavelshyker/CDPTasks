namespace MSTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;

    [TestClass]
    public class AddMethodMSUnitTest : BaseClass
    {
        private double arg1;
        private double arg2;

        [TestInitialize]
        public void TestInit()
        {
            arg1 = 3.2;
            arg2 = 2.3;
        }

        [TestMethod]
        public void Add_ValuesAreEqual()
        {
            double expected = 5.5;
            double result = calc.Add(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_ResultIsNotNull()
        {
            double result = calc.Add(arg1, arg2);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add_TestShouldFail()
        {
            Assert.Fail("This test should be failed");
        }

        [TestMethod]
        public void Add_TypeIsCorrect()
        {
            Assert.IsInstanceOfType((calc.Add(arg1, arg2)), typeof(double));
        }

        [TestCleanup]
        public void TestClean()
        {
            arg1 = 0;
            arg2 = 0;
        }
    }
}
