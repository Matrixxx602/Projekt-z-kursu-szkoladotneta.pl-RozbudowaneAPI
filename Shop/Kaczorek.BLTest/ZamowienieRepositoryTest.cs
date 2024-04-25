using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwane = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2023, 3, 1, 12, 12, 12, TimeSpan.Zero)
            };

            var aktualne = zamowienieRepository.Pobierz(10);

            Assert.AreEqual(oczekiwane.ZamowienieID, aktualne.ZamowienieID);
            Assert.AreEqual(oczekiwane.DataZamowienia, aktualne.DataZamowienia);
        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Roman",
                Nazwisko = "Dzięcioł",
                DataZamowienia = new DateTimeOffset(2022, 5, 21, 16, 9, 2, new TimeSpan(5, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Wrocław",
                    Kraj = "Polska",
                    KodPocztowy = "41-442"
                },
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                   new WyswietlaniePozycjiZamowienia()
                   {
                        NazwaProduktu = "Talerz",
                        CenaZakupu = 160.79M,
                        Ilosc = 10
                   },
                   new WyswietlaniePozycjiZamowienia()
                   {
                        NazwaProduktu = "Stolik",
                        CenaZakupu = 45.44M,
                        Ilosc = 5
                   }
                }
            };

            // Act
            var aktualna = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            // Assert
            Assert.AreEqual(oczekiwana.ZamowienieID, aktualna.ZamowienieID);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);
            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);



            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].Ilosc, aktualna.WyswietlaniePozycjiZamowieniaLista[i].Ilosc);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu);
            }
        }
    }
}
