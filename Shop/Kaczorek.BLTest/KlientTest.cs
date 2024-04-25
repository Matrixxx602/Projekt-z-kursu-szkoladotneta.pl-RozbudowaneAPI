using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (Przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Skieta";
            klient.Nazwisko = "Tusk";

            string oczekiwana = "Skieta Tusk";

            // Act (Działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (Potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImiePusteNazwiskoTest()
        {
            // Arrange (Przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "";
            klient.Nazwisko = "Tusk";

            string oczekiwana = "Tusk";

            // Act (Działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (Potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoPusteTest()
        {
            // Arrange (Przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Skieta";
            klient.Nazwisko = "";

            string oczekiwana = "Skieta";

            // Act (Działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (Potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange (Przygotuj test)
            var kln1 = new Klient();
            kln1.Imie = "Skieta";
            Klient.Licznik += 1;

            var kln2 = new Klient();
            kln2.Imie = "Rosita";
            Klient.Licznik += 1;

            var kln3 = new Klient();
            kln3.Imie = "Lori";
            Klient.Licznik += 1;

            // Act (Działaj)

            // Assert (Potwierdz test)
            Assert.AreEqual(3, Klient.Licznik);

        }

        [TestMethod]
        public void ZwalidujTest()
        {
            // Arrange (Przygotuj test)

            var klient1 = new Klient();
            klient1.Nazwisko = "Skieta";
            klient1.Email = "skieta@o2.pl";

            var oczekiwana = true;

            // Act (Działaj)

            var aktualna = klient1.Zwaliduj();

            // Assert (Potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void xxx()
        {
            // Arrange (Przygotuj test)
            
            // Act (Działaj)

            // Assert (Potwierdz test)

        }
    }
}
