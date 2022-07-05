using System;

namespace AirportPanel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool status = true;
                
                Console.WriteLine("1 - add information about the flight");
                Console.WriteLine("2 - display information about the flights");
                Console.WriteLine("3 - search by flight number");
                Console.WriteLine("4 - search by departure port");
                Console.WriteLine("5 - search by arrival port");
                Console.WriteLine("6 - search by time of departure");
                Console.WriteLine("7 - search by time of arrival");
                Console.WriteLine("8 - search the nearest one hour flight from port");
                Console.WriteLine("9 - search the nearest one hour flight to port");
                Console.WriteLine("10 - exit");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        new FlightInformation();
                        break;
                    case 2:
                        foreach (var item in FlightInformation.flightsArray)
                        {
                            item.DisplayFlightInformation();
                        }
                        break;
                    case 3:
                        Console.Write("Enter flight number: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        FlightInformation.SerachByFlightNumber(number);
                        break;
                    case 4:
                        Console.Write("Enter departure port name: ");
                        string departurePort = Console.ReadLine();
                        FlightInformation.SerachByDeparturePort(departurePort);
                        break;
                    case 5:
                        Console.Write("Enter arrival port name: ");
                        string arrivalPort = Console.ReadLine();
                        FlightInformation.SerachByArrivalPort(arrivalPort);
                        break;
                    case 6:
                        Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
                        DateTime departureTime = Convert.ToDateTime(Console.ReadLine());
                        FlightInformation.SerachByTimeOfDeparture(departureTime);
                        break;
                    case 7:
                        Console.Write("Enter time of arrival (dd.mm.yy hh:mm): ");
                        DateTime arrivalTime = Convert.ToDateTime(Console.ReadLine());
                        FlightInformation.SerachByTimeOfArrival(arrivalTime);
                        break;
                    case 8:
                        Console.Write("Enter a name of departure port: ");
                        string departPort = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
                        DateTime depTime = Convert.ToDateTime(Console.ReadLine());
                        FlightInformation.SearchTheNearestOneHourFlightFromPort(depTime, departPort);
                        break;
                    case 9:
                        Console.Write("Enter a name of arrival port: ");
                        string arrPort = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
                        DateTime arrTime = Convert.ToDateTime(Console.ReadLine());
                        FlightInformation.SearchTheNearestOneHourFlightFromPort(arrTime, arrPort);
                        break;
                    case 10:
                        status = false;
                        break;
                    default:
                        Console.WriteLine("Option does not exist");
                        break;
                }
                if (status == false)
                {
                    break;
                }
            }
            
        
            
            Console.ReadKey();
        }
    }
}
