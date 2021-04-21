using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTest()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = StringHandler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";


            //Act
            var actual = StringHandler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void InsertSpacesAllCaps()
        //{
        //    //Arrange
        //    var source = "SONICSCREWDRIVER";
        //    var expected = "Sonic Screwdriver";
        //    var handler = new StringHandler();

        //    //Act
        //    var actual = handler.InsertSpaces(source);

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
