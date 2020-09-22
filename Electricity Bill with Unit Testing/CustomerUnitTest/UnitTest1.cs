using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductInventory;
using CustomerData;

namespace CustomerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPositiveCustomerBillForRCustomer()
        {
            decimal expectedValue = 20.2m;
            decimal actualValue;

            //Act
            Customer testCust = new Customer("Test1", 20.2m, "12345", "R");
            actualValue = testCust.SumResidential();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestMethodZeroCustomerBillForRCustomer()
        {
            decimal expectedValue = 0m;
            decimal actualValue;

            //Act
            Customer testCust = new Customer("Test1", 0m, "12345", "R");
            actualValue = testCust.SumResidential();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void TestMethodPositiveCustomerBillForCCustomer()
        {
            decimal expectedValue = 20.2m;
            decimal actualValue;

            //Act
            Customer testCust = new Customer("Test1", 20.2m, "12345", "C");
            actualValue = testCust.SumCommercial();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestMethodZeroCustomerBillForCCustomer()
        {
            decimal expectedValue = 0m;
            decimal actualValue;

            //Act
            Customer testCust = new Customer("Test1", 0m, "12345", "C");
            actualValue = testCust.SumCommercial();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestMethodPositiveCustomerBillForICustomer()
        {
            decimal expectedValue = 20.2m;
            decimal actualValue;

            //Act
            Customer testCust = new Customer("Test1", 20.2m, "12345", "I");
            actualValue = testCust.SumIndustrial();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestMethodZeroCustomerBillForICustomer()
        {
            decimal expectedValue = 0m;
            decimal actualValue;

            //Act
            Customer testCust = new Customer("Test1", 0m, "12345", "I");
            actualValue = testCust.SumIndustrial();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
