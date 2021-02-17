using _01Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Challenge_Console
{
    class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            Menu();
        }

        // Menu
        private void Menu()
        {
            Console.Clear();
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a Number for an Option: \n" +
                    "1. Create a New Menu Item\n" +
                    "2. View All Menu Items\n" +
                    "3. Delete a Menu Item\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateNewItem();
                        break;
                    case "2":
                        ViewAllItems();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Number: ");
                        break;
                }
                Console.WriteLine("Please Press Any Key to Continue: ");
                Console.WriteLine();

            }
        }

        private void CreateNewItem()
        {
            Console.Clear();
            MenuItem newItem = new MenuItem();

            Console.WriteLine("Enter the Name of the Item: ");
            newItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter the Description of the Item: ");
            newItem.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter the Ingredients of the Item: ");
            newItem.MealIngredients = Console.ReadLine();

            Console.WriteLine("Enter the Number of the Item: ");
            string itemNumberString = Console.ReadLine();
            newItem.MealNumber = int.Parse(itemNumberString);

            Console.WriteLine("Enter the Price of the Item");
            string priceString = Console.ReadLine();
            newItem.MealPrice = decimal.Parse(priceString);

            _menuRepo.AddItemToList(newItem);
        }
        private void ViewAllItems()
        {
            Console.Clear();
            List<MenuItem> menuItems = _menuRepo.GetItemList();
            foreach (MenuItem item in menuItems)
            {
                Console.WriteLine($"Name: {item.MealName}\n" +
                    $"Meal Number: {item.MealNumber}\n" +
                    $"Meal Description: {item.MealDescription}\n" +
                    $"Meal Price: {item.MealPrice} \n" +
                    $"Meal Ingredients: {item.MealIngredients}");
            }
        }
        private void DeleteMenuItem()
        {
            Console.Clear();
            ViewAllItems();
            Console.WriteLine("\nEnter the Name of Item to be Removed: ");
            string item = Console.ReadLine();
            bool wasDeleted = _menuRepo.RemoveItemFromList(item);
            if (wasDeleted)
            {
                Console.WriteLine("Item was deleted.");
            }
            else
            {
                Console.WriteLine("Item could not be deleted.");
            }
        }
    }
}
