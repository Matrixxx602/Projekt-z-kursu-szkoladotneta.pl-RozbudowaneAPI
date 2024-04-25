using Common;
using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Produkt : KlasaBazowa, ILogowanie
    {
        // Konstruktory
        public Produkt()
        {
            
        }

        public Produkt(int produktID)
        {
            ProduktID = produktID;
        }

        // Wlaściwości
        public int ProduktID { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get 
            {
                return _NazwaProduktu.WstawSpacje(); 
            }
            set { _NazwaProduktu = value; }
        }


        // Metody
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu) || AktualnaCena == null)
            {
                poprawne = false;
            }

            return poprawne;
        }

        public bool Zapisz()
        {
            // Kod, ktory zwraca zdefiniowany produkt
            return true;
        }

        public Produkt Pobierz(int produktID)
        {
            // Kod, ktory pobiera okreslony produkt
            return new Produkt();
        }

        public List<Produkt> Pobierz()
        {
            // Kod, ktory pobiera wszystkie produkty
            return new List<Produkt>();
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }

        public string Log()
        {
            var log = ProduktID + ". " + NazwaProduktu + ", Opis: " + Opis + ", Status: " + StanObiektu.ToString();

            return log;
        }
    }
}
