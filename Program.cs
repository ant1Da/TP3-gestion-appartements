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
        Console.WriteLine($"Loyer du studio : {s1.CalculerLoyer()}");
        Maison m1 = new Maison("ISRAEL", "Arthur", 25, 455, false, 50);
        m1.Afficher();
        Console.WriteLine($"Loyer de la maison : {m1.CalculerLoyer()}");
        Appartement a1 = new Appartement("Connetable", "Antoine", 25, 455, false, 3);
        a1.Afficher();
        Console.WriteLine($"Loyer de l'appartement : {a1.CalculerLoyer()}");
    }
}
