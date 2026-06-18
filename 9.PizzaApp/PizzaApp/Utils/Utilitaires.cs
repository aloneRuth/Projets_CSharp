using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaApp.Classes;

namespace PizzaApp.Utils
{
    public static class Utilitaires
    {
        public static string FormattedString(string chaine)
        {
            if (string.IsNullOrWhiteSpace(chaine))
                return chaine;

            return chaine[0].ToString().ToUpper() +
                   chaine.Substring(1).ToLower();
        }

        public static List<string> FormattedList(List<string> liste)
        {
            return [.. liste.Select(item => FormattedString(item))];
        }

        public static List<string> AlphabeticSortedList(List<string> liste)
        {
            List<string> sortedList = [.. liste];
            sortedList.Sort();
            return sortedList;
        }

        public static List<Pizza> SortedListByPriceAsc(List<Pizza> liste)
        {
            List<Pizza> sortedList = [.. liste];
            return sortedList.OrderBy(pizza => pizza.Price).ToList();
        }

        public static List<Pizza> SortedListByPriceDesc(List<Pizza> liste)
        {
            List<Pizza> sortedList = [.. liste];
            return sortedList.OrderByDescending(pizza => pizza.Price).ToList();
        }

        public static string BiggerItem(List<Pizza> liste)
        {
            return liste.OrderByDescending(pizza => pizza.Price).Take(1).FirstOrDefault()?.Name ?? "Aucune pizza trouvée";
        }

        public static string SmallerItem(List<Pizza> liste)
        {
            return liste.OrderBy(pizza => pizza.Price).Take(1).FirstOrDefault()?.Name ?? "Aucune pizza trouvée";
        }
    }
}
