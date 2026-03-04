
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
        public static Motor motor = new Motor("LC8c", "LC8c Parallel-Twin", Motor.Art.Benzin, 125, 15, 1);
        public static Bereifung bereifung = new Bereifung("Continental", "Anlas SC-500 Wintergrip 2", Bereifung.Bauart.Winter, 130, false, 18);
        public int Kilometerstand;

        public Motorrad(string Marke, string Modell, string Baujahr, Sitzbezüge sitzbezüge, int Kilometerstand, Motor motor, Bereifung bereifung, int Kilometerstand)
        {
            this.Marke = Marke;
            this.Modell = Modell;
            this.Baujahr = Baujahr;
            this.sitzbezüge = sitzbezüge;
            this.Kilometerstand = Kilometerstand;
        }
    }
}
