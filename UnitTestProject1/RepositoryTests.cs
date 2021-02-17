using _01Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01Challenge_Test
{
    [TestClass]
    public class RepositoryTests
    {
        private MenuRepository _menuRepository;
        private MenuItem _Hotdog;

        [TestInitialize]
        public void Seed()
        {
            _menuRepository = new MenuRepository();
            _Hotdog = new MenuItem(2, "Hotdog", "Sausage in a bun.", 1.00m, "Sausage, Bread, Ketchup, Mustard");
            MenuItem Cheeseburger = new MenuItem(
                1,
                "Cheeseburger",
                "Hamburger topped with cheese.",
                3.00m,
                "Bread, Beef, Cheeese, Tomato, Lettuce, Onion");
            _menuRepository.AddItemToList(Cheeseburger);
            _menuRepository.AddItemToList(_Hotdog);
        }
        [TestMethod]
        public void AddItemToListTest()
        {
            MenuItem Hamburger = new MenuItem(
                2,
                "Hamburger",
                "Beef on a bun.",
                2.00m,
                "Bread, Beef, Tomato, Lettuce, Onion");
            bool wasAdded = _menuRepository.AddItemToList(Hamburger);

            Assert.IsTrue(wasAdded);

        }

        [TestMethod]
        public void GetItemByNameTest()
        {
            MenuItem searchResult = _menuRepository.GetItemByName("Hotdog");
            Assert.AreEqual(searchResult, _Hotdog);
        }

        [TestMethod]
        public void DeleteContentTest()
        {
            bool wasRemoved = _menuRepository.RemoveItemFromList("Hotdog");
            Assert.IsTrue(wasRemoved);

        }
    }
}
