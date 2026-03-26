class ContratLocation
{
    int numeroContrat {get; set;}
    Locataire locataire {get; set;}
    Logement logement {get; set;}
    int nombreJours {get; set;}
    double tarifJournalier {get; set;}
    public ContratLocation(int numeroContrat, Locataire locataire, Logement logement, int nombreJours, double tarifJournalier)
    {
        if (nombreJours > 0 && tarifJournalier > 0 && logement.estDisponible() == true)
        {
            this.numeroContrat = numeroContrat;
            this.locataire = locataire;
            this.logement = logement;
            this.nombreJours = nombreJours;
            this.tarifJournalier = tarifJournalier;

            this.logement.disponibilite(false);
        }
        else {Console.WriteLine("Impossible");}
    }
    public void Afficher()
    {
        Console.WriteLine($"Numéro de contrat : {numeroContrat} | Nombre de jours : {nombreJours} | Tarif journalier : {tarifJournalier}");
    }
    public double CalculerMontantTotal()
    {
        return nombreJours * tarifJournalier;
    }
}