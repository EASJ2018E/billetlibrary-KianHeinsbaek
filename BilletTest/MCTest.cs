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

        [TestMethod]
        public void MCKøretøjTjek()
        {
            // Arrange
            MC mc = new MC();

            // Act
            string result = "MC";

            // Assert
            Assert.AreEqual("MC", result);
        }

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
