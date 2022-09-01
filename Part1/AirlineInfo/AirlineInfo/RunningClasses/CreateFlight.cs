using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    internal class CreateFlight
    {
        public FlightSchedule flightSchedule;
        public FlightStatusList flightStatusList;
        public PriceList priceList;
        public FlightPassengerList flightPassengerList;
        public SchedulePassengerList schedulePassengerList;
        public CreateFlight()
        {
            flightSchedule = new FlightSchedule();
            flightStatusList = new FlightStatusList();
            priceList = new PriceList();
            flightPassengerList = new FlightPassengerList();
            schedulePassengerList = new SchedulePassengerList();
        }

        #region FlightsSchedule methods
        public void CreateFlightSchedule(int number)
        {
            //FlightSchedule flightSchedule = new FlightSchedule();
            for (int i = 0; i < number; i++)
            {
                flightSchedule.AddFlight();
            }
        }
        public void DisplayFlightSchedule()
        {
            flightSchedule.DisplayFlightsArray();
            Console.WriteLine();
        }
        public void SerachByFlightNumber()
        {
            Console.Write("Enter flight number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            flightSchedule.SerachByFlightNumber(number);
        }
        public void SerachByDepartureCity()
        {
            Console.Write("Enter departure city: ");
            flightSchedule.SerachByDepartureCity(Console.ReadLine());
        }
        public void SerachByDeparturePort()
        {
            Console.Write("Enter departure port: ");
            flightSchedule.SerachByDeparturePort(Console.ReadLine());
        }
        public void SerachByTimeOfDeparture()
        {
            Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
            flightSchedule.SerachByTimeOfDeparture(Convert.ToDateTime(Console.ReadLine()));
        }
        public void SerachByArrivalCity()
        {
            Console.Write("Enter arrival city: ");
            flightSchedule.SerachByArrivalCity(Console.ReadLine());
        }
        public void SerachByArrivalPort()
        {
            Console.Write("Enter arrival port: ");
            flightSchedule.SerachByArrivalPort(Console.ReadLine());
        }
        public void SerachByTimeOfArrival()
        {
            Console.Write("Enter time of arrival (dd.mm.yy hh:mm): ");
            flightSchedule.SerachByTimeOfArrival(Convert.ToDateTime(Console.ReadLine()));
        }
        public void SearchTheNearestOneHourFlightFromPort()
        {
            Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter port of departure: ");
            string portOfDeparture = Console.ReadLine();
            flightSchedule.SearchTheNearestOneHourFlightFromPort(dateTime, portOfDeparture);
        }
        public void SearchTheNearestOneHourFlightToPort()
        {
            Console.Write("Enter time of arrival (dd.mm.yy hh:mm): ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter port of arrival: ");
            string portOfArrival = Console.ReadLine();
            flightSchedule.SearchTheNearestOneHourFlightToPort(dateTime, portOfArrival);
        }
        #endregion

        #region FlightStatusList methods
        public void CreateFlightStatusList(FlightStatusHandler Callback)
        {
            //FlightStatusList flightStatusList = new FlightStatusList();
            for (int i = 0; i < flightSchedule.flightsArray.Length; i++)
            {
                flightStatusList.AddFlightStatus(flightSchedule.flightsArray[i], Callback);
            }
        }
        public void DisplayFlightStatusList()
        {
            flightStatusList.DisplayFlightsStatusArray();
        }
        public void StatusSerachByFlightNumber()
        {
            Console.Write("Enter flight number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            flightStatusList.SerachByFlightNumber(number);
        }
        public void EventStatusSerachByFlightNumber(int number)
        {
            Console.Clear();
            flightStatusList.SerachByFlightNumber(number);
        }
        public void CheckUpdateFlightStatusList()
        {
            flightStatusList.CheckUpdateFlightStatusArray();
        }
        #endregion

        #region PriceList methods
        public void CreatePriceList()
        {
            for (int i = 0; i < flightSchedule.flightsArray.Length; i++)
            {
                priceList.AddPrice(flightSchedule.flightsArray[i]);
            }
        }
        public void DisplayPriceList()
        {
            priceList.DisplayPriceArray();
        }
        public void PriceSearchByFlightNumber()
        {
            Console.Write("Enter flight number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            priceList.SerachByFlightNumber(number);
        }
        #endregion

        #region FlightPassengerList
        public void CreateFlightPassengerList()
        {
            for (int i = 0; i < flightSchedule.flightsArray.Length; i++)
            {
                flightPassengerList.AddPassengersToFlight((flightSchedule.flightsArray[i]));
            }
        }
        public void DisplayFlightPassengerList()
        {
            flightPassengerList.DisplayFlightPassengerArray();
        }
        #endregion

        #region SchedulePassengerList
        public void CreateSchedulePassengerList()
        {
            for (int i = 0; i < flightSchedule.flightsArray.Length; i++)
            {
                FlightPassengerList flightPassList = new FlightPassengerList();
                flightPassList.AddPassengersToFlight(flightSchedule.flightsArray[i]);
                schedulePassengerList.AddPassengersToSchedulesPassengersList(flightPassList);
                //new FlightPassengerList().AddPassengersToFlight(flightSchedule.flightsArray[i]);

                //flighPassengerList.AddPassengersToFlight((flightSchedule.flightsArray[i]));
                //schedulePassengerList.AddPassengersToSchedulesPassengersList();
            }
        }
        public void DisplaySchedulePassengerList()
        {
            schedulePassengerList.DisplaySchedulePassengerArray();
        }
        #endregion


        #region DataBaseFlightsSchedule methods
        public void DataBaseDisplayFlightSchedule()
        {
            flightSchedule.DisplayDataBaseFlights();
            Console.WriteLine();
        }
        #endregion

        #region DataBaseStatusList methods
        public void DataBaseDisplayFlightStatusList()
        {
            flightStatusList.DisplayDataBaseFlightsStatusArray();
            Console.WriteLine();
        }
        #endregion

        #region DataBasePassengerList methods
        public void DataBaseDisplayPassengerList()
        {
            schedulePassengerList.DisplayDataBaseSchedulePassengerArray();
            Console.WriteLine();
        }
        #endregion
    }

}
