namespace OOP_Fahrzeuge
{
    public class Auto
    {
        public string Marke;
        public string Modell;
        public string Baujahr;
        public enum Sitzbezüge
        {
            Stoff,
            Leder,
            Polyester
        }
        public Sitzbezüge sitzbezüge;
        public Motor motor;
        public int Kilometerstand;
        public int PS;
        public class Motor;
        public class Bestreifung;

        public Auto(string Marke, string Modell, string Baujahr, Sitzbezüge sitzbezüge, Motor motor, Bestreifung bestreifung)
        {
            this.Marke = Marke;
            this.Modell = Modell;
            this.Baujahr = Baujahr;
            this.sitzbezüge = sitzbezüge;
            this.motor = motor;
        }
    }
}
