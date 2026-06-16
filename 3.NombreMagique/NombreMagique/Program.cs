using System;
using System.Data;

namespace NombreMagique
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int nombreVies = 4;
            int nombreMagique = rand.Next(1,11);
            bool trouve = false;

            while (nombreVies > 0 && trouve == false) 
            {
                Console.WriteLine($"Vies restantes : {nombreVies}");
                int proposition = AskNumber();
                trouve = Evaluate(nombreMagique, proposition);

                if(trouve == false)
                {
                    nombreVies--;
                }
            }

            if (trouve)
                Console.WriteLine($"Vous avez trouvé le Nombre Magique {nombreMagique}");
            else
                Console.WriteLine($"Vous avez perdu, le Nombre Magique était {nombreMagique}");

            Console.WriteLine("\nAppuie sur une touche pour quitter");
            Console.ReadKey();


        }

        static int AskNumber()
        {
            string chaineEntre = "";

            while(chaineEntre == "")
            {
                Console.WriteLine("Entrer un nombre en 1 et 10");
                chaineEntre = Console.ReadLine();

                if (chaineEntre == "")
                    Console.WriteLine("Vous devez entrer un nombre");

                try
                {
                    int nombre = int.Parse(chaineEntre);

                    if (nombre <= 0 || nombre > 10)
                        Console.WriteLine("Votre nombre doit être compris entre 1 et 10 !");
                    else
                        return nombre;
                }
                catch 
                { 
                    Console.WriteLine("Erreur lors de la convertion");
                }

            }

            return 0;
        }

        static bool Evaluate(int nombreMagique, int nbreEntre)
        {
            if (nbreEntre > nombreMagique)
                Console.WriteLine("Le nombre magique est plus petit");
            else if (nbreEntre < nombreMagique)
                Console.WriteLine("Le nombre magique est plus grand");
            else 
                return true;
                
            return false;
        }
    }
}