class Appartement : Logement
{
    private int nombrePieces;

    public Appartement(string reference, string adresse, int surface, double loyerBase, bool disponible, int nombrePieces) : base(reference, adresse, surface, loyerBase, disponible)
    {
        this.nombrePieces = nombrePieces;
    }

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Nombre de pièces : {nombrePieces}");
    }
    public override double CalculerLoyer()
    {
        return base.CalculerLoyer() + (nombrePieces * 100);
    }
}