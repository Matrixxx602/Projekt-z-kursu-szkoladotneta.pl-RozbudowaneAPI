using System;

namespace Kaczorek.BL
{
    public class PozycjaZamowienia
    {
        // Konstruktory
        public PozycjaZamowienia()
        {
            
        }
        public PozycjaZamowienia(int pozycjazamowieniaID)
        {
            PozycjaZamowieniaID = pozycjazamowieniaID;
        }

        // Własciwosci
        public int PozycjaZamowieniaID { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktID { get; set; }
        public Decimal? CenaZakupu { get; set; }

        // Metody
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0 || ProduktID <= 0 || CenaZakupu == null)
            {
                poprawne = false;
            }

            return poprawne;
        }

        public bool Zapisz()
        {
            // Kod, ktory zwraca zdefiniowana pozycje zamowienia
            return true;
        }

        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaID)
        {
            // Kod, ktory pobiera okreslona pozycje zamowienia
            return new PozycjaZamowienia();
        }
    }
}
