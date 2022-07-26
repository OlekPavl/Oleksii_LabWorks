using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    class Passenger : IPassenger
    {
        public string PassengerFlightNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Nationality { get; set; }
        public string Passport { get; set; }
        public string DateOfBirthday { get; set; }
        public SexType Sex { get; set; }
        public FlightClass Class { get; set; }
    }
}
