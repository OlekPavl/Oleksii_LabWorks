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

        public void AddFlightStatus(FlightInformation flight, FlightStatusHandler callback)
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
                    flightsStatusArray[i].Notify += callback;
                    break;
                }
            }

        }
        public void CheckUpdateFlightStatusArray()
        {
            foreach (var item in flightsStatusArray)
            {
                item.CheckUpdateStatus();
            }
        }
        public void DisplayFlightsStatusArray()
        {
            new FlightsBoard(flightsStatusArray).DisplayFlightStatus();
        }
        public void AddElementToArray(ref FlightStatus[] array, int count, FlightStatus flight)
        {

            FlightStatus[] tempArray = new FlightStatus[count];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = flight;
                    break;
                }
            }

        }
        public void SerachByFlightNumber(int number)
        {
            int counter = 0;
            FlightStatus[] tempArray = new FlightStatus[0];

            for (int i = 0; i < flightsStatusArray.Length; i++)
            {
                if (flightsStatusArray[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsStatusArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplayFlightStatus();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
    }
}
