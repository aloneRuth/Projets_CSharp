using System;
using MotDePasseOutils;

namespace MotDePasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbreMotDePasse = 0;
            int longeurMotDePasse = 0;
            int choix = 0;

            Console.WriteLine("Bienvenue dans votre générateur de mot de passe");

            while(nbreMotDePasse == 0)
            {
                nbreMotDePasse = tools.ObtenirNombre("Combien de mot de passe voulez vous?", 0, 50);
            }

            string[] listeMotDePasse = new string[nbreMotDePasse];
            while (longeurMotDePasse==0)
            {
                longeurMotDePasse = tools.ObtenirNombre("Entrer la longueur du mot de passe", 0, 32);
            }

            while (choix == 0) 
            {
                choix = tools.ObtenirNombre("Vous voulez un mot de passe avec :\n" +
                                            "1 - Uniquement des minuscules \n" +
                                            "2 - Des majuscules et des munuscules\n" +
                                            "3 - Des lettres et des chiffres\n" +
                                            "4 - Des lettres, des chiffres et des caractères spéciaux", 0, 4);
            }

            for (int mot = 0; mot < nbreMotDePasse; mot++)
            {
                string motDePasse = "";
                for (int caractere = 0; caractere < longeurMotDePasse; caractere++)
                {
                    motDePasse += tools.ObtenirCharactere(choix);
                }

                listeMotDePasse[mot] = motDePasse;
            }

            foreach (var motDePasse in listeMotDePasse)
            {
                Console.WriteLine($"Mot de passe : {motDePasse}");
            }
        }
    }
}