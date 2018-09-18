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
        public void TjekK�ret�jTest() // Tester hvilke k�ret�j der er tale om.
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            string result = bil.K�ret�j();

            // Assert
            Assert.AreEqual("Bil", result);
        }
    }
}
