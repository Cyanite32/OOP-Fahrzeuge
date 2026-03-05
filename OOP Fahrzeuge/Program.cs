namespace OOP_Fahrzeuge
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string Vorname = Console.ReadLine();
            string Nachname = Console.ReadLine();
            string Geburtsdatum = Console.ReadLine();
            string Adresse = Console.ReadLine();
           
            Person person = new Person(Vorname, Nachname, Geburtsdatum, Adresse, Person.auto, Person.motorrad);
            person.Ausweis();
  
        }
    }
}
