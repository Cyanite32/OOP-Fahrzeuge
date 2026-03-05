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
        
        public static Motor motor = new Motor("VW", "Tiguan", Motor.Art.Diesel, 1968, 200, 4);
        public static Bereifung bereifung = new Bereifung("Michelin", "PKW", Bereifung.Bauart.Sommer, 240, false, 15);
        public int Kilometerstand;
        
        public void Eisenkutsche()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nAuto:");
                Console.WriteLine("{0}", Marke);
                Console.WriteLine("{0}", Modell);
                Console.WriteLine("{0}", Baujahr);
                Console.WriteLine("{0}", sitzbezüge);
                bereifung.Reifen();
                motor.Rotom();
                Console.WriteLine("{0}", Kilometerstand);
                Console.ForegroundColor= ConsoleColor.White;
            }
        }
        public Auto(string Marke, string Modell, string Baujahr, Sitzbezüge sitzbezüge, Motor motor, Bereifung bereifung, int Kilometerstand)
        {
            this.Marke = Marke;
            this.Modell = Modell;
            this.Baujahr = Baujahr;
            this.sitzbezüge = sitzbezüge; 
            this.Kilometerstand = Kilometerstand;
        }
    }
}
