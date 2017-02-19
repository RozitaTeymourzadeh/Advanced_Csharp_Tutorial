using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mod04Demo01;

namespace UnitTestCustomerMod04Demo01
{
    [TestClass]//Attribute
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer cust = Utilities.GetCustomer(ID: 5);
            cust.Status = CustomerStatusEnum.Silver;
            string expected = "Linda";
            Assert.AreEqual(expected, cust.Name, "Names did not match");

        }
    }
}
