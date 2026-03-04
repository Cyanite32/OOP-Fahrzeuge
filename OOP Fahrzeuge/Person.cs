namespace OOP_Fahrzeuge
{
    public class Person
    {
        public string Vorname;
        public string Nachname;
        public string Geburtsdatum;
        public string Adresse;
        public class Auto;
        public Auto auto;
        public class Motorrad;
        public Motorrad motorrad;
        public void Ausweis()
        {
            Console.WriteLine();
        }
        public Person(string Vorname, string Nachname, string Geburtsdatum, string Adresse, Auto auto, Motorrad motorrad)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geburtsdatum = Geburtsdatum;
            this.Adresse = Adresse;
            this.auto = auto;
            this.motorrad = motorrad;
        }
    }
}
