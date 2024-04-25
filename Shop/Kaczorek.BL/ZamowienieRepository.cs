using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ZamowienieRepository
    {
        public Zamowienie Pobierz(int zamowienieID)
        {
            var zamowienie = new Zamowienie(zamowienieID);

            // Kod, ktory pobiera okreslone zamowienie

            //Tymczasowo zakodowane wartosci zamowienia
            if (zamowienieID == 10 )
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2023, 3, 1, 12, 12, 12, TimeSpan.Zero);
            }

            return zamowienie;
        }

        public List<Zamowienie> Pobierz()
        {
            // Kod, ktory pobiera wszystkie zamowienia
            return new List<Zamowienie>();
        }
        public bool Zapisz(Zamowienie zamowienie)
        {
            // Kod, ktory zwraca zdefiniowany produkt
            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DanePrawidlowe)
            {
                if (zamowienie.JestNowy)
                {
                    // wywolac procedure insert
                }
                else
                {
                    // wywolac procedure update
                }
            }

            return sukces;
        }

        // Pobieramy 1 zamowienie do wyswietlenia
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieID)
        {
            var wyswietlenieZamowienia = new WyswietlanieZamowienia();

            // Kod ktory pobiera zdefioniowane pola zamowienia z bazy danych

            // Kod tymczasowy, ktory zapewni dane na stale

            if (zamowienieID == 10)
            {
                wyswietlenieZamowienia.Imie = "Roman";
                wyswietlenieZamowienia.Nazwisko = "Dzięcioł";
                wyswietlenieZamowienia.DataZamowienia = new DateTimeOffset(2022, 5, 21, 16, 9, 2, new TimeSpan(5, 0, 0));
                wyswietlenieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Wrocław",
                    Kraj = "Polska",
                    KodPocztowy = "41-442"
                };
                wyswietlenieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();

                // Kod ktory pobiera elementy zamowienia

                // Tymczasowe dane zakodowane na stale
                if (zamowienieID == 10)
                {
                    WyswietlaniePozycjiZamowienia wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Talerz",
                        CenaZakupu = 160.79M,
                        Ilosc = 10
                    };
                    wyswietlenieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                    wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stolik",
                        CenaZakupu = 45.44M,
                        Ilosc = 5
                    };
                    wyswietlenieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
                }
            }

            return wyswietlenieZamowienia;
        }
    }
}
