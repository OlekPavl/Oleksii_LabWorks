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
        CreateFlight flight;
        private FlightStatusHandler callback;
        DataSetClass ds;
        SQLServerDataBaseClass sqlDataBase;

        public Menu(CreateFlight flight)
        {
            this.flight = flight;
            callback = EventMethod;
            ds = new DataSetClass();
            sqlDataBase = new SQLServerDataBaseClass(ds);

            InitialMenu();
        }



        public void EventMethod(ref int numb)
        {
            Console.Clear();
            flight.EventStatusSerachByFlightNumber(numb);
        }

        public void InitialMenu()
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(UpdateStatusList);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 1000);


            while (true)
            {
                bool status = true;
                Console.WriteLine($"1 - {InitialMenuNumbers.add_information}");
                Console.WriteLine($"2 - {InitialMenuNumbers.display_information}");
                Console.WriteLine($"5 - {InitialMenuNumbers.exit}");
                Console.WriteLine($"3 - FillDataBase");
                Console.WriteLine($"4 - ClearDataBase");


                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        AddMenu();
                        break;
                    case 2:
                        GeneralDisplayMenu();
                        break;
                    case 5:
                        status = false;
                        break;
                    case 3:
                        FillTablesInDataBase();
                        break;
                    case 4:
                        ClearTablesInDataBase();
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
        public void GeneralDisplayMenu()
        {
            while (true)
            {
                bool status = true;
                Console.WriteLine($"1 - {GeneralDisplayMenuNumbers.display_flight_schedule}");
                Console.WriteLine($"2 - {GeneralDisplayMenuNumbers.display_flight_status_list}");
                Console.WriteLine($"3 - {GeneralDisplayMenuNumbers.display_prices}");
                Console.WriteLine($"4 - {GeneralDisplayMenuNumbers.display_passengers}");
                Console.WriteLine($"5 - {GeneralDisplayMenuNumbers.menuUp}");

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
            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - {ScheduleDisplayMenuNumbers.DisplayFlightsArray}");
                Console.WriteLine($"2 - {ScheduleDisplayMenuNumbers.Search_by_flight_number}");
                Console.WriteLine($"3 - {ScheduleDisplayMenuNumbers.Search_by_departure_city}");
                Console.WriteLine($"4 - {ScheduleDisplayMenuNumbers.Search_by_departure_port}");
                Console.WriteLine($"5 - {ScheduleDisplayMenuNumbers.Search_by_time_of_departure}");
                Console.WriteLine($"6 - {ScheduleDisplayMenuNumbers.Search_by_arrival_city}");
                Console.WriteLine($"7 - {ScheduleDisplayMenuNumbers.Search_by_arrival_port}");
                Console.WriteLine($"8 - {ScheduleDisplayMenuNumbers.Search_by_time_of_arrival}");
                Console.WriteLine($"9 - {ScheduleDisplayMenuNumbers.Search_the_nearest_fly_from_port}");
                Console.WriteLine($"10 - {ScheduleDisplayMenuNumbers.Search_the_nearest_fly_to_port}");
                Console.WriteLine($"11 - {ScheduleDisplayMenuNumbers.menuUp}");
                Console.WriteLine($"12 - DataBaseDisplayFlights");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DisplayFlightSchedule();
                        break;
                    case 2:
                        flight.SerachByFlightNumber();
                        break;
                    case 3:
                        flight.SerachByDepartureCity();
                        break;
                    case 4:
                        flight.SerachByDeparturePort();
                        break;
                    case 5:
                        flight.SerachByTimeOfDeparture();
                        break;
                    case 6:
                        flight.SerachByArrivalCity();
                        break;
                    case 7:
                        flight.SerachByArrivalPort();
                        break;
                    case 8:
                        flight.SerachByTimeOfArrival();
                        break;
                    case 9:
                        flight.SearchTheNearestOneHourFlightFromPort();
                        break;
                    case 10:
                        flight.SearchTheNearestOneHourFlightToPort();
                        break;
                    case 11:
                        status = false;
                        break;
                    case 12:
                        flight.DataBaseDisplayFlightSchedule();
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
            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - {StatusListDisplayMenuNumbers.DisplayStatusListArray}");
                Console.WriteLine($"2 - {StatusListDisplayMenuNumbers.Search_by_flight_number}");
                Console.WriteLine($"3 - {StatusListDisplayMenuNumbers.menuUp}");
                Console.WriteLine($"4 - DataBaseStatusListDisplay");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DisplayFlightStatusList();
                        break;
                    case 2:
                        flight.StatusSerachByFlightNumber();
                        break;
                    case 3:
                        status = false;
                        break;
                    case 4:
                        flight.DataBaseDisplayFlightStatusList();
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
            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - {PriceListDisplayMenuNumbers.Display_PriceList_Array}");
                Console.WriteLine($"2 - {PriceListDisplayMenuNumbers.Search_by_flight_number}");
                Console.WriteLine($"3 - {PriceListDisplayMenuNumbers.menuUp}");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DisplayPriceList();
                        break;
                    case 2:
                        flight.PriceSearchByFlightNumber();
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
            while (true)
            {
                bool status = true;

                Console.WriteLine($"1 - {ScheduleDisplayPassengerList.Display_Schedule_Passenger_List}");
                Console.WriteLine($"2 - {ScheduleDisplayPassengerList.Search_by_flight_number}");
                Console.WriteLine($"3 - {ScheduleDisplayPassengerList.menuUp}");
                Console.WriteLine($"4 - DataBaseDisplayPassengerList)");

                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        flight.DisplaySchedulePassengerList();
                        break;
                    case 2:
                        break;
                    case 3:
                        status = false;
                        break;
                    case 4:
                        flight.DataBaseDisplayPassengerList();
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
        public void UpdateStatusList(object obj)
        {
            flight.CheckUpdateFlightStatusList();
        }

        public void FillTablesInDataBase()
        {
            for (int i = 0; i < 1; i++)
            {
                ds.FillScheduleTable(flight.flightSchedule);
                ds.FillFlightStatusListTable(flight.flightStatusList);
                ds.FillFlightPriceListTable(flight.priceList);
                ds.FillPassengerListTable(flight.schedulePassengerList);
                //ds.DisplayPassengerListTable();

                //sqlDataBase.CreateTableFlightScheduleInDatabase();
                //sqlDataBase.CreateTableFlightStatusListInDatabase();
                //sqlDataBase.CreateTablePriceListInDatabase();
                //sqlDataBase.CreateTablePassengerListInDatabase();
                sqlDataBase.UpdateTableFlightScheduleInDatabase();
                sqlDataBase.UpdateTableStatusListInDatabase();
                sqlDataBase.UpdateTablePriceListInDatabase();
                sqlDataBase.UpdateTablePassengerListInDatabase();

            }


        }
        public void ClearTablesInDataBase()
        {
            sqlDataBase.ClearTableFlightStatusListInDatabase();
            sqlDataBase.ClearTablePriceListInDatabase();
            sqlDataBase.ClearTableFlightScheduleInDatabase();
            sqlDataBase.ClearTablePassengerListInDatabase();
        }

    }
}
