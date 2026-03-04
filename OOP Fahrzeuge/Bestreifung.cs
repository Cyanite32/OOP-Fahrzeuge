
namespace OOP_Fahrzeuge
{
    public class Bestreifung
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
        public string Dimension;

        public Bestreifung(string Marke, string Modell, Bauart bauart, int Geschwindigkeitsindex, bool Spikes, string Dimension)
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
