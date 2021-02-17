using _02Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02Challenges_Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private ClaimRepository _repo;
        private Claim newClaim;


        [TestInitialize]
        public void Seed()
        {
            _repo = new ClaimRepository();
            newClaim = new Claim();
        }

        [TestMethod]
        public void AddClaimToQueueTest()
        {
            _repo.AddClaimToQueue(newClaim);

            int expected = 1;
            int actual = _repo.GetAllClaims().Count;

            Assert.AreEqual(actual, expected);
        }
    }
}
