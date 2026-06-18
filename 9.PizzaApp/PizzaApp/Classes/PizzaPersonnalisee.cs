using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaApp.Utils;
using PizzaApp.Classes;

namespace PizzaApp.Classes
{
    internal class PizzaPersonnalisee : Pizza
    {
        private const float INGREDIENT_PRICE = 1.0f;

        public PizzaPersonnalisee(string name, float price, bool vegetarian, List<string> listeIngredients)
                                    : base(name, price, vegetarian, listeIngredients)
        {
        }

        public float GetPrice()
        {
            return Price;
        }

        public void AjouterIngredientParConsole()
        {
            while (true)
            {
                Console.Write("Entrez un ingrédient à ajouter (ou 'fin' pour terminer): ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                if (input.Equals("fin", StringComparison.OrdinalIgnoreCase))
                    break;

                AJoutIngredient(input);
                Price += INGREDIENT_PRICE;

                Console.WriteLine(
                    $"{input} ajouté! (+{INGREDIENT_PRICE}$) Prix actuel: {Price:0.00}$");
            }
        }

        public void AfficherPizzaPersonnalisee()
        {
            AfficherPizza();
        }
    }
}