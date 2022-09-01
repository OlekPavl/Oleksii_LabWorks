using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    internal class FlightPassengerList
    {
        public int counter = 0;
        public Passenger[] flightPassengersArrayList = new Passenger[0];
        public Passenger[] emptyPassengerList;
        //List<int> flightPassengersList = new List<int>();

        public void AddPassengersToFlight(FlightInformation flight)
        {
            Random random = new Random();
            int numberOfPassengers = random.Next(10, 20);

            for (int i = 0; i < numberOfPassengers; i++)
            {
                counter++;

                Passenger[] tempArray = new Passenger[counter];
                for (int j = 0; j < flightPassengersArrayList.Length; j++)
                {
                    tempArray[j] = flightPassengersArrayList[j];
                }
                flightPassengersArrayList = tempArray;

                for (int j = 0; j < flightPassengersArrayList.Length; j++)
                {
                    if (flightPassengersArrayList[j] == null)
                    {
                        flightPassengersArrayList[j] = new Passenger(flight);
                        int number = GeneratePassportNumber();
                        flightPassengersArrayList[j].Passport = number;
                        flightPassengersArrayList[j].arrayPassenger[4] = number.ToString();
                        break;
                    }
                }

            }

            int GeneratePassportNumber()
            {
                Random random = new Random();

                int number;

                while (true)
                {
                    number = random.Next(1000, 9999);
                    bool status = false;
                    foreach (var item in flightPassengersArrayList)
                    {
                        if (number == item.Passport)
                        {
                            status = true;
                        }
                    }
                    if (status == false)
                    {
                        return number;
                    }
                }

            }

        }
        public void AddEmptyPassengersToFlight(int numberOfPassengers)
        {
            flightPassengersArrayList = new Passenger[numberOfPassengers];


            for (int i = 0; i < numberOfPassengers; i++)
            {
                flightPassengersArrayList[i] = new Passenger("empty");
            }
        }
        public void DisplayFlightPassengerArray()
        {
            new FlightsBoard(flightPassengersArrayList).DisplayFlightPassengerList();
        }
    }
}
