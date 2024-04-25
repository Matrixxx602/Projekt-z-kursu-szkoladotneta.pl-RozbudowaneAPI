using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class AdresRepository
    {
        // Metody
        public Adres Pobierz(int adresID)
        {
            // Tworzymy instancje klasy Adresu
            var adres = new Adres(adresID);

            // Kod, ktory pobiera okreslony adres

            // Tymczasowe zakodowane wartosci, aby zwrocic adres
            if (adresID == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Krótka";
                adres.Miasto = "Lublin";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "01-002";
            }
            return adres;
        }

        // Pobieramy wszystkie zdefioniowane adresy klienta o przekazanym klientID
        public IEnumerable<Adres> PobierzPoKlientID(int klientID)
        {
            // Kod, ktory pobiera zdefioniowae adresy dla klienta

            // Tymczasowe zakodowane wartosci do zwrocenia, zestaw adersow dla klienta
            var listaAdresow = new List<Adres>();
            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Krótka",
                Miasto = "Lublin",
                Kraj = "Polska",
                KodPocztowy = "11-112"
            };
            listaAdresow.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 3,
                Ulica = "Nowa",
                Miasto = "Krakow",
                Kraj = "Polska",
                KodPocztowy = "13-112"
            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }

        public bool Zapisz(Adres adres)
        {
            // Kod, ktory zwraca zapisany adres
            return true;
        }
    }
}
