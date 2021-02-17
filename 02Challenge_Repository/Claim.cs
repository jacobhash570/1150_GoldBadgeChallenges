using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Challenge_Repository
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft,
    }
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                if (DateOfClaim < DateOfIncident)
                    DateOfClaim = DateOfIncident;

                TimeSpan difference = DateOfClaim - DateOfIncident;

                if (difference.Days <= 30)
                {
                    return true;
                }
                else
                    return false;

            }
        }

        public Claim() { }
        public Claim(int claimID, ClaimType claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }


    }
}
