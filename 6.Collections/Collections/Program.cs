//Tableaux
using System.Collections;

double[] PlusGrand(double[] table)
{
    double max = 0;
    for (int i = 0; i < table.Length; i++)
    {
        max = Math.Max(max, table[i]);
    }
    return [Array.IndexOf(table, max), max];
}

double[] GenererTable(int taille)
{
    Random random = new Random();
    double[] table = new double[taille];

    for (var Index = 0; Index < taille; Index++)
    {
        table[Index] = random.Next(101);
    }
    return table;
}

void AfficherTable(double[] table)
{
    Console.WriteLine("Entrer la taille du tableau : ");
    var taille = int.Parse(Console.ReadLine());

    Console.WriteLine(PlusGrand(GenererTable(taille)));
}

//Listes
static void AfficherListe(List<string> liste, bool ordreDescandant = false )
{
    if (ordreDescandant)
    {
        liste.Reverse();
    }
    for (int i = 0; i < liste.Count; i++)
    {
        Console.WriteLine(liste[i]);
    }
}

static string PlusLongMot(List<string> liste)
{
    string PlusLong = liste[0];
    for (int i = 1; i < liste.Count; i++)
    {
        if (liste[i].Length > PlusLong.Length)
        {
            PlusLong = liste[i];
        }
    }
    return PlusLong;
}

static void SupprimerMot(List<string> liste, string finMot)
{
    for(int i = liste.Count - 1; i >= 0; i--)
    {
        if (liste[i].EndsWith(finMot))
        {
            liste.RemoveAt(i);
        }
    }
}

static List<string> AfficherElmentsCommuns(List<string> liste1, List<string> liste2)
{
    var elementsCommuns = new List<string>();
    foreach (var element in liste1)
    {
        if (liste2.Contains(element) && !elementsCommuns.Contains(element))
        {
            elementsCommuns.Add(element);
        }
    }
    return elementsCommuns;
}

static void Listes()
{
    var Liste = new List<string>();
    Liste.Add("Bonjour");

    while (true)
    {
        Console.WriteLine("Entrer un mot: ");
        var mot = Console.ReadLine();
        if (mot == "")
        {
            break;
        }
        else
        {
            Liste.Add(mot);
        }
    }
    AfficherListe(Liste, true);
    Console.WriteLine("Le mot le plus long est : " + PlusLongMot(Liste));

    Console.WriteLine("Entrer la fin du mot à supprimer : ");
    var finMot = Console.ReadLine();
    SupprimerMot(Liste, finMot);
    Console.WriteLine("Liste après suppression : ");
    AfficherListe(Liste);

}



//ArryList
static void ArrayList()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add("Bonjour");
    arrayList.Add(42);
    arrayList.Add(3.14);
    Console.WriteLine("Contenu de l'ArrayList :");
    foreach (var item in arrayList)
    {
        Console.WriteLine(item);
    }
}

//Dictionnaires

static void Dictionnaires()
{
    var AnnuaireTelephonique = new Dictionary<string, int>();

    AnnuaireTelephonique.Add("Alice", 123456789);
    AnnuaireTelephonique.Add("Bob", 987654321);
    AnnuaireTelephonique["Jean"] = 555555555;

    Console.WriteLine("Numéro de téléphone de Bob : " + AnnuaireTelephonique["Bob"]);

}

//Trier & Linq

static void Trier()
{
    var nombres = new List<int> { 5, 2, 9, 1, 5, 6 };
    nombres.Sort();
    Console.WriteLine("Nombres triés : " + string.Join(", ", nombres));

    var noms = new List<string> { "Charlie", "Alice", "Bob", "Marguerite", "Perla", "Alphonse", "Juliette", "Mario", "Claire" };
    Console.WriteLine("Liste triées en ordre de longueur et alphtabétique : ");
    noms.OrderBy(noms => noms.Length)
        .ThenBy(noms => noms)
        .ToList()
        .ForEach(nom => Console.WriteLine(nom));

    Console.WriteLine("Noms avec plus de 4 caractères et se terminant par e: ");
    noms.Where(nom => nom.Length > 4 && nom.EndsWith('e'))
        .ToList()
        .ForEach(nom => Console.WriteLine(nom));
}

Trier();