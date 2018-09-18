using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletTest
{
    [TestClass]
    public class BilTest
    {
        /// <summary>
        /// Tester om metoden "Pris()" virker som den skal for klassen "Bil".
        /// </summary>
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

        /// <summary>
        /// Tester om metoden "K�ret�j()" virker som den skal for klassen "Bil".
        /// </summary>
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

        /// <summary>
        /// Tester hvad der sker hvis l�ngden af en nummerplade er over 7 cifre p� klassen "Bil".
        /// </summary>
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

        /// <summary>
        /// Tester om metoden "BroBizz()" virker som den skal og giver rabat p� klassen "Bil".
        /// </summary>
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
