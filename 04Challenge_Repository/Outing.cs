using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Challenge_Repository
{
    public enum EventType { Golf = 1, Bowling, AmusementPark, Concert }
    //public enum EventTypeCost { Golf = 20, Bowling = 10, AmusementPark = 40, Concert = 30}
    public class Outing
    {
        public EventType EventType { get; set; }
        public decimal NumberOfAttendees { get; set; }
        public DateTime Date { get; set; }
        public decimal CostPerPeson
        {
            get
            {
                switch (EventType)
                {
                    case EventType.Golf:
                        return 20m;
                    case EventType.Bowling:
                        return 10m;
                    case EventType.AmusementPark:
                        return 40m;
                    case EventType.Concert:
                        return 30m;
                    default:
                        return 0m;
                }
            }
        }
        public decimal TotalCost
        {
            get
            {
                decimal totalCost =  CostPerPeson * NumberOfAttendees;
                return totalCost;
            }
        }
        public Outing() { }
        public Outing(EventType eventType, int numberOfAttendees, DateTime date)
        {
            EventType = eventType;
            NumberOfAttendees = numberOfAttendees;
            Date = date;
        }
    }
}
