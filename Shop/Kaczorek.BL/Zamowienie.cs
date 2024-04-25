using Common;
using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Zamowienie : KlasaBazowa, ILogowanie
    {
        // Konstruktory
        public Zamowienie()
        {
            
        }

        public Zamowienie(int zamowienieID)
        {
            ZamowienieID = zamowienieID;
        }

        // Wlasciwosci
        #region Wlasciwosci
        public int ZamowienieID { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<PozycjaZamowienia> pozycjaZamowienia { get; set; }
        public int KlientID { get; set; }
        public int AdresDostawyID { get; set; }
        #endregion

        // Metody
        #region Metody
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
            {
                poprawne = false;
            }

            return poprawne;
        }

        public bool Zapisz()
        {
            // Kod, ktory zwraca zdefiniowane zamowienie
            return true;
        }

        public Zamowienie Pobierz(int zamowienieID)
        {
            // Kod, ktory pobiera okreslone zamowienie
            return new Zamowienie();
        }

        public List<Zamowienie> Pobierz()
        {
            // Kod, ktory pobiera wszystkie zamowienia
            return new List<Zamowienie>();
        }

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieID + ")";
        }

        public string Log()
        {
            var log = ZamowienieID + ": " + "Data" + DataZamowienia + " Status: " + StanObiektu.ToString();

            return log;
        }
        #endregion
    }
}
