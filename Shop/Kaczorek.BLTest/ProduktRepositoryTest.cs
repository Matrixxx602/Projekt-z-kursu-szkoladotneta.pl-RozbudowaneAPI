using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            // Arrange (Przygotuj test)
            var projektrepository = new ProduktRepository();
            var oczekiwana = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci",
                AktualnaCena = 89.99M
            };

            // Act (Działaj)
            var aktualna = projektrepository.Pobierz(5);

            // Assert (Potwierdz test)

            Assert.AreEqual(oczekiwana.ProduktID, aktualna.ProduktID);
            Assert.AreEqual(oczekiwana.NazwaProduktu, aktualna.NazwaProduktu);
            Assert.AreEqual(oczekiwana.Opis, aktualna.Opis);
            Assert.AreEqual(oczekiwana.AktualnaCena, aktualna.AktualnaCena);
        }
    }
}
