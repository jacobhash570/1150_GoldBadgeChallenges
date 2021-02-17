using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Challenge_Repository
{
    public class ClaimRepository
    {
        private Queue<Claim> _queueOfClaims = new Queue<Claim>();

        public void AddClaimToQueue(Claim newclaim)
        {
            _queueOfClaims.Enqueue(newclaim);

        }
        public Queue<Claim> GetAllClaims()
        {
            return _queueOfClaims;
        }

        public void DequeueClaim()
        {
            _queueOfClaims.Dequeue();

        }
    }
}
