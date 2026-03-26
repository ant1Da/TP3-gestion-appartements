class Studio : Logement
{
    private bool meublé {get; set;}
    public Studio(string reference, string adresse, int surface, double loyerBase, bool disponible, bool meublé) : base(reference, adresse, surface, loyerBase, disponible)
    {
        this.meublé = meublé;
    }
     public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Meublé : {meublé}");
    }
    public override double CalculerLoyer()
    {
        if (meublé)
        {
            return base.CalculerLoyer() + 50;
        }
        else
        {
            return base.CalculerLoyer();
        }
    }
}