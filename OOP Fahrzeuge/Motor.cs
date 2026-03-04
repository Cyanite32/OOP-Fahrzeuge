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
            this.Hersteller = Hersteller;
            this.Modell = Modell;
            this.art = art;
            this.Hubraum = Hubraum;
            this.Leistung = Leistung;
            this.Zylinder = Zylinder;
        }
    }
}
