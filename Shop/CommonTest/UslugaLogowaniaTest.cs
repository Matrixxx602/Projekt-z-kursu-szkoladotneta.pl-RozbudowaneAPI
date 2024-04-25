using Common;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowaniaTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            // Arrange (Przygotuj test)
            var zmienioneElemty = new List<ILogowanie>();
            var klient = new Klient(1)
            {
                Email = "malpa@o2.pl",
                Imie = "Mateo",
                Nazwisko = "Nowak",
                ListaAdresow = null,
            };

            zmienioneElemty.Add(klient as ILogowanie);

            var produkt = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Dla dzieci",
                AktualnaCena = 22.33M
            };

            zmienioneElemty.Add(produkt as ILogowanie);

            // Act (Działaj)
            UslugaLogowania.PiszDoPliku(zmienioneElemty);

            // Assert (Potwierdz test)

        }
    }
}
