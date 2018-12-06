using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Steve";
            customer.LastName = "Jobs";

            string expected = "Jobs,Steve";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Jobs";

            string expected = "Jobs";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Steve";

            string expected = "Steve";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
