using PizzaApp.Classes;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Welcome to the Pizza App!");
        Console.WriteLine("==========================\n");

        Pizza pizza1 = new Pizza("Pepperoni", 14.99f, false, new List<string> { "Farine" });
        pizza1.AJoutIngredient("pepperoni");
        pizza1.AJoutIngredient("cheese");

        Pizza pizza2 = new Pizza("Margherita", 12.99f, true, new List<string> { "Piment" });
        pizza2.AJoutIngredient("Tomato Sauce");

        Pizza pizza3 = new Pizza("Veggie Delight", 13.99f, true, new List<string> { "" });
        pizza3.AJoutIngredient("Bell Peppers");
        pizza3.AJoutIngredient("Olives");

        Pizza pizza4 = new Pizza("BBQ Chicken", 15.99f, false, new List<string> { "Poulet" });

        Menu menu = new Menu();
        menu.AddPizza(pizza1);
        menu.AddPizza(pizza2);
        menu.AddPizza(pizza3);
        menu.AddPizza(pizza4);

        Console.WriteLine("=== PIZZAS STANDARDS ===\n");
        menu.ShowPizzas();
        menu.ShowMostExpensivePizza();
        menu.ShowCheapestPizza();

        // Pizza personnalisée
        Console.WriteLine("\n=== PIZZA PERSONNALISEE ===\n");
        PizzaPersonnalisee pizzaPerso = new PizzaPersonnalisee("Ma Pizza", 10.00f, true, new List<string> { "Pâte" });

        Console.WriteLine("Pizza de base créée:");
        pizzaPerso.AfficherPizzaPersonnalisee();
        Console.WriteLine();

        pizzaPerso.AjouterIngredientParConsole();

        Console.WriteLine("\n=== VOTRE PIZZA PERSONNALISEE ===\n");
        pizzaPerso.AfficherPizzaPersonnalisee();

    }
}