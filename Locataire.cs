class Locataire
{
    public int id {get; set;}
    public string nom {get; set;}
    public string telephone {get; set;}
    public Locataire(int id, string nom, string telephone)
    {
        this.id = id;
        this.nom = nom;
        this.telephone = telephone;
    }
    public void AfficherLocataire()
    {
        Console.WriteLine($"ID : {id} | Nom : {nom} | Téléphone : {telephone}");
    }
}