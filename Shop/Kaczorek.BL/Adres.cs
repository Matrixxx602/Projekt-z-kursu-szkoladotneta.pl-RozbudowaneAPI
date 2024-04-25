namespace Kaczorek.BL
{
    public class Adres
    {
        // Konstruktory
        public Adres()
        {
            
        }

        public Adres(int adresID)
        {
            AdresID = adresID;
        }

        // Wlasciwiosci

        public int AdresID { get; private set; }
        public int AdresTyp { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
    }
}
