using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirportPanel
{

    class FlightInformation
    {
        public static FlightInformation[] flightsArray = new FlightInformation[0];
        public static int counter = 0;
        FlightStatus flightStatus;
        public FlightInformation()
        {
            FlightInformationInitialiser();
            flightStatus = new FlightStatus();
            counter++;
            FlightsArrayInitialiser();

            for (int i = 0; i < flightsArray.Length; i++)
            {
                if (flightsArray[i] == null)
                {
                    flightsArray[i] = this;
                    break;
                }
            }
            Console.Clear();
        }

        public int FlightNumber { get; set; }
        public string Airline { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string CityOfDeparture { get; set; }
        public string PortOfDeparture { get; set; }
        public string CityOfArrival { get; set; }
        public string PortOfArrival { get; set; }
        public string Terminal { get; set; }

        public void FlightInformationInitialiser()
        {
            Console.Write("Flight number: ");
            FlightNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Airline: ");
            Airline = Console.ReadLine();

            try
            {
                Console.Write("Departure date/time (dd.mm.yy hh:mm): ");
                DepartureDateTime = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                Console.Write("ArrivalDateTime date/time (dd.mm.yy hh:mm): ");
                ArrivalDateTime = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("CityOfDeparture: ");
            CityOfDeparture = Console.ReadLine();

            Console.Write("PortOfDeparture: ");
            PortOfDeparture = Console.ReadLine();

            Console.Write("CityOfArrival: ");
            CityOfArrival = Console.ReadLine();

            Console.Write("PortOfArrival: ");
            PortOfArrival = Console.ReadLine();

            Console.Write("Terminal: ");
            Terminal = Console.ReadLine();

        }
        public override string ToString()
        {
            StringBuilder flightInf = new StringBuilder();
            flightInf.Append($"FlightNumber: {FlightNumber}\n");
            flightInf.Append($"Airline: {Airline}\n");
            flightInf.Append($"DepartureDateTime: {DepartureDateTime}\n");
            flightInf.Append($"ArrivalDateTime: {ArrivalDateTime}\n");
            flightInf.Append($"CityOfDeparture: {CityOfDeparture}\n");
            flightInf.Append($"PortOfDeparture: {PortOfDeparture}\n");
            flightInf.Append($"CityOfArrival: {CityOfArrival}\n");
            flightInf.Append($"PortOfArrival: {PortOfArrival}\n");
            flightInf.Append($"Terminal: {Terminal}\n");
            flightInf.Append($"\n");
            flightInf.Append($"Flight status:\n");
            flightInf.Append($"Gate: {flightStatus.Gate}\n");
            flightInf.Append($"CheckIn: {flightStatus.CheckIn}\n");
            flightInf.Append($"GateClosed: {flightStatus.GateClosed}\n");
            flightInf.Append($"InFlight: {flightStatus.InFlight}\n");
            flightInf.Append($"Cancelled: {flightStatus.Cancelled}\n");
            flightInf.Append($"DepartedAt: {flightStatus.DepartedAt}\n");
            flightInf.Append($"ExpectedAt: {flightStatus.ExpectedAt}\n");
            flightInf.Append($"ArrivedAt: {flightStatus.ArrivedAt}\n");

            return flightInf.ToString();
        }
        public void DisplayFlightInformation()
        {
            string flightInf = ToString();
            Console.WriteLine(flightInf);
        }
        public void FlightsArrayInitialiser()
        {
            FlightInformation[] tempArray = new FlightInformation[counter];
            for (int i = 0; i < flightsArray.Length; i++)
            {
                tempArray[i] = flightsArray[i];
            }
            flightsArray = tempArray;

        }
        public static void SerachByFlightNumber(int number)
        {
            foreach (FlightInformation item in flightsArray)
            {
                if (item.FlightNumber == number)
                {
                    item.DisplayFlightInformation();
                }
                else
                {
                    Console.WriteLine("The inforamtion not found");
                }
            }

        }
        public static void SerachByDeparturePort(string name)
        {
            foreach (FlightInformation item in flightsArray)
            {
                if (item.PortOfDeparture == name)
                {
                    item.DisplayFlightInformation();
                }
                else
                {
                    Console.WriteLine("The inforamtion not found");
                }
            }
        }
        public static void SerachByArrivalPort(string name)
        {
            foreach (FlightInformation item in flightsArray)
            {
                if (item.PortOfArrival == name)
                {
                    item.DisplayFlightInformation();
                }
                else
                {
                    Console.WriteLine("The inforamtion not found");
                }
            }
        }
        public static void SerachByTimeOfDeparture(DateTime time)
        {
            foreach (FlightInformation item in flightsArray)
            {

                if (item.DepartureDateTime == time)
                {
                    item.DisplayFlightInformation();
                }
                else
                {
                    Console.WriteLine("The inforamtion not found");
                }
            }
        }
        public static void SerachByTimeOfArrival(DateTime time)
        {
            foreach (FlightInformation item in flightsArray)
            {

                if (item.ArrivalDateTime == time)
                {
                    item.DisplayFlightInformation();
                }
                else
                {
                    Console.WriteLine("The inforamtion not found");
                }
            }
        }
        public static void SearchTheNearestOneHourFlightFromPort(DateTime time, string departurePort)
        {
            foreach (FlightInformation item in flightsArray)
            {

                if (item.PortOfDeparture == departurePort)
                {
                    if (item.DepartureDateTime.Date == time.Date)
                    {
                        int value = Math.Abs((item.DepartureDateTime.Hour * 60 + item.DepartureDateTime.Minute) - (time.Hour * 60 + time.Minute));
                        Console.WriteLine(value);

                        if (value <=  60)
                        {
                            item.DisplayFlightInformation();
                        }
                    }
                    else
                    {
                        Console.WriteLine("The inforamtion not found");
                    }

                }
            }
        }
        public static void SearchTheNearestOneHourFlightToPort(DateTime time, string arrivalPort)
        {
            foreach (FlightInformation item in flightsArray)
            {

                if (item.PortOfArrival == arrivalPort)
                {
                    if (item.ArrivalDateTime.Date == time.Date)
                    {
                        int value = Math.Abs((item.ArrivalDateTime.Hour * 60 + item.ArrivalDateTime.Minute) - (time.Hour * 60 + time.Minute));
                        Console.WriteLine(value);

                        if (value <= 60)
                        {
                            item.DisplayFlightInformation();
                        }
                        else
                        {
                            Console.WriteLine("The inforamtion not found");
                        }
                    }

                }
            }
        }

    }
}
