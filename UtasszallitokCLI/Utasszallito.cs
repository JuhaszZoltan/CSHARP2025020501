namespace UtasszallitokCLI;

class Utasszallito
{
    public string Tipus { get; set; }
    public int Ev { get; set; }
    public string Utas { get; set; }
    public string Szemelyzet { get; set; }
    public int Utazosebesseg { get; set; }
    public int Felszallotomeg { get; set; }
    public float Fesztav { get; set; }
    public string Sebessegkategoria { get; set; }

    public Utasszallito(string sor)
    {
        string[] tmp = sor.Split(';');

        Tipus = tmp[0];
        Ev = int.Parse(tmp[1]);
        Utas = tmp[2];
        Szemelyzet = tmp[3];
        Utazosebesseg = int.Parse(tmp[4]);
        Felszallotomeg = int.Parse(tmp[5]);
        Fesztav = float.Parse(tmp[6]);

        Sebessegkategoria = new Sebessegkategoria(Utazosebesseg).Kategorianev;
    }
}
