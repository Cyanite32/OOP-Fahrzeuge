
namespace OOP_Fahrzeuge
{
    public class Bereifung
    {
        public string Marke;
        public string Modell;
        public enum Bauart
        {
            Sommer,
            Winter
        };
        public Bauart bauart;
        public int Geschwindigkeitsindex;
        public bool Spikes;
        public int Dimension;

        public void Reifen()
        {
            Console.WriteLine("Reifen: ");
            Console.WriteLine("|-> {0}", Marke);
            Console.WriteLine("|-> {0}", Modell);
            Console.WriteLine("|-> {0}", bauart);
            Console.WriteLine("|-> {0}", Geschwindigkeitsindex);
            Console.WriteLine("|-> {0}", Spikes);
            Console.WriteLine("|-> {0}", Dimension);
        }
        public Bereifung(string Marke, string Modell, Bauart bauart, int Geschwindigkeitsindex, bool Spikes, int Dimension)
        {
            this.Marke = Marke;
            this.Modell = Modell;
            this.bauart = bauart;
            this.Geschwindigkeitsindex = Geschwindigkeitsindex;
            this.Spikes = Spikes;
            this.Dimension = Dimension;
        }
    }
}
