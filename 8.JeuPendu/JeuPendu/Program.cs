using System;
using System.Collections.Generic;

string[] tableauMots =
{
    "AUTOMNE", "COLLEGE", "ORDINATEUR", "FICHIER", "LANGAGE",
    "SESSION", "ECONOMIE", "SOUSBOIS", "DIMANCHE", "JANVIER"
};

int nbrePartie = 0;
int nbreVictoire = 0;
Random random = new Random();
Console.Title = "Jeu du Pendu";
char decision;

do
{
    nbrePartie++;
    Console.Clear();
    AfficherHeader(nbrePartie, nbreVictoire, false);

    if (Partie())
        nbreVictoire++;

    AfficherHeader(nbrePartie, nbreVictoire, false);

    Console.SetCursorPosition(0, 5);
    Console.Write("Voulez-vous jouer une nouvelle partie ? (O/N) : ");
    decision = char.ToUpper(Console.ReadKey().KeyChar);

} while (decision == 'O');

Console.Clear();
AfficherHeader(nbrePartie, nbreVictoire, true);

bool Partie()
{
    string motADeviner = tableauMots[random.Next(tableauMots.Length)];
    char[] motAffiche = new string('_', motADeviner.Length).ToCharArray();
    List<char> lettresEssayees = new();
    int nbreEchec = 0;

    while (nbreEchec < 6 && new string(motAffiche) != motADeviner)
    {
        // Effacer seulement la zone de jeu (sous le header)
        Console.SetCursorPosition(0, 4);
        ClearZoneJeu();

        AfficherHeader(nbrePartie, nbreVictoire, false);

        Console.SetCursorPosition(0, 4);
        Console.WriteLine($"Lettres essayées : {string.Join(", ", lettresEssayees)}");
        Console.WriteLine();
        Console.WriteLine($"Mot à deviner : {string.Join(" ", motAffiche)}");
        Console.WriteLine();
        AfficherPendu(nbreEchec);

        Console.Write("\nEntrez une lettre : ");
        char lettre = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (!char.IsLetter(lettre))
        {
            Console.WriteLine("Veuillez entrer une lettre.");
            Console.ReadKey();
            continue;
        }

        if (lettresEssayees.Contains(lettre))
        {
            Console.WriteLine("Vous avez déjà essayé cette lettre.");
            Console.ReadKey();
            continue;
        }

        lettresEssayees.Add(lettre);

        if (motADeviner.Contains(lettre))
        {
            for (int i = 0; i < motADeviner.Length; i++)
                if (motADeviner[i] == lettre)
                    motAffiche[i] = lettre;
        }
        else
        {
            nbreEchec++;
        }
    }

    Console.SetCursorPosition(0, 4);
    ClearZoneJeu();

    Console.SetCursorPosition(0, 4);
    AfficherPendu(nbreEchec);
    Console.WriteLine($"\nMot : {string.Join(" ", motAffiche)}");

    if (new string(motAffiche) == motADeviner)
    {
        Console.WriteLine($"Félicitations ! Vous avez trouvé le mot : {motADeviner}");
        return true;
    }

    Console.WriteLine($"Dommage ! Le mot était : {motADeviner}");
    return false;
}

static void AfficherHeader(int nbrePartie, int nbreVictoire, bool final)
{
    Console.SetCursorPosition(0, 0);

    if (final)
    {
        Console.WriteLine("Merci d'avoir joué !          ");
        Console.WriteLine($"Parties jouées : {nbrePartie}");
        Console.WriteLine($"Victoires      : {nbreVictoire}");
        Console.WriteLine($"Échecs         : {nbrePartie - nbreVictoire}");
    }
    else
    {
        Console.WriteLine("=== Jeu du Pendu ===          ");
        Console.WriteLine($"Partie   : {nbrePartie}");
        Console.WriteLine($"Victoires: {nbreVictoire}");
        Console.WriteLine($"Échecs   : {nbrePartie - 1 - nbreVictoire}");
    }
}

static void ClearZoneJeu()
{
    string vide = new string(' ', Console.WindowWidth);
    for (int i = 4; i < 30; i++)
    {
        Console.SetCursorPosition(0, i);
        Console.Write(vide);
    }
    Console.SetCursorPosition(0, 4);
}

static void AfficherPendu(int nbreEchec)
{
    string[] pendu =
    {
        "  +---+",
        "  |   |",
        "      |",
        "      |",
        "      |",
        "      |",
        "========="
    };

    if (nbreEchec > 0) pendu[2] = "  O   |";
    if (nbreEchec > 1) pendu[3] = "  |   |";
    if (nbreEchec > 2) pendu[3] = " /|   |";
    if (nbreEchec > 3) pendu[3] = " /|\\  |";
    if (nbreEchec > 4) pendu[4] = " /    |";
    if (nbreEchec > 5) pendu[4] = " / \\  |";

    foreach (string ligne in pendu)
        Console.WriteLine(ligne);
}