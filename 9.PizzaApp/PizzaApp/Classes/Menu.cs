using PizzaApp.Classes;
using PizzaApp.Utils;

class Menu
{
    private List<Pizza> pizzas = new();

    public void AddPizza(Pizza pizza)
    {
        pizzas.Add(pizza);
    }

    public void ShowPizzas()
    {
        foreach (var pizza in pizzas)
        {
            pizza.AfficherPizza();
            Console.WriteLine();
        }
    }
    public void ShowPizzasByPriceAsc()
    {
        foreach (var pizza in Utilitaires.SortedListByPriceAsc(pizzas))
        {
            pizza.AfficherPizza();
            Console.WriteLine();
        }
    }

    public void ShowPizzasByPriceDesc()
    {
        foreach (var pizza in Utilitaires.SortedListByPriceDesc(pizzas))
        {
            pizza.AfficherPizza();
            Console.WriteLine();
        }
    }

    public void ShowMostExpensivePizza()
    {
        Console.WriteLine($"Pizza la plus chère: {Utilitaires.BiggerItem(pizzas)}");
    }

    public void ShowCheapestPizza()
    {
        Console.WriteLine($"Pizza la moins chère: {Utilitaires.SmallerItem(pizzas)}");
    }

    public void ShowVegetarianPizzas()
    {
        var vegetarianPizzas = pizzas.Where(pizza => pizza.Vegetarian).ToList();
        if (vegetarianPizzas.Count == 0)
        {
            Console.WriteLine("Aucune pizza végétarienne disponible.");
            return;
        }
        Console.WriteLine("Pizzas végétariennes:");
        foreach (var pizza in vegetarianPizzas)
        {
            pizza.AfficherPizza();
            Console.WriteLine();
        }
    }
}
