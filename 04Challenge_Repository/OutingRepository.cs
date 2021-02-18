using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Challenge_Repository
{
    public class OutingRepository
    {
        private readonly List<Outing> _listOfOutings = new List<Outing>();

        public bool AddOutingToList(Outing outing)
        {
            int startingCount = _listOfOutings.Count;
            _listOfOutings.Add(outing);

            bool wasAdded = _listOfOutings.Count > startingCount;
            return wasAdded;
        }

        public List<Outing> DisplayOutings()
        {
            return _listOfOutings;
        }
        
        //Not Finished

        /*public decimal DiplayTotalCost()
        {
            for (decimal cost = 0; cost += ; )
            {

            }
        }*/
    }
}
