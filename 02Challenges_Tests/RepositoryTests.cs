using _02Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02Challenges_Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private ClaimRepository _repo;
        private Claim _claims;

        [TestMethod]
        public void AddClaimToQueueTest()
        {
            _repo.AddClaimToQueue(_claims);

            int expected = 1;
            int actual = _repo.GetAllClaims().Count;

            Assert.AreEqual(actual, expected);
        }
    }
}
