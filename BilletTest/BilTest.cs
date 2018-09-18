using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilBilletPrisTest() // Tester om billetprismetoden virker.
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            double result = bil.Pris();

            // Assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void BilTjekK�ret�jTest() // Tester hvilke k�ret�j der er tale om.
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            string result = bil.K�ret�j();

            // Assert
            Assert.AreEqual("Bil", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BilNummerpladeL�ngdeTest()
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            bil.Nummerplade = "12345678";

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void BilBroBizzTest()
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            double result = bil.BroBizz();

            // Assert
            Assert.AreEqual(228, result, 0.001);
        }
    }
}
