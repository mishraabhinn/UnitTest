using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BL.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange

            Customer customer = new Customer() {
                FirstName = "Abhinn",
                LastName = "Mishra"
            };
            string expected = "Mishra, Abhinn";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
