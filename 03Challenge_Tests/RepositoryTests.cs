using _03Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03Challenge_Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private EmployeeBadgeRepository _repo;
        private EmployeeBadge _employeeBadge;
        [TestMethod]
        public void AddBadgeToDictionaryTest()
        {
            _repo.AddBadgeToDictionary(_employeeBadge);
            int expected = 1;
            int actual = _repo.GetDictionary().Count;
            Assert.AreEqual(actual, expected);
        }
    }
}
