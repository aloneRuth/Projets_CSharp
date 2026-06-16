using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotDePasseOutils
{
    static class tools
    {
        struct Intervalle
        {
            public int Min;
            public int Max;
            public Intervalle(int min, int max) { Min = min; Max = max; }
        }
        private static Random random = new Random();

        private static List<Intervalle> caracteresAscii = new List<Intervalle>
        {
            new Intervalle(97, 123),
            new Intervalle(65, 91),
            new Intervalle(48, 58),
            new Intervalle(33, 127)
        };


        public static char ObtenirCharactere(int choix)
        {
            int code = 0;

            switch(choix)
            {
                case (1):
                    code = random.Next(caracteresAscii[0].Min, caracteresAscii[0].Max);
                    break;
                case (2):
                    int type = random.Next(0, 2);
                    code = random.Next(caracteresAscii[type].Min, caracteresAscii[type].Max);
                    break;
                case (3):
                    int type3 = random.Next(0, 3);
                    code = random.Next(caracteresAscii[type3].Min, caracteresAscii[type3].Max);
                    break;
                case (4):
                    code = random.Next(caracteresAscii[3].Min, caracteresAscii[3].Max);
                    break;
            }
            return (char)code;
        }

        public static int ObtenirNombre(string message, int min, int max)
        {
            string chaineEntree = "";
            int nombre = 0;

            while (true)
            {
                Console.WriteLine(message);
                chaineEntree = Console.ReadLine()?.Trim();

                if (chaineEntree == "")
                    Console.WriteLine("Vous devez entrer un nombre");

                try
                {
                    nombre = int.Parse(chaineEntree);

                    if (nombre < min || nombre > max)
                        Console.WriteLine("Le nombre que vous avez entré est invalide, recommencez");

                    return nombre;
                }
                catch
                {
                    Console.WriteLine("Erreur lors de la convertion");
                }
            }
        }

    }
}
