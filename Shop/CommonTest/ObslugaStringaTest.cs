using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            // Arrange (Przygotuj test)
            var nazwaproduktu = "KlockiLego";
            var oczekiwana = "Klocki Lego";

            // Act (Działaj)
            var aktualna = nazwaproduktu.WstawSpacje();

            // Assert (Potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            // Arrange (Przygotuj test)
            var nazwaproduktu = "Klocki Lego";
            var oczekiwana = "Klocki Lego";

            // Act (Działaj)
            var aktualna =nazwaproduktu.WstawSpacje();

            // Assert (Potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
