using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    internal class FlightStatusList
    {
        public int counter = 0;
        public FlightStatus[] flightsStatusArray = new FlightStatus[0];

        public void AddFlightStatus(FlightInformation flight)
        {

            counter++;

            FlightStatus[] tempArray = new FlightStatus[counter];
            for (int i = 0; i < flightsStatusArray.Length; i++)
            {
                tempArray[i] = flightsStatusArray[i];
            }
            flightsStatusArray = tempArray;

            for (int i = 0; i < flightsStatusArray.Length; i++)
            {
                if (flightsStatusArray[i] == null)
                {
                    flightsStatusArray[i] = new FlightStatus(flight);
                    break;
                }
            }

        }
        public void DisplayFlightsStatusArray()
        {
            new FlightsBoard(flightsStatusArray).DisplayFlightStatus();
        }
    }
}
