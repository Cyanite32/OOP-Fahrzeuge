
namespace OOP_Fahrzeuge
{
    public class Motorrad
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
        public int Kilometerstand;
        public class Motor;
        public Motor motor;
        public class Bestreifung;
        public Bestreifung bestreifung;

        public Motorrad(string Marke, string Modell, string Baujahr, Sitzbezüge sitzbezüge, int Kilometerstand, Motor motor, Bestreifung bestreifung)
        {
            this.Marke = Marke;
            this.Modell = Modell;
            this.Baujahr = Baujahr;
            this.sitzbezüge = sitzbezüge;
            this.motor = motor;
            this.bestreifung = bestreifung;
        }
    }
}
