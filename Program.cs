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
    }
}
