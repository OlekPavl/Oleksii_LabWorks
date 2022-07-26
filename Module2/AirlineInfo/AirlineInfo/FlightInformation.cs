using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    class FlightInformation
    {
        //FlightStatus flightStatus;
        //Prices price;
        public string[] arrayFlightInformation = new string[9];

        public FlightInformation()
        {
            FlightInformationInitializer();
            //flightStatus = new FlightStatus();
            //price = new Prices();
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

        public void FlightInformationInitializer()
        {
            Console.Write("Flight number: ");
            FlightNumber = Convert.ToInt32(Console.ReadLine());
            arrayFlightInformation[0] = FlightNumber.ToString();

            Console.Write("Airline: ");
            Airline = Console.ReadLine();
            arrayFlightInformation[1] = Airline;

            try
            {
                Console.Write("Departure date/time (dd.mm.yy hh:mm): ");
                DepartureDateTime = Convert.ToDateTime(Console.ReadLine());
                arrayFlightInformation[2] = DepartureDateTime.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("ArrivalDateTime date/time (dd.mm.yy hh:mm): ");
                ArrivalDateTime = Convert.ToDateTime(Console.ReadLine());
                arrayFlightInformation[3] = ArrivalDateTime.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("CityOfDeparture: ");
            CityOfDeparture = Console.ReadLine();
            arrayFlightInformation[4] = CityOfDeparture;

            Console.Write("PortOfDeparture: ");
            PortOfDeparture = Console.ReadLine();
            arrayFlightInformation[5] = PortOfDeparture;

            Console.Write("CityOfArrival: ");
            CityOfArrival = Console.ReadLine();
            arrayFlightInformation[6] = CityOfArrival;

            Console.Write("PortOfArrival: ");
            PortOfArrival = Console.ReadLine();
            arrayFlightInformation[7] = PortOfArrival;

            Console.Write("Terminal: ");
            Terminal = Console.ReadLine();
            arrayFlightInformation[8] = Terminal;

        }
        //public override string ToString()
        //{
        //    StringBuilder flightInf = new StringBuilder();
        //    flightInf.Append($"FlightNumber: {FlightNumber}\n");
        //    flightInf.Append($"Airline: {Airline}\n");
        //    flightInf.Append($"DepartureDateTime: {DepartureDateTime}\n");
        //    flightInf.Append($"ArrivalDateTime: {ArrivalDateTime}\n");
        //    flightInf.Append($"CityOfDeparture: {CityOfDeparture}\n");
        //    flightInf.Append($"PortOfDeparture: {PortOfDeparture}\n");
        //    flightInf.Append($"CityOfArrival: {CityOfArrival}\n");
        //    flightInf.Append($"PortOfArrival: {PortOfArrival}\n");
        //    flightInf.Append($"Terminal: {Terminal}\n");
        //    flightInf.Append($"\n");
        //    flightInf.Append($"Flight status:\n");
        //    flightInf.Append($"Gate: {flightStatus.Gate}\n");
        //    flightInf.Append($"CheckIn: {flightStatus.CheckIn}\n");
        //    flightInf.Append($"GateClosed: {flightStatus.GateClosed}\n");
        //    flightInf.Append($"InFlight: {flightStatus.InFlight}\n");
        //    flightInf.Append($"Cancelled: {flightStatus.Cancelled}\n");
        //    flightInf.Append($"DepartedAt: {flightStatus.DepartedAt}\n");
        //    flightInf.Append($"ExpectedAt: {flightStatus.ExpectedAt}\n");
        //    flightInf.Append($"ArrivedAt: {flightStatus.ArrivedAt}\n");

        //    return flightInf.ToString();
        //}
        //public void DisplayFlightInformation()
        //{
        //    string flightInf = ToString();
        //    Console.WriteLine(flightInf);
        //}
    }
}
