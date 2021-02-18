using _04Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Challenge_Console
{
    public class ProgramUI
    {
        private OutingRepository _repo = new OutingRepository();

        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                Console.WriteLine("Hello, Accountants. Please select a option from the menu.\n" +
                    "1. Display all outings.\n" +
                    "2. Add an outing.\n" +
                    "3. View combined cost for all outings.\n" +
                    "4. View outing costs by type.\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        DisplayAllOutings();
                        break;
                    case "2":
                        AddOuting();
                        break;
                    case "3":
                        //TotalCost();
                        break;
                    case "4":
                       //CostPerOuting();
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Number: ");
                        break;
                }
                Console.WriteLine("Please Press Any Key to Continue: ");
                Console.WriteLine();
            }
        }

        public void DisplayAllOutings()
        {
            Console.Clear();
            List<Outing> outing = _repo.DisplayOutings();
            foreach (Outing partOfOuting in outing)
            {
                Console.WriteLine($"Event Type: {partOfOuting.EventType}\n" +
                    $"Number of Attendees: {partOfOuting.NumberOfAttendees}\n" +
                    $"Outing Date: {partOfOuting.Date}\n" +
                    $"Total Cost per Attendee: {partOfOuting.CostPerPeson} \n" +
                    $"Total Outing Cost: {partOfOuting.TotalCost}");
            }
        }

        public void AddOuting()
        {
            Outing newOuting = new Outing();

            Console.WriteLine("Enter the Outing Type:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");
            string outingType = Console.ReadLine();
            int outingTypeNumber = int.Parse(outingType);

            newOuting.EventType = (EventType)outingTypeNumber;

            Console.WriteLine("Enter the Number of Attendees: ");
            newOuting.NumberOfAttendees = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Date of the Outing(e.g. 08/28/1996): ");
            newOuting.Date = DateTime.Parse(Console.ReadLine());

            _repo.AddOutingToList(newOuting);
        }
        //Not Finished
        /*public void TotalCost()
        {
            decimal totalCost = _repo.DiplayTotalCost();
            foreach (Outing cost in _repo)
            {
                decimal cost = _repo.DiplayTotalCost();

            }
        }

        public void CostPerOuting()
        {

        }
        */
    }
}
