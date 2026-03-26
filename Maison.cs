class Maison : Logement
{
    int surfaceJardin {get; set;}
    public Maison(string reference, string adresse, int surface, double loyerBase, bool disponible, int surfaceJardin) : base(reference, adresse, surface, loyerBase, disponible)
    {
        if (surfaceJardin > 0 || surfaceJardin == 0)
        {
            this.surfaceJardin = surfaceJardin;
        }
        else {Console.WriteLine("Impossible");}
    }
    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Surface du jardin : {surfaceJardin}");
    }
    public override double CalculerLoyer()
    {
        return base.CalculerLoyer() + (surfaceJardin * 10);
    }
}