using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Challenge_Repository
{
    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public decimal MealPrice { get; set; }
        public string MealIngredients { get; set; }
        // May change later

        public MenuItem() { }

        public MenuItem(int mealNumber, string mealName, string mealDescription, decimal mealPrice, string mealIngredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealPrice = mealPrice;
            MealIngredients = mealIngredients;
        }
    }
}
