namespace MSTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AbsMethodMSUnitTestDD : BaseClass
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xls)};dbq=Data\\TestData.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Sheet1$", DataAccessMethod.Sequential)]
        public void Abs_ValuesAreEqualDataDriven()
        {
            double rowNumber = calc.Abs(Convert.ToDouble(TestContext.DataRow["Number"]));
            double rowExpected = Convert.ToDouble(TestContext.DataRow["Expected"]);
            Assert.AreEqual(rowNumber, rowExpected);      
        }
    }
}
