namespace OOP_Fahrzeuge
{
    public class Person
    {
        public string Vorname;
        public string Nachname;
        public string Geburtsdatum;
        public string Adresse;
        public static Auto auto = new Auto("VW", "SUV", "2010", Auto.Sitzbezüge.Leder, Auto.motor, Auto.bereifung, 2000);
        public static Motorrad motorrad = new Motorrad("KTM", "Duke 125", "2026", Motorrad.Sitzbezüge.Stoff, Motorrad.motor, Motorrad.bereifung, 750);

        public void Ausweis()
        {   if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}", Vorname);
                Console.WriteLine("{0}", Nachname);
                Console.WriteLine("{0}", Geburtsdatum);
                Console.WriteLine("{0}", Adresse);
                Console.ForegroundColor= ConsoleColor.White;
            }
            auto.Eisenkutsche();
            motorrad.Eisenross();
            Console.Write("\n\n");
        }

        public Person(string Vorname, string Nachname, string Geburtsdatum, string Adresse, Auto auto, Motorrad motorrad)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geburtsdatum = Geburtsdatum;
            this.Adresse = Adresse;
        }
    }
}
