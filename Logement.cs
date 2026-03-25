using System.Dynamic;

class Logement
{
    private protected string reference {get; set;}
    private protected string adresse {get;set;}
    private protected int surface {get;set;}
    private protected double loyerBase {get;set;}
    private protected bool disponible {get; set;}
    public string getReference()
    {
        return reference;
    }
    public string getAdresse()
    {
        return adresse;
    }
    public int getSurface()
    {
        return surface;
    }
    public double getLoyerBase()
    {
        return loyerBase;
    }
    public bool getDisponible()
    {
        return disponible;
    }
    public string setReference()
    {
        return reference;
    }
    public string setAdresse()
    {
        return adresse;
    }
    public int setSurface()
    {
        return surface;
    }
    public double setLoyerBase()
    {
        return loyerBase;
    }
    public bool setDisponible()
    {
        return disponible;
    }
    public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
    }
}