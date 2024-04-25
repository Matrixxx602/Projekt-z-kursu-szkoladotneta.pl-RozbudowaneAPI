using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class WyswietlanieZamowienia
    {
        // Wlasciwosci
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<WyswietlaniePozycjiZamowienia> WyswietlaniePozycjiZamowieniaLista { get; set; }
        public int ZamowienieID { get; private set; }
        public Adres AdresDostawy { get; set; }
    }
}