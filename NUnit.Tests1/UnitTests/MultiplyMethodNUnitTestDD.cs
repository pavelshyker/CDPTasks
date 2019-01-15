namespace NUnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class MultiplyMethodNUnitTestDD : BaseClass
    {
        [TestCase(2, 5, 10)]
        [TestCase(0, 5, 0)]
        [TestCase(-1, 5, -5)]

        public void Mutiply_ValuesAreEqual(double arg1, double arg2, double arg3)
        {
            double result = calc.Multiply(arg1, arg2);
            Assert.AreEqual(result, arg3);
        }
    }
}