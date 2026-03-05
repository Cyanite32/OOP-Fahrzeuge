namespace OOP_Fahrzeuge
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Max", "Mustermann", "4.4.1976", "Spargelfeldstraße 21-32", Person.auto, Person.motorrad);
            person.Ausweis();
        }
    }
}
