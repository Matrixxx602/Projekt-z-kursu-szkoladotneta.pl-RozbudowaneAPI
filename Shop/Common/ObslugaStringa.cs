namespace Common
{
    public static class ObslugaStringa
    {
        public static string WstawSpacje(this string zrodlo)
        {
            string wynik = string.Empty;
            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        // przycinamy wszystkie spacje, ktore juz tam sa, a nastepnie odajemy nasza spacje.
                        wynik = wynik.Trim();
                        wynik += " ";
                    }
                    wynik += litera;
                }
            }
            return wynik.Trim();
        }
    }
}
