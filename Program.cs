namespace TP3_POO;

class Program
{
    static void Main(string[] args)
    {
        Logement l1 = new Logement("IGNASZEWSKI", "Louis", 25, 455, false);
        Logement l2 = new Logement("SEVRETTE--BIENCOURT", "Romain", -12, 255, false);
        Logement l3 = new Logement("PEDRAK", "Luka", 25, 658.2, false);

        List<Logement> logements = new List<Logement>();
        logements.Add(l1);
        logements.Add(l2);
        logements.Add(l3);

        foreach (Logement logement in logements)
        {
            logement.Afficher();
        }

        Studio s1 = new Studio("DAST", "Antoine", 25, 455, false, true);
        s1.Afficher();
        Console.WriteLine($"Loyer du studio : {s1.CalculerLoyer()}$");

        Maison m1 = new Maison("ISRAEL", "Arthur", 25, 455, false, 50);
        m1.Afficher();
        Console.WriteLine($"Loyer de la maison : {m1.CalculerLoyer()}$");

        Appartement a1 = new Appartement("Connetable", "Antoine", 25, 455, false, 3);
        a1.Afficher();
        Console.WriteLine($"Loyer de l'appartement : {a1.CalculerLoyer()}$");

        Locataire loc1 = new Locataire(1, "DAST", "06 12 34 56 78");
        loc1.AfficherLocataire();

        // partie 7

        Studio s2 = new Studio("JSP", "Antoine", 25, 455, true, true);
        ContratLocation c1 = new ContratLocation(1, loc1, s2, 30, 20);
        c1.Afficher();
        Console.WriteLine($"Montant total du contrat : {c1.CalculerMontantTotal()}$");
        Console.WriteLine(s2.estDisponible());
        Studio s3 = new Studio("JSP", "Antoine", 20, 200, false, false);
        // test d'impossibilité de créer un contrat avec un logement non disponible ou avec des valeurs négatives
        ContratLocation c2 = new ContratLocation(2, loc1, s3, 0, 20);
        ContratLocation c3 = new ContratLocation(3, loc1, s1, 30, -20);
    }
}
