using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Challenge_Repository
{
    public class EmployeeBadgeRepository
    {
        private Dictionary<int, List<string>> _badgeinfo = new Dictionary<int, List<string>>();

        public void AddBadgeToDictionary(EmployeeBadge newbadge)
        {
            _badgeinfo.Add(newbadge.BadgeID, newbadge.DoorAccess);
        }

        public void GiveAccess(int badgeID, string doorAccess)
        {
            List<string> access = _badgeinfo[badgeID];
            access.Add(doorAccess);
        }

        public void RemoveAccess(int badgeID, string doorAccess)
        {
            List<string> access = _badgeinfo[badgeID];
            access.Remove(doorAccess);
        }
        public Dictionary<int, List<string>> GetDictionary()
        {
            return _badgeinfo;
        }

    }
}
