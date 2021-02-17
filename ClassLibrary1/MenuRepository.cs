using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Challenge_Repository
{
    public class MenuRepository
    {
        private readonly List<MenuItem> _menuItems = new List<MenuItem>();

        public int Count
        {
            get
            {
                return _menuItems.Count;
            }
        }

        // Create
        public bool AddItemToList(MenuItem item)
        {
            int startingCount = _menuItems.Count;
            _menuItems.Add(item);

            bool wasAdded = _menuItems.Count > startingCount;
            return wasAdded;
        }
        // Read
        public List<MenuItem> GetItemList()
        {
            return _menuItems;
        }
        // Delete
        public bool RemoveItemFromList(string mealName)
        {

            MenuItem contentToDelete = GetItemByName(mealName);
            return _menuItems.Remove(contentToDelete);
        }


        // Helper
        public MenuItem GetItemByName(string mealName)
        {
            foreach (MenuItem item in _menuItems)
            {
                if (item.MealName.ToLower() == mealName.ToLower())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
