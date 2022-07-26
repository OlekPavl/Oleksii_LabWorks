using System;

namespace AirportPanel
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightSchedule flightSchedule = new FlightSchedule();

            Menu(flightSchedule);

            
            
            Console.ReadKey();
        }
        public static void Menu(FlightSchedule flightSchedule)
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

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flightSchedule.AddFlight();
                        break;
                    case 2:
                        flightSchedule.DisplayFlightsArray();
                        break;
                    case 3:
                        Console.Write("Enter flight number: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        flightSchedule.SerachByFlightNumber(number);
                        break;
                    case 4:
                        Console.Write("Enter departure port name: ");
                        string departurePort = Console.ReadLine();
                        flightSchedule.SerachByDeparturePort(departurePort);
                        break;
                    case 5:
                        Console.Write("Enter arrival port name: ");
                        string arrivalPort = Console.ReadLine();
                        flightSchedule.SerachByArrivalPort(arrivalPort);
                        break;
                    case 6:
                        Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
                        DateTime departureTime = Convert.ToDateTime(Console.ReadLine());
                        flightSchedule.SerachByTimeOfDeparture(departureTime);
                        break;
                    case 7:
                        Console.Write("Enter time of arrival (dd.mm.yy hh:mm): ");
                        DateTime arrivalTime = Convert.ToDateTime(Console.ReadLine());
                        flightSchedule.SerachByTimeOfArrival(arrivalTime);
                        break;
                    case 8:
                        Console.Write("Enter a name of departure port: ");
                        string departPort = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
                        DateTime depTime = Convert.ToDateTime(Console.ReadLine());
                        flightSchedule.SearchTheNearestOneHourFlightFromPort(depTime, departPort);
                        break;
                    case 9:
                        Console.Write("Enter a name of arrival port: ");
                        string arrPort = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
                        DateTime arrTime = Convert.ToDateTime(Console.ReadLine());
                        flightSchedule.SearchTheNearestOneHourFlightFromPort(arrTime, arrPort);
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
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();                
                Console.WriteLine("1 - menu / 2 - exit");
                int nextStep = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (nextStep == 1)
                {
                    continue;                                   
                }
                if (nextStep == 2)
                {
                    break;
                }
            }
        }
    }
}
