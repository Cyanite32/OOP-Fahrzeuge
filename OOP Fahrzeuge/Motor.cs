namespace OOP_Fahrzeuge
{
    public class Motor
    {
        public string Hersteller;
        public string Modell;
        public enum Art
        {
            Benzin,
            Diesel
        };
        public Art art;
        public int Hubraum;
        public int Leistung;
        public int Zylinder;
        public Motor(string Hersteller, string Modell, Art art, int Hubraum, int Leistung, int Zylinder)
        {

        }
    }
}
