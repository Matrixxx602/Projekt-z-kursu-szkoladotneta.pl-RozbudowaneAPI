using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            // Arrange (Przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "malpa@o2.pl",
                Imie = "Julian",
                Nazwisko = "Tusk"

            };

            // Act (Działaj)
            var aktualna = klientRepository.Pobierz(1);


            // Assert (Potwierdz test)
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientID, aktualna.KlientID);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

        }
        [TestMethod]
        public void PobierzKlientazAdresamiTest()
        {
            // Arrange (Przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "malpa@o2.pl",
                Imie = "Julian",
                Nazwisko = "Tusk",
                ListaAdresow = new List<Adres>()
                {
                    new Adres()
                    {
                        AdresTyp = 1,
                        Ulica = "Krótka",
                        Miasto = "Lublin",
                        Kraj = "Polska",
                        KodPocztowy = "11-112"
                    },

                    new Adres()
                    {
                        AdresTyp = 3,
                        Ulica = "Nowa",
                        Miasto = "Krakow",
                        Kraj = "Polska",
                        KodPocztowy = "13-112"
                    }
                }
            };

            // Act (Działaj)
            var aktualna = klientRepository.Pobierz(1);

            // Assert (Potwierdz test)
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);
            }
        }
    }
}
