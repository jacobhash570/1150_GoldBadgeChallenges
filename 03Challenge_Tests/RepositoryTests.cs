using _03Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03Challenge_Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private EmployeeBadgeRepository _repo;
        private EmployeeBadge _employeeBadge;
        private EmployeeBadge testBadge;


        [TestInitialize]
        public void Seed()
        {
            _repo = new EmployeeBadgeRepository();
            EmployeeBadge testBadge = new EmployeeBadge();
            testBadge.DoorAccess = new List<string>();

            testBadge.BadgeID = 1;
            testBadge.DoorAccess.Add("A1");
            _repo.AddBadgeToDictionary(testBadge);

        }

        [TestMethod]
        public void AddBadgeToDictionaryTest()
        {
            _repo = new EmployeeBadgeRepository();
            _employeeBadge = new EmployeeBadge();

            _repo.AddBadgeToDictionary(_employeeBadge);
            int expected = 1;
            int actual = _repo.GetDictionary().Count;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GiveAccessTest()
        {           
            int badgeId = 1;
            string doorAccess = "A2";
            _repo.GiveAccess(badgeId, doorAccess);
            string expected = "A2";
            string actual = doorAccess;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void RemoveAccessTest()
        {
            int badgeId = 1;
            string doorAccess = "A1";
            _repo.RemoveAccess(badgeId, doorAccess);
            string expected = "A1";
            string actual = doorAccess;
            Assert.AreEqual(actual, expected);

        }
    }
}
