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
            //FlightInformationInitializer();
            FlightInformationAutomaticalInitializer();
            //flightStatus = new FlightStatus();
            //price = new Prices();
            Console.Clear();
        }

        public int? FlightNumber { get; set; }
        public string Airline { get; set; }

        public DateTime departureDateTime;
        public DateTime DepartureDateTime 
        {
            get
            {
                return departureDateTime;
            }
            set
            {
                departureDateTime = value;
            }
        }

        public DateTime arrivalDateTime;
        public DateTime ArrivalDateTime 
        { 
            get
            {
                return arrivalDateTime;
            } 
            set
            {
                arrivalDateTime = value;
            }
        }
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
        public void FlightInformationAutomaticalInitializer()
        {

            FlightNumber = null;
            arrayFlightInformation[0] = FlightNumber.ToString();

            Random random = new Random();
            string[] airLines = new string[] { "Qatar Airways", "Singapore Airlines", "Emirates", "Lufthansa", "American Airlines", "Air Canada", "Garuda Indonesia", "China Airlines", "Finnair", "Ethiopian Airlines" };

            Airline = airLines[random.Next(0, 10)];
            arrayFlightInformation[1] = Airline;

            GetRandomDates(out departureDateTime, out arrivalDateTime);

            arrayFlightInformation[2] = departureDateTime.ToString();
            arrayFlightInformation[3] = arrivalDateTime.ToString();

            string[] cityArray = new string[] { "Atlanta", "Chaoyang-Shunyi", "Garhoud", "Los Angeles", "Chicago", "Hillingdon", "Ōta", "Chek Lap Kok", "Pudong", "Roissy-en-France", "Haarlemmermeer", "Dallas-Fort Worth", "Baiyun-Huadu", "Frankfurt", "Yeşilköy", "Delhi", "Tangerang", "Changi", "Incheon", "Denver", "Bang Phli", "Queens", "Sepang", "San Mateo County", "Barajas", "Shuangliu-Wuhou", "Las Vegas", "Barcelona", "Mumbai", "Mississauga", "SeaTac", "Charlotte", "Crawley", "Bao'an", "Dayuan", "Venustiano Carranza", "Guandu", "Freising", "Orlando", "Miami-Dade County", "Phoenix", "Mascot", "Newark", "Pasay/Parañaque", "Changning-Minhang", "Weicheng", "Rome-Fiumicino", "Houston", "Narita" };
            CityOfDeparture = cityArray[random.Next(0, 49)];
            arrayFlightInformation[4] = CityOfDeparture;

            string[] portArray = new string[] { "ATL/KATL", "PEK/ZBAA", "DXB/OMDB", "LAX/KLAX", "ORD/KORD", "LHR/EGLL", "HND/RJTT", "HKG/VHHH", "PVG/ZSPD", "CDG/LFPG", "AMS/EHAM", "DFW/KDFW", "CAN/ZGGG", "FRA/EDDF", "IST/LTBA", "DEL/VIDP", "CGK/WIII", "SIN/WSSS", "ICN/RKSI", "DEN/KDEN", "BKK/VTBS", "JFK/KJFK", "KUL/WMKK", "SFO/KSFO", "MAD/LEMD", "CTU/ZUUU", "LAS/KLAS", "BCN/LEBL", "BOM/VABB", "YYZ/CYYZ", "SEA/KSEA", "CLT/KCLT", "LGW/EGKK", "SZX/ZGSZ", "TPE/RCTP", "MEX/MMMX", "KMG/ZPPP", "MUC/EDDM", "MCO/KMCO", "MIA/KMIA", "PHX/KPHX", "SYD/YSSY", "EWR/KEWR", "MNL/RPLL", "SHA/ZSSS", "XIY/ZLXY", "FCO/LIRF", "IAH/KIAH", "NRT/RJAA" };
            PortOfDeparture = portArray[random.Next(0, 49)];
            arrayFlightInformation[5] = PortOfDeparture;

            while (true)
            {
                string tempCity = cityArray[random.Next(0, 49)];
                if (tempCity == CityOfDeparture)
                {
                    continue;
                }
                else
                {
                    CityOfArrival = tempCity;
                    arrayFlightInformation[6] = CityOfArrival;
                    break;
                }
            }


            while (true)
            {
                string tempPort = portArray[random.Next(0, 49)];
                if (tempPort == PortOfDeparture)
                {
                    continue;
                }
                else
                {
                    PortOfArrival = tempPort;
                    arrayFlightInformation[7] = PortOfArrival;
                    break;
                }
            }
            

            Terminal = random.Next(1, 25).ToString();
            arrayFlightInformation[8] = Terminal;


            void GetRandomDates(out DateTime departure, out DateTime arrival)
            {
                Random random = new Random();

                departure = DateTime.Now + TimeSpan.FromSeconds(random.Next(0, 60));
                //int number = random.Next(0, 2);
                //if (number == 0)
                //{
                //    departure = DateTime.Now - (TimeSpan.FromHours(random.Next(2)) + TimeSpan.FromMinutes(random.Next(60)));
                //}
                //else
                //{
                //    departure = DateTime.Now + TimeSpan.FromHours(random.Next(1)) + TimeSpan.FromMinutes(random.Next(60));
                //}
                //departure = DateTime.Now + TimeSpan.FromDays(random.Next(31)) + TimeSpan.FromHours(random.Next(24)) + TimeSpan.FromMinutes(random.Next(60));
                TimeSpan timeSpan = TimeSpan.FromHours(random.Next(3)) + TimeSpan.FromMinutes(random.Next(60));
                arrival = departure + timeSpan;
            }

        }

    }

}
