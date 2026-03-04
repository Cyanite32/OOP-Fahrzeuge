
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
