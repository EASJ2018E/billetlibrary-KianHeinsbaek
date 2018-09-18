using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace BilletTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilletPrisTest() // Tester om billetprismetoden virker.
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            double result = bil.Pris();

            // Assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TjekKøretøjTest() // Tester hvilke køretøj der er tale om.
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            string result = bil.Køretøj();

            // Assert
            Assert.AreEqual("Bil", result);
        }
    }
}
