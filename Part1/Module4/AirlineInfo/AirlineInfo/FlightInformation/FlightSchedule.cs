using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    class FlightSchedule
    {
        public int counter = 0;
        public FlightInformation[] flightsArray = new FlightInformation[0];

        public FlightInformation this[int index]
        {
            get
            {
                if (index >= 0 && index < flightsArray.Length)
                {
                    return flightsArray[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < flightsArray.Length)
                {
                    flightsArray[index] = value;
                }
            }
        }
        public void AddFlight()
        {

            counter++;

            FlightInformation[] tempArray = new FlightInformation[counter];
            for (int i = 0; i < flightsArray.Length; i++)
            {
                tempArray[i] = flightsArray[i];
            }
            flightsArray = tempArray;

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i] == null)
                {
                    flightsArray[i] = new FlightInformation();
                    int number = GenerateFlightNumber();
                    flightsArray[i].FlightNumber = number;
                    flightsArray[i].arrayFlightInformation[0] = number.ToString();
                    break;
                }
            }

            int GenerateFlightNumber()
            {
                Random random = new Random();

                int number;

                while (true)
                {
                    number = random.Next(1, 500);
                    bool status = false;
                    foreach (var item in flightsArray)
                    {
                        if (number == item.FlightNumber)
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
        public void DisplayFlightsArray()
        {
            new FlightsBoard(flightsArray).DisplaySchedule();
        }
        public void DisplayPriceList()
        {
            new FlightsBoard(flightsArray).DisplayPriceList();
        }
        public void AddElementToArray(ref FlightInformation[] array, int count, FlightInformation flight)
        {

            FlightInformation[] tempArray = new FlightInformation[count];
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
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        public void SerachByDepartureCity(string name)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].CityOfDeparture == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        public void SerachByDeparturePort(string name)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].PortOfDeparture == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        public void SerachByTimeOfDeparture(DateTime time)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].DepartureDateTime == time)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        public void SerachByArrivalCity(string name)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].CityOfArrival == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        public void SerachByArrivalPort(string name)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].PortOfArrival == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        public void SerachByTimeOfArrival(DateTime time)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].ArrivalDateTime == time)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        public void SearchTheNearestOneHourFlightFromPort(DateTime time, string departurePort)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].DepartureDateTime == time)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }

                if (flightsArray[i].PortOfDeparture == departurePort)
                {
                    if (flightsArray[i].DepartureDateTime.Date == time.Date)
                    {
                        int value = Math.Abs((flightsArray[i].DepartureDateTime.Hour * 60 + flightsArray[i].DepartureDateTime.Minute) - (time.Hour * 60 + time.Minute));
                        Console.WriteLine(value);

                        if (value <= 60)
                        {
                            counter++;
                            AddElementToArray(ref tempArray, counter, flightsArray[i]);
                        }
                    }
                }

            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }

        }
        public void SearchTheNearestOneHourFlightToPort(DateTime time, string arrivalPort)
        {
            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i].ArrivalDateTime == time)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }

                if (flightsArray[i].PortOfArrival == arrivalPort)
                {
                    if (flightsArray[i].ArrivalDateTime.Date == time.Date)
                    {
                        int value = Math.Abs((flightsArray[i].ArrivalDateTime.Hour * 60 + flightsArray[i].ArrivalDateTime.Minute) - (time.Hour * 60 + time.Minute));
                        Console.WriteLine(value);

                        if (value <= 60)
                        {
                            counter++;
                            AddElementToArray(ref tempArray, counter, flightsArray[i]);
                        }
                    }
                }

            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }

    }
}
