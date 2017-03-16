using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mod06Demo02;
// Make sure to give reference to the project that you want to test by right click on the Reference and add the relevant project
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer cust = Utilities.GetCustomers(ID: 5);
            cust.Status = CustomerStatusEnum.Silver;
            string expected = "Rozita";
            Assert.AreEqual(expected, cust.Name, "Name DiD not Match");

        }
    }
}
