using System;

namespace ExerciceUn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom = "";
            int nextAge = 0;

            while (nom == "")
            {
                Console.WriteLine("Quel est votre nom?");
                nom = Console.ReadLine().Trim();

                if (nom == "")
                    Console.WriteLine("Le nom ne doit pas être vide");
            }
            while (nextAge <= 0)
            {
                Console.WriteLine("Quel est votre âge?");
                string age = Console.ReadLine();

                try
                {
                    nextAge = int.Parse(age);

                    if (nextAge < 0)
                        Console.WriteLine("L'âge ne doit pas être négatif");

                }
                catch
                {
                    Console.WriteLine("Erreur");
                }

            }

            Console.WriteLine($"Bonjour, vous vous appellez {nom}, vous avez {nextAge} ans");

        }
    }
}