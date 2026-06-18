using System.Linq;
using PizzaApp.Utils;

namespace PizzaApp.Classes
{
    public class Pizza
    {
        public string Name { get; private set; }
        public float Price { get; protected set; }
        public bool Vegetarian { get; private set; }
        public List<string> ListeIngredients { get; private set; } = new();

        public Pizza(string name, float price, bool vegetarian, List<string> ListeIngedients)
        {
            Name = name;
            Price = price;
            Vegetarian = vegetarian;
            this.ListeIngredients = ListeIngedients;
        }

        public void AJoutIngredient(string ingredient)
        {
            ListeIngredients.Add(ingredient);
        }

        public void AfficherPizza() {
            string vegStatus = Vegetarian ? " (V)" : "";
            string formattedPrice = Price.ToString("0.00");
            string formatttedName = Utilitaires.FormattedString(Name);

            Console.WriteLine($"Nom:{formatttedName}{vegStatus} - {formattedPrice}$");
            if (ListeIngredients.Count > 0)
            {
                Console.WriteLine("Ingrédients:");
                foreach (var ingredient in Utilitaires.FormattedList(ListeIngredients))
                {
                    Console.WriteLine($"- {ingredient}");
                }
            }
        }
    }
}