using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Challenge_Repository
{
    public class EmployeeBadge
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }

        public EmployeeBadge() { }

        public EmployeeBadge(int badgeID, List<string> doorAccess)
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
        }
    }
}
