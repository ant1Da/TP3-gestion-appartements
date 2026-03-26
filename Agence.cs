class Agence
{
    protected string nom {get; set;}
    protected List<Logement> logements {get; set;}
    protected List<Locataire> locataires {get; set;}
    protected List<ContratLocation> contrats {get; set;}
    public Agence(string nom)
    {
        this.nom = nom;
        this.logements = new List<Logement>();
        this.locataires = new List<Locataire>();
        this.contrats = new List<ContratLocation>();
    }
    public void AjouterLogement(Logement logement)
    {
        logements.Add(logement);
    }
    public void AjouterLocataire(Locataire locataire)
    {
        if (!locataires.Any(l => l.id == locataire.id))
        {
            locataires.Add(locataire);
        }
        else
        {
            Console.WriteLine("Locataire déjà existant.");
        }
    }
    public void AjouterContrat(ContratLocation contrat)
    {
        if (logements.Contains(contrat.logement) && locataires.Contains(contrat.locataire))
        {
            contrats.Add(contrat);
        }
        else
        {
            Console.WriteLine("Logement ou locataire non trouvé dans l'agence.");
        }
    }
    public void AfficherLogements()
    {
        Console.WriteLine("Logements :");
        foreach (var logement in logements)
        {
            logement.Afficher();
            Console.WriteLine();
        }
    }
    public void AfficherLocataires()
    {
        Console.WriteLine("Locataires :");
        foreach (var locataire in locataires)
        {
            locataire.AfficherLocataire();
            Console.WriteLine();
        }
    }
    public void AfficherContrats()
    {
        Console.WriteLine("Contrats :");
        foreach (var contrat in contrats)
        {
            contrat.Afficher();
            Console.WriteLine();
        }
    }
}