using _01Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class RepositoryTests
    {
        private MenuRepository _menuRepository;
        private MenuItem _Hotdog;

        [TestMethod]
        public void Seed()
        {
            _Hotdog = new MenuItem(2, "Hotdog", "Sausage in a bun.", 1.00m, "Sausage, Bread, Ketchup, Mustard");
            MenuItem Cheeseburger = new MenuItem(
                1,
                "Cheeseburger",
                "Hamburger topped with cheese.",
                3.00m,
                "Bread, Beef, Cheeese, Tomato, Lettuce, Onion");
            _menuRepository.AddItemToList(Cheeseburger);
        }
        [TestMethod]
        public void AddTest()
        {
            MenuItem item = new MenuItem(
                2,
                "Hamburger",
                "Beef on a bun.",
                2.00m,
                "Bread, Beef, Tomato, Lettuce, Onion");
            bool wasAdded = _menuRepository.AddItemToList(item);
            Console.WriteLine(_menuRepository.Count);
            Console.WriteLine(wasAdded);
            Console.WriteLine(item.MealName);

            Assert.IsTrue(wasAdded);

        }

        [TestMethod]
        public void GetItemByName_CorrectResult()
        {
            MenuItem searchResult = _menuRepository.GetItemByName("hotdog");
            Assert.AreEqual(searchResult, _Hotdog);
        }

        [TestMethod]
        public void DeleteContent_ShouldDelete()
        {
            bool wasRemoved = _menuRepository.RemoveItemFromList("hotdog");
            Assert.IsTrue(wasRemoved);

        }
    }
}
