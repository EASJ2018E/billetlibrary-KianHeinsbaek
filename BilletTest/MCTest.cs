using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletTest
{
    [TestClass]
    public class MCTest
    {
        /// <summary>
        /// Tester om metoden "Pris()" virker som den skal for klassen "MC".
        /// </summary>
        [TestMethod]
        public void MCBilletPrisTest()
        {
            // Arrange
            MC mc = new MC();

            // Act
            double result = mc.Pris();

            // Assert
            Assert.AreEqual(125, result);
        }

        /// <summary>
        /// Tester om metoden "Køretøj()" virker som den skal for klassen "MC".
        /// </summary>
        [TestMethod]
        public void MCKøretøjTjek() 
        {
            // Arrange
            MC mc = new MC();

            // Act
            string result = mc.Køretøj();

            // Assert
            Assert.AreEqual("MC", result);
        }

        /// <summary>
        /// Tester hvad der sker hvis længden af en nummerplade er over 7 cifre på klassen "MC".
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MCNummerpladeLængdeTest()
        {
            // Arrange
            MC mc = new MC();

            // Act
            mc.Nummerplade = "12345678";

            // Assert
            Assert.Fail();
        }

        /// <summary>
        /// Tester om metoden "BroBizz()" virker som den skal og giver rabat på klassen "MC".
        /// </summary>
        [TestMethod]
        public void MCBroBizzTest()
        {
            // Arrange
            MC mc = new MC();

            // Act
            double result = mc.BroBizz();

            // Assert
            Assert.AreEqual(118.75, result, 0.001);
        }
    }
}
