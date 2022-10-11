using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AirlineInfo
{
    internal class Flight
    {
        public FlightSchedule flightSchedule;
        public FlightStatusList flightStatusList;
        public PriceList priceList;
        public FlightPassengerList flightPassengerList;
        public SchedulePassengerList schedulePassengerList;
        public Flight()
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
            string city = Console.ReadLine();
            flightSchedule.SerachByDepartureCity(city);
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
        public void DataBaseFlightStatusListUpdateDepartArr(int number)
        {
            flightStatusList.DataBaseFlightStatusListUpdateDepartArr(number);
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
        public void DataBaseSearchByFlightNumber()
        {
            Console.Write("Enter flight number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            flightSchedule.DataBaseSearchByFlightNumber(number);
        }
        public void DataBaseSerachByDepartureCity()
        {
            Console.Write("Enter departure city: ");
            string city = Console.ReadLine();
            Console.Clear();
            flightSchedule.DataBaseSearchByDepartureCity(city);
        }
        public void DataBaseSerachByDeparturePort()
        {
            Console.Write("Enter departure port: ");
            string port = Console.ReadLine();
            Console.Clear();
            flightSchedule.DataBaseSearchByDeparturePort(port);
        }
        public void DataBaseSerachByDepartureTime()
        {
            Console.Write("Enter departure time: ");
            DateTime time = Convert.ToDateTime(Console.ReadLine());
            Console.Clear();
            flightSchedule.DataBaseSearchByTimeOfDeparture(time);
        }
        public void DataBaseSerachByArrivalCity()
        {
            Console.Write("Enter arrival city: ");
            string city = Console.ReadLine();
            Console.Clear();
            flightSchedule.DataBaseSearchByArrivalCity(city);
        }
        public void DataBaseSerachByArrivalPort()
        {
            Console.Write("Enter arrival port: ");
            string port = Console.ReadLine();
            Console.Clear();
            flightSchedule.DataBaseSearchByArrivalPort(port);
        }
        public void DataBaseSerachByArrivalTime()
        {
            Console.Write("Enter arrival time: ");
            DateTime time = Convert.ToDateTime(Console.ReadLine());
            Console.Clear();
            flightSchedule.DataBaseSearchByTimeOfArrival(time);
        }
        public void DataBaseSearchTheNearestOneHourFlightFromPort()
        {
            Console.Write("Enter time of departure (dd.mm.yy hh:mm): ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter port of departure: ");
            string portOfDeparture = Console.ReadLine();
            Console.Clear();
            flightSchedule.DataBaseSearchTheNearestOneHourFlightFromPort(dateTime, portOfDeparture);
        }
        public void DataBaseSearchTheNearestOneHourFlightToPort()
        {
            Console.Write("Enter time of arrival (dd.mm.yy hh:mm): ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter port of arrival: ");
            string portOfArrival = Console.ReadLine();
            Console.Clear();
            flightSchedule.DataBaseSearchTheNearestOneHourFlightToPort(dateTime, portOfArrival);
        }
        #endregion

        #region DataBaseStatusList methods
        public void DataBaseDisplayFlightStatusList()
        {
            flightStatusList.DisplayDataBaseFlightsStatusArray();
            Console.WriteLine();
        }
        public void DataBaseSearchByFlightNumberFlightStatus()
        {
            Console.Write("Enter flight number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            flightStatusList.DataBaseSerachByFlightNumberFlightStatus(number);
        }
        public void DataBaseDisplayTempDepartExpectArr()
        {
            flightStatusList.DisplayDataBaseTemporaryDepartExpectArrivData();
            Console.WriteLine();
        }
        public void DataBaseCheckUpdateFlightStatusList(FlightStatusHandler Callback)
        {
            flightStatusList.DataBaseCheckUpdateFlightStatusArray(Callback);
        }
        public void DataBaseEventStatusSerachByFlightNumber(int number)
        {
            Console.Clear();
            flightStatusList.DataBaseFlightStatuSerachByFlightNumber(number);
        }
        public void DataBaseFlightStatusListUpdateDepartArr()
        {
            //flightStatusList
        }
        #endregion

        #region DataBasePassengerList methods
        public void DataBaseDisplayPassengerList()
        {
            schedulePassengerList.DisplayDataBaseSchedulePassengerArray();
            Console.WriteLine();
        }
        public void DataBaseSearchByFlightNumberPassengerList()
        {
            Console.Write("Enter flight number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            schedulePassengerList.DataBaseSearchByFlightNumberSchedulePassengerArray(number);
        }
        public void DataBaseSearchBySecondNamePassengerList()
        {
            Console.Write("Enter second name: ");
            string name = Console.ReadLine();
            Console.Clear();
            schedulePassengerList.DataBaseSearchBySecondNameSchedulePassengerArray(name);
        }
        public void DataBaseSearchByNationalityPassengerList()
        {
            Console.Write("Enter nationality: ");
            string name = Console.ReadLine();
            Console.Clear();
            schedulePassengerList.DataBaseSearchByNationalitySchedulePassengerArray(name);
        }
        public void DataBaseSearchByPassportNumberPassengerList()
        {
            Console.Write("Enter passport number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            schedulePassengerList.DataBaseSearchByPassportNumberSchedulePassengerArray(number);
        }
        #endregion

        #region DataBasePriceList methods
        public void DataBasePriceList()
        {
            priceList.DataBaseDisplayPriceArray();
            Console.WriteLine();
        }
        public void DataBaseSearchByFlightNumberPriceList()
        {
            Console.Write("Enter flight number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            priceList.DataBaseSearchByFlightNumberPriceArray(number);
        }
        #endregion
    }

}
