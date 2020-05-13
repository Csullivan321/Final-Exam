using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_Exam;

namespace PhoneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            Phone p1 = new Phone();
            decimal NewPrice = 550;
            //act 
            p1.Price = 500 + (500 * 0.1);

            //assert
            Assert.AreEqual(NewPrice, p1.Price);
        }
    }
}
