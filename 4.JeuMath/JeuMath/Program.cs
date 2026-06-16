using System;

namespace JeuMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int totalReussi = 0;

            Console.WriteLine("Bienvenu dans le jeu de mathématiques, vous avez 5 questions");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nQuestion numéro {i + 1}");
                int nombreUn = rand.Next(1, 11);
                int nombreDeux = rand.Next(1, 11);
                string[] listeOperateurs = { "+", "-", "*", "/"};

                string opretateur = listeOperateurs[rand.Next(0, 4)];

                float result = 0.0f, proposition = 0.0f;

                switch (opretateur)
                {
                    case "+":
                        result = nombreUn + nombreDeux;
                        Console.Write($"{nombreUn} + {nombreDeux} = ");
                        break;

                    case "-":
                        result = nombreUn - nombreDeux;
                        Console.Write($"{nombreUn} - {nombreDeux} = ");
                        break;

                    case "*":
                        result = nombreUn * nombreDeux;
                        Console.Write($"{nombreUn} * {nombreDeux} = ");
                        break;

                    case "/":
                        result = (float)nombreUn / nombreDeux;
                        Console.Write($"{nombreUn} / {nombreDeux} = ");
                        break;
                }

                proposition = float.Parse(Console.ReadLine());

                if(result == proposition)
                {
                    Console.WriteLine("Bonne réponse");
                    totalReussi++;
                }
                else
                    Console.WriteLine("Mauvaise réponse ");
            }

            Console.WriteLine($" Résultat global : {Appreciation(totalReussi)}");

        }

        static string Appreciation(int total)
        {
            return total switch
            {
                0 => "Nul",
                1 => "Médiocre",
                2 => "Pas mal",
                3 => "Bien",
                4 => "Très bien",
                5 => "Excellent",
                _ => "Note invalide"
            };
        }

    }
}