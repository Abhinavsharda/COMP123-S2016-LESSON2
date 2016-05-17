
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_LESSON2;
namespace UnitTest_FOR_LESSON_2
{
    [TestClass]
    public class UnitTest_FOR_LESSON_2
    {
        [TestMethod]
        public void addXandYTestMethod()
        {
            //Arrange
            int x = 50;
            int y = 40;
            int expectedResult = 90;

            //Act
            int result = Program.addXandY(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}