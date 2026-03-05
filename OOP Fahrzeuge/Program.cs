namespace OOP_Fahrzeuge
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Max", "Mustermann", "4.4.1976", "Spargelfeldstraße 21-32", Person.auto, Person.motorrad);
            person.Ausweis();
            Person Guido = new Person("Guido", "Monzaller", "23.9.1983", "Bozenplatz 32", Person.auto, Person.motorrad);
            Guido.Ausweis();
        }
    }
}
