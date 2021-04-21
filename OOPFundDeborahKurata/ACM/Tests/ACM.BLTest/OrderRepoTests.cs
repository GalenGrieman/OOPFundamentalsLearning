using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepoTests
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // Arrange
            var orderRepo = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 7, 8, 10, 18, 00, 00,
                    new TimeSpan(11, 0, 0))
            };

            // Act
            var actual = orderRepo.Retrieve(10);

            // Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
