using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ProduktRepository
    {
        public Produkt Pobierz(int produktID)
        {
            // Tworzenie instancji produktu
            var produkt = new Produkt(produktID);
            object mojObiekt = new object();
            Console.WriteLine("Obiekt: " + mojObiekt.ToString());
            Console.WriteLine("Produkt: " + produkt.ToString());

            // Kod, ktory pobiera okreslony produkt

            // Tymaczasowe zakodowane wartosci
            if (produktID == 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }

             return produkt;
        }

        public List<Produkt> Pobierz()
        {
            // Kod, ktory pobiera wszystkie produkty
            return new List<Produkt>();
        }

        public bool Zapisz(Produkt produkt)
        {
            // Kod, ktory zwraca zdefiniowany produkt
            var sukces = true;

            if (produkt.MaZmiany && produkt.DanePrawidlowe)
            {
                if (produkt.JestNowy)
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
