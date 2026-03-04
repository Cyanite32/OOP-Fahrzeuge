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

        

        public Person(string Vorname, string Nachname, string Geburtsdatum, string Adresse, Auto auto, Motorrad motorrad)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geburtsdatum = Geburtsdatum;
            this.Adresse = Adresse;
        }
    }
}
