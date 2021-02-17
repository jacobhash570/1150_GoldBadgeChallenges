using _02Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Challenge_Console
{
    public class ProgramUI
    {
        public ClaimRepository _repo = new ClaimRepository();
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            Console.Clear();
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Select a Menu Option:\n" +
                    "1. See All Claims:\n" +
                    "2. Service the Next Claim:\n" +
                    "3. Enter a new claim:\n" +
                    "4. Exit.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        ShowNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Enter a Valid Number.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void CreateNewClaim()
        {
            Console.Clear();
            Claim newClaim = new Claim();
            {
                Console.WriteLine("Please enter the Claim ID: ");
                newClaim.ClaimID = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the Type of Claim:\n" +
                    "1. Car\n" +
                    "2. Home\n" +
                    "3. Theft");
                string claimTypeIput = Console.ReadLine();
                int claimTypeID = int.Parse(claimTypeIput);

                newClaim.ClaimType = (ClaimType)claimTypeID;

                Console.WriteLine("Please enter the Description: ");
                newClaim.Description = Console.ReadLine();

                Console.WriteLine("Please enter the Claim Amount: ");
                newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the Date of the Incident(e.g. 08/28/1996): ");
                newClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the Date of the Claim(e.g. 09/28/1996): ");
                newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());

                if (newClaim.IsValid)
                {
                    Console.WriteLine("This is a Vald Claim. ");
                }
                else { Console.WriteLine("This is Not a Valid Claim."); }
            }

            _repo.AddClaimToQueue(newClaim);
            Console.ReadKey();
            Console.Clear();
        }

        private void ShowAllClaims()
        {
            Console.Clear();
            Queue<Claim> queueOfClaims = _repo.GetAllClaims();
            foreach (Claim claim in queueOfClaims)
            {
                DisplayClaims(claim);
            }
            Console.ReadKey();
            Console.Clear();
        }
        private void DisplayClaims(Claim claim)
        {
            Console.WriteLine($"Claim ID: {claim.ClaimID}\n" +
                $"Claim Type: {claim.ClaimType}\n" +
                $"Description: {claim.Description}\n" +
                $"Claim Amount: {claim.ClaimAmount}\n" +
                $"Date of Incident{claim.DateOfIncident}\n" +
                $"Date of Claim{claim.DateOfClaim}\n" +
                $"Is Valid{claim.IsValid}\n");
        }

        private void ShowNextClaim()
        {
            Console.Clear();
            Console.WriteLine("Here are the details for the next claim to be handled:\n");

            Queue<Claim> anotherClaim = _repo.GetAllClaims();
            Claim nextClaim = anotherClaim.Peek();

            Console.WriteLine($"Claim ID: {nextClaim.ClaimID}\n" +
               $"Claim Type: {nextClaim.ClaimType}\n" +
               $"Description: {nextClaim.Description}\n" +
               $"Claim Amount: {nextClaim.ClaimAmount}\n" +
               $"Date of Incident{nextClaim.DateOfIncident}\n" +
               $"Date of Claim{nextClaim.DateOfClaim}\n" +
               $"Is Valid{nextClaim.IsValid}\n");
            Console.WriteLine("Do you want to take the claim? (y/n)");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "y":
                    anotherClaim.Dequeue();
                    Console.WriteLine("You have taken the claim.\n");
                    break;
                case "n":
                    Menu();
                    break;
                default:
                    Console.WriteLine("Please enter either 'y' or 'n'");
                    break;
            }
            Console.Clear();

        }
        public void ClaimIsValid(Claim newClaim)
        {
            if (newClaim.DateOfIncident.AddDays(30) <= newClaim.DateOfClaim)
            {
                Console.WriteLine("This Claim is Valid.");
            }
            else
            {
                Console.WriteLine("This Claim is NOT Valid.");
            }
        }

    }
}
