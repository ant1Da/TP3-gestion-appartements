using System.Dynamic;

class Logement
{
    private protected string reference {get; set;}
    private protected string adresse {get;set;}
    private protected int surface {get;set;}
    private protected double loyerBase {get;set;}
    private protected bool disponible {get; set;}
    public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
    {
        if (surface > 0 && loyerBase > 0)
        {
            this.reference = reference;
            this.adresse = adresse;
            this.surface = surface;
            this.loyerBase = loyerBase;
            this.disponible = disponible;
        }
        else {Console.WriteLine("Impossible");}
    }
    public virtual void Afficher()
    {
        Console.WriteLine($"Ref : {reference} | Adresse : {adresse} | Surface : {surface} | LoyerBase : {loyerBase} | Disponible : {disponible}");
    }
}