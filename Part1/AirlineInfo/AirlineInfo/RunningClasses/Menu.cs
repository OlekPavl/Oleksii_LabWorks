using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    enum InitialMenuNumbers
    {
        add_information = 1,
        display_information = 2,
        exit = 3
    }
    enum AddMenuNumbers
    {
        create_schedule = 1,
        create_status_list = 2,
        create_price_list = 3,
        create_schedule_passenger_list = 4,
        menuUp = 5
    }
    enum GeneralDisplayMenuNumbers
    {
        display_flight_schedule = 1,
        display_flight_status_list = 2,
        display_prices = 3,
        display_passengers = 4,
        menuUp = 5
    }
    enum ScheduleDisplayMenuNumbers
    {
        DisplayFlightsArray = 1,
        Search_by_flight_number = 2,
        Search_by_departure_city = 3,
        Search_by_departure_port = 4,
        Search_by_time_of_departure = 5,
        Search_by_arrival_city = 6,
        Search_by_arrival_port = 7,
        Search_by_time_of_arrival = 8,
        Search_the_nearest_fly_from_port = 9,
        Search_the_nearest_fly_to_port = 10,
        menuUp = 11
    }
    enum StatusListDisplayMenuNumbers
    {
        DisplayStatusListArray = 1,
        Search_by_flight_number = 2,
        menuUp = 3
    }
    enum PriceListDisplayMenuNumbers
    {
        Display_PriceList_Array = 1,
        Search_by_flight_number = 2,
        menuUp = 3
    }
    enum ScheduleDisplayPassengerList
    {
        Display_Schedule_Passenger_List = 1,
        Search_by_flight_number = 2,
        menuUp = 3
    }
    internal class Menu
    {
        Flight flight;
        private FlightStatusHandler callback;
        DataSetClass ds;
        SQLServerDataBaseClass sqlDataBase;
        Action lastAction;

        public Menu(Flight flight)
        {
            this.flight = flight;
            ds = new DataSetClass(); 
            sqlDataBase = new SQLServerDataBaseClass(ds);

            //BackgroundCheckFlightStatus();
            InitialMenu();

        }

        public void EventMethod(int numb)
        {
            Console.Clear();
            flight.DataBaseEventStatusSerachByFlightNumber(numb);

            Thread.Sleep(5000);
            Console.Clear();
            //lastAction?.Invoke();
        }

        public void EventMethod2(int numb)
        {
            Console.Clear();
            //flight.DataBaseEventStatusSerachByFlightNumber(numb);
            flight.DataBaseFlightStatusListUpdateDepartArr(numb);
            Thread.Sleep(5000);
            Console.Clear();
            //lastAction?.Invoke();
        }

        public void InitialMenu()
        {
                  
            //flight.DataBaseCheckUpdateFlightStatusList(callback);
            //callback = EventMethod2;

            //lastAction = InitialMenu;


            while (true)
            {
                bool status = true;
                Console.WriteLine($"1 - Generate flight data");
                //Console.WriteLine($"2 - Transfer the information into the data base");
                Console.WriteLine($"2 - Clear data base");
                Console.WriteLine($"3 - Display information");
                Console.WriteLine($"4 - Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        //AddMenu();
                        GenerateFlightData(10);
                        break;
                    case 2:
                        ClearTablesInDataBase();
                        break;
                    case 3:
                        GeneralDisplayMenu();
                        break;
                    case 4:
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
        }

        #region Generate methods
        public void GenerateFlightData(int number)
        {
            flight.CreateFlightSchedule(number);
            flight.CreateFlightStatusList(callback);
            flight.CreatePriceList();
            flight.CreateSchedulePassengerList();

            FillTablesInDataBase();
        }
        public void AddMenu()
        {
            while (true)
            {
                bool status = true;
                Console.WriteLine($"1 - {AddMenuNumbers.create_schedule}");
                Console.WriteLine($"2 - {AddMenuNumbers.create_status_list}");
                Console.WriteLine($"3 - {AddMenuNumbers.create_price_list}");
                Console.WriteLine($"4 - {AddMenuNumbers.create_schedule_passenger_list}");
                Console.WriteLine($"5 - {AddMenuNumbers.menuUp}");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (option)
                {
                    case 1:
                        flight.CreateFlightSchedule(10);
                        break;
                    case 2:
                        flight.CreateFlightStatusList(callback);
                        break;
                    case 3:
                        flight.CreatePriceList();
                        break;
                    case 4:
                        flight.CreateSchedulePassengerList();
                        break;
                    case 5:
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
        }
        #endregion

        #region Display methods
        public void GeneralDisplayMenu()
        {
            lastAction = GeneralDisplayMenu;

            while (true)
            {
                bool status = true;
                Console.WriteLine($"1 - Information about the flights");
                Console.WriteLine($"2 - Information about flight statuses");
                Console.WriteLine($"3 - Prices");
                Console.WriteLine($"4 - Passengers");
                Console.WriteLine($"5 - menuUp");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        ScheduleDisplayMenu();
                        break;
                    case 2:
                        StatusListDisplayMenu();
                        break;
                    case 3:
                        PriceListDisplayMenu();
                        break;
                    case 4:
                        SchedulePassengersDisplayMenu();
                        break;
                    case 5:
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
        }
        public void ScheduleDisplayMenu()
        {
            lastAction = ScheduleDisplayMenu;

            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - List of flights");
                Console.WriteLine($"2 - Search by flight number");
                Console.WriteLine($"3 - Search by departure city");
                Console.WriteLine($"4 - Search by departure port");
                Console.WriteLine($"5 - Search by time of departure");
                Console.WriteLine($"6 - Search by arrival city");
                Console.WriteLine($"7 - Search by arrival port");
                Console.WriteLine($"8 - Search by time of arrival");
                Console.WriteLine($"9 - Search the nearest fly from port");
                Console.WriteLine($"10 - Search the nearest fly to port");
                Console.WriteLine($"11 - menuUp");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DataBaseDisplayFlightSchedule();
                        break;
                    case 2:
                        flight.DataBaseSearchByFlightNumber();
                        break;
                    case 3:
                        flight.DataBaseSerachByDepartureCity();
                        break;
                    case 4:
                        flight.DataBaseSerachByDeparturePort();
                        break;
                    case 5:
                        flight.DataBaseSerachByDepartureTime();
                        break;
                    case 6:
                        flight.DataBaseSerachByArrivalCity();
                        break;
                    case 7:
                        flight.DataBaseSerachByArrivalPort();
                        break;
                    case 8:
                        flight.DataBaseSerachByArrivalTime();
                        break;
                    case 9:
                        flight.DataBaseSearchTheNearestOneHourFlightFromPort();
                        break;
                    case 10:
                        flight.DataBaseSearchTheNearestOneHourFlightToPort();
                        break;
                    case 11:
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
        public void StatusListDisplayMenu()
        {
            lastAction = StatusListDisplayMenu;


            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - Statuses of the flights");
                Console.WriteLine($"2 - Search by flight number");
                Console.WriteLine($"3 - Temporary depart/expect/arr dates");
                Console.WriteLine($"4 - menuUp");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DataBaseDisplayFlightStatusList();
                        break;
                    case 2:
                        flight.DataBaseSearchByFlightNumberFlightStatus();
                        break;
                    case 3:
                        flight.DataBaseDisplayTempDepartExpectArr();
                        break;
                    case 4:
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
        public void PriceListDisplayMenu()
        {
            lastAction = PriceListDisplayMenu;

            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - Prices");
                Console.WriteLine($"2 - Search by flight number");
                Console.WriteLine($"3 - menuUp");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DataBasePriceList();
                        break;
                    case 2:
                        flight.DataBaseSearchByFlightNumberPriceList();
                        break;
                    case 3:
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
        public void SchedulePassengersDisplayMenu()
        {
            lastAction = SchedulePassengersDisplayMenu;

            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - List of passengers");
                Console.WriteLine($"2 - Search by flight number");
                Console.WriteLine($"3 - Search by second name");
                Console.WriteLine($"4 - Search by nationality");
                Console.WriteLine($"5 - Search by passport");
                Console.WriteLine($"6 - menuUp");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DataBaseDisplayPassengerList();
                        break;
                    case 2:
                        flight.DataBaseSearchByFlightNumberPassengerList();
                        break;
                    case 3:
                        flight.DataBaseSearchBySecondNamePassengerList();
                        break;
                    case 4:
                        flight.DataBaseSearchByNationalityPassengerList();
                        break;
                    case 5:
                        flight.DataBaseSearchByPassportNumberPassengerList();
                        break;
                    case 6:
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
        #endregion

        #region Methods for update / clear data base
        public void FillTablesInDataBase()
        {
            for (int i = 0; i < 1; i++)
            {
                ds.FillScheduleTable(flight.flightSchedule);
                ds.FillFlightStatusListTable(flight.flightStatusList);
                ds.FillTempDepartExpectArrTable(flight.flightStatusList);
                ds.FillFlightPriceListTable(flight.priceList);
                ds.FillPassengerListTable(flight.schedulePassengerList);
                //ds.DisplayPassengerListTable();
                //ds.DisplayTempDepartExpectArrTable();


                //sqlDataBase.CreateTableFlightScheduleInDatabase();
                //sqlDataBase.CreateTableFlightStatusListInDatabase();
                //sqlDataBase.CreateTablePriceListInDatabase();
                //sqlDataBase.CreateTablePassengerListInDatabase();
                //sqlDataBase.CreateTableFlightStatusTemporaryDepartExpectArrivData();
                sqlDataBase.UpdateTableFlightScheduleInDatabase();
                sqlDataBase.UpdateTableStatusListInDatabase();
                sqlDataBase.UpdateTablePriceListInDatabase();
                sqlDataBase.UpdateTablePassengerListInDatabase();
                sqlDataBase.UpdateTableTemporaryDepartExpectArrivDataInDatabase();

                Thread.Sleep(2000);
                Console.Clear();

            }


        }
        public void ClearTablesInDataBase()
        {
            sqlDataBase.ClearTableFlightStatusListInDatabase();
            sqlDataBase.ClearTablePriceListInDatabase();
            sqlDataBase.ClearTablePassengerListInDatabase();
            sqlDataBase.ClearTableTempDepartExpectArrDateInDatabase();
            sqlDataBase.ClearTableFlightScheduleInDatabase();

            Thread.Sleep(2000);

            Console.Clear();
        }
        #endregion

        #region Methods for constant background check glight statuses
        public void BackgroundCheckFlightStatus()
        {
            
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(UpdateStatusList);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 1000);
        }
        public void UpdateStatusList(object obj)
        {
            flight.DataBaseCheckUpdateFlightStatusList(callback);
        }
        #endregion
    }
}
