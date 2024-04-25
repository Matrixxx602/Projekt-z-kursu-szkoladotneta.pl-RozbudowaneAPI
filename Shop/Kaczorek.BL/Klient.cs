using Common;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Klient : KlasaBazowa, ILogowanie
    {
        // Konstruktory
        public Klient() : this(0) 
        {
        }
        public Klient(int klientID)
        {
            KlientID = klientID;
            ListaAdresow = new List<Adres> ();
        }

        // Właściwosci
        public static int Licznik { get; set; }
        public string Imie { get; set; }
        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }
        public string Email { get; set; }
        public int KlientID { get; private set; }
        public string ImieNazwisko
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(Imie))
                    {
                        return Imie + " " + Nazwisko;
                    }
                    return Nazwisko;
                }
                return Imie;
            }
        }
        public List<Adres> ListaAdresow { get; set; }
        public int TypKlienta { get; set; }

        // Metody
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko) || string.IsNullOrWhiteSpace(Email))
            {
                poprawne = false;
            }

            return poprawne;
        }

        public bool Zapisz()
        {
            // Kod, ktory zwraca zapisanego klienta
            return true;
        }

        public Klient Pobierz(int klientID)
        {
            // Kod, ktory pobiera okreslonego klienta
            return new Klient();
        }

        public List<Klient> Pobierz()
        {
            // Kod, ktory pobiera wszystkich klienta w liscie
            return new List<Klient>();
        }

        public override string ToString()
        {
            return ImieNazwisko;
        }
        public string Log()
        {
            var log = KlientID + ": " + ImieNazwisko + ", Email: " + Email + ", Status: " + StanObiektu;

            return log;
        }
    }
}