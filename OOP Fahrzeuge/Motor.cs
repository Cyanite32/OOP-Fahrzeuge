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
        public void Rotom()
        {
           /* Hersteller = Console.ReadLine();
            Modell = Console.ReadLine();
            Art.TryParse(Console.ReadLine(), out art);
            Hubraum = Convert.ToInt32(Console.ReadLine());
            Leistung = Convert.ToInt32(Console.ReadLine());
            Zylinder = Convert.ToInt32(Console.ReadLine());
            */
            Console.WriteLine("___Motor:");
            Console.WriteLine("|-> {0}", Hersteller);
            Console.WriteLine("|-> {0}", Modell);
            Console.WriteLine("|-> {0}", art);
            Console.WriteLine("|-> {0}", Hubraum);
            Console.WriteLine("|-> {0}", Leistung);
            Console.WriteLine("|-> {0}", Zylinder);
        }
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
