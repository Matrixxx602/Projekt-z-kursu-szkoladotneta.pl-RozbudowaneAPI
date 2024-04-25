using System.Collections.Generic;
using System.Linq;

namespace Kaczorek.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        // Metody
        public Klient Pobierz(int klientID)
        {
            // Tworzymy instancje klasy Klienta
            var klient = new Klient(klientID);
            klient.ListaAdresow = adresRepository.PobierzPoKlientID(klientID).ToList();

            // Kod, ktory pobiera okreslonego klienta

            // Tymczasowe zakodowane wartosci, aby zwrocic klienta
            if (klientID == 1)
            {
                klient.Email = "malpa@o2.pl";
                klient.Imie = "Julian";
                klient.Nazwisko = "Tusk";
            }


            return klient;
        }

        public List<Klient> Pobierz()
        {
            // Kod, ktory pobiera wszystkich klienta w liscie
            return new List<Klient>();
        }

        public bool Zapisz(Klient klient)
        {
            // Kod, ktory zwraca zdefiniowany produkt
            var sukces = true;

            if (klient.MaZmiany && klient.DanePrawidlowe)
            {
                if (klient.JestNowy)
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
    }
}
