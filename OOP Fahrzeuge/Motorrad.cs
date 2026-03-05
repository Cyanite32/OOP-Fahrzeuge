
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

        public void Eisenross()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMotorrad: ");
                Console.WriteLine("{0}", Marke);
                Console.WriteLine("{0}", Modell);
                Console.WriteLine("{0}", Baujahr);
                Console.WriteLine("{0}", sitzbezüge);
                motor.Rotom();
                bereifung.Reifen();
                Console.WriteLine("{0}", Kilometerstand);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public Motorrad(string Marke, string Modell, string Baujahr, Sitzbezüge sitzbezüge, Motor motor, Bereifung bereifung, int Kilometerstand)
        {
            this.Marke = Marke;
            this.Modell = Modell;
            this.Baujahr = Baujahr;
            this.sitzbezüge = sitzbezüge;
            this.Kilometerstand = Kilometerstand;
        }
    }
}
