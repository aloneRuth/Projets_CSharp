// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] sujets = {
    "Le développeur", "L'ordinateur", "Un robot", "L'intelligence artificielle", "Le chat",
    "L'étudiant", "Le serveur", "Un algorithme", "La ligne de code", "Le hacker",
    "Le bug", "Le compilateur", "Un programmeur", "La base de données", "Le système"
};
string[] verbes = {
    "analyse", "compile", "optimise", "génère", "corrige",
    "supprime", "exécute", "bloque", "sauvegarde", "explore",
    "transforme", "crée", "met à jour", "teste", "écoute"
};
string[] complements = {
    "le code source", "une application web", "les données sensibles", "un projet informatique", "le framework .NET",
    "une erreur de syntaxe", "le serveur cloud", "une interface utilisateur", "le script Python", "une fonction asynchrone",
    "la mémoire vive", "un algorithme complexe", "les fichiers de configuration", "une base de données SQLite", "le terminal"
};

Console.Title = "Générateur de phrases aléatoires";

Console.WriteLine("Combien de phrase voulez-vous");
var nombreDePhrases = int.Parse(Console.ReadLine() ?? "10");

Random random = new();
List<string> listePhrases = [];

for (int i = 0; i < nombreDePhrases; i++)
{
    string phrase = $"{sujets[random.Next(sujets.Length)]} " +
                    $"{verbes[random.Next(verbes.Length)]} " +
                    $"{complements[random.Next(complements.Length)]}.";
    if (!listePhrases.Contains(phrase))
    {
        listePhrases.Add(phrase);
    }
}

Console.WriteLine("\nPhrases générées :");
foreach (var phrase in listePhrases)
{
    Console.WriteLine(phrase);
}
