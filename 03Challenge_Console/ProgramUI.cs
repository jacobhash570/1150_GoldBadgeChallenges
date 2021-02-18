using _03Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Challenge_Console
{
    public class ProgramUI
    {
        private EmployeeBadgeRepository _repo = new EmployeeBadgeRepository();
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Hello, Secutiry Administrator. What would you like to do?\n" +
                "1. Add a Badge.\n" +
                "2. Update a Badge.\n" +
                "3. List all Badges.\n" +
                "4. Exit.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ViewAllBadges();
                        break; ;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
            }
        }

        private void AddBadge()
        {
            EmployeeBadge newbadge = new EmployeeBadge();
            newbadge.DoorAccess = new List<string>();
            bool needsMoreAccess = true;

            Console.WriteLine("Enter the BadgeID Number: ");
            newbadge.BadgeID = int.Parse(Console.ReadLine());

            while (needsMoreAccess)
            {
                Console.WriteLine("Enter a door it needs access to(e.g. 'A5', 'A6', or 'B4'): ");
                newbadge.DoorAccess.Add(Console.ReadLine());

                Console.WriteLine("Do you need to more door access? (y/n)");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "y":
                        needsMoreAccess = true;
                        break;
                    case "n":
                        needsMoreAccess = false;
                        break;
                }
            }

            _repo.AddBadgeToDictionary(newbadge);

            Console.WriteLine("Press any key to return to the Main Menu...");
            Console.ReadLine();
            Console.Clear();
        }

        private void UpdateBadge()
        {
            EmployeeBadge badge = new EmployeeBadge();
            badge.DoorAccess = new List<string>();

            Console.WriteLine("Please enter a BadgeID Number");
            badge.BadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine($"BadgeID Number: {badge.BadgeID}");
            foreach (string door in badge.DoorAccess)
            {
                Console.WriteLine($"BadgeID Number: {badge.DoorAccess} has access to" + door);
            }

            Console.WriteLine("Please select an option:\n" +
                    "1. Remove Door Access\n" +
                    "2. Add Door Access");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    RemoveDoorAccess(badge.BadgeID);
                    break;
                case "2":
                    AddDoorAccess(badge.BadgeID);
                    break;
                default:
                    Console.WriteLine("Please enter a valid number.");
                    break;
            }
        }

        private void RemoveDoorAccess(int badgeID)
        {
            Console.WriteLine("Enter the Door Access you want removed: ");
            string doorAccess = Console.ReadLine();
            _repo.RemoveAccess(badgeID, doorAccess);
            Console.WriteLine("Door Access has been removed.");
            Console.WriteLine("Press any key to return to the Main Menu...");
            Console.ReadLine();
            Console.Clear();

        }

        private void AddDoorAccess(int badgeID)
        {
            Console.WriteLine("Enter the Door Access you want to add:");
            string doorAccess = Console.ReadLine();
            _repo.GiveAccess(badgeID, doorAccess);
            Console.WriteLine("Door Acces has been added.");
            Console.WriteLine("Press any key to return to the Main Menu...");
            Console.ReadLine();
            Console.Clear();
        }

        private void ViewAllBadges()
        {
            Dictionary<int, List<string>> allBadges = _repo.GetDictionary();
            foreach (KeyValuePair<int, List<string>> badgeID in allBadges)
            {
                Console.WriteLine($"BadgeID Number: {badgeID.Key}");
                foreach (string door in badgeID.Value)
                {
                    Console.WriteLine(door);
                }
            }
            Console.WriteLine("Press any key to return to the Main Menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
