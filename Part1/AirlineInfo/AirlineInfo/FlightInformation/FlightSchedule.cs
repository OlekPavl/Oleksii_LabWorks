using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AirlineInfo
{
    class FlightSchedule
    {
        public int counter = 0;
        public FlightInformation[] flightsArray = new FlightInformation[0];
        public FlightInformation[] dataBaseFlightsArray;
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

        #region Methods to work with arrays from the program
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
        #endregion

        #region Methods to work DataBase
        public void DisplayDataBaseFlights()
        {
            DataSetClass ds = new DataSetClass();
            
            
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }


            new FlightsBoard(dataBaseFlightsArray).DisplaySchedule();
        }
        public void DataBaseSearchByFlightNumber(int number)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }


            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
                }
            }
            if (dataBaseFlightsArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }

        }
        public void DataBaseSearchByDepartureCity(string name)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }

            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].CityOfDeparture == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
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
        public void DataBaseSearchByDeparturePort(string name)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }

            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].PortOfDeparture == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
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
        public void DataBaseSearchByTimeOfDeparture(DateTime time)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }

            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].DepartureDateTime.Year == time.Year && dataBaseFlightsArray[i].DepartureDateTime.Month == time.Month && dataBaseFlightsArray[i].DepartureDateTime.Hour == time.Hour && dataBaseFlightsArray[i].DepartureDateTime.Minute == time.Minute)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                //Console.WriteLine(dataBaseFlightsArray[0].DepartureDateTime);
                //Console.WriteLine(time);
                Console.WriteLine("The inforamtion not found");
            }

        }
        public void DataBaseSearchByArrivalCity(string name)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }

            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].CityOfArrival == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
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
        public void DataBaseSearchByArrivalPort(string name)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }

            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].PortOfArrival == name)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
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
        public void DataBaseSearchByTimeOfArrival(DateTime time)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }

            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].ArrivalDateTime.Year == time.Year && dataBaseFlightsArray[i].ArrivalDateTime.Month == time.Month && dataBaseFlightsArray[i].ArrivalDateTime.Hour == time.Hour && dataBaseFlightsArray[i].ArrivalDateTime.Minute == time.Minute)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplaySchedule();
            }
            else
            {
                //Console.WriteLine(dataBaseFlightsArray[0].DepartureDateTime);
                //Console.WriteLine(time);
                Console.WriteLine("The inforamtion not found");
            }

        }
        public void DataBaseSearchTheNearestOneHourFlightFromPort(DateTime time, string departurePort)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }


            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].DepartureDateTime == time)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
                }

                if (dataBaseFlightsArray[i].PortOfDeparture == departurePort)
                {
                    if (dataBaseFlightsArray[i].DepartureDateTime.Date == time.Date)
                    {
                        int value = Math.Abs((dataBaseFlightsArray[i].DepartureDateTime.Hour * 60 + dataBaseFlightsArray[i].DepartureDateTime.Minute) - (time.Hour * 60 + time.Minute));
                        //Console.WriteLine(value);

                        if (value <= 60)
                        {
                            counter++;
                            AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
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
        public void DataBaseSearchTheNearestOneHourFlightToPort(DateTime time, string arrivalPort)
        {
            DataSetClass ds = new DataSetClass();


            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightsArray = new FlightInformation[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i] = new FlightInformation("empty");
                }

                for (int i = 0; i < dataBaseFlightsArray.Length; i++)
                {
                    dataBaseFlightsArray[i].arrayFlightInformation[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightsArray[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightsArray[i].arrayFlightInformation[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightsArray[i].Airline = dt.Rows[i].ItemArray[1].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightsArray[i].DepartureDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseFlightsArray[i].arrayFlightInformation[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightsArray[i].ArrivalDateTime = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                    dataBaseFlightsArray[i].arrayFlightInformation[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightsArray[i].CityOfDeparture = dt.Rows[i].ItemArray[4].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightsArray[i].PortOfDeparture = dt.Rows[i].ItemArray[5].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightsArray[i].CityOfArrival = dt.Rows[i].ItemArray[6].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightsArray[i].PortOfArrival = dt.Rows[i].ItemArray[7].ToString();

                    dataBaseFlightsArray[i].arrayFlightInformation[8] = dt.Rows[i].ItemArray[8].ToString();
                    dataBaseFlightsArray[i].Terminal = dt.Rows[i].ItemArray[8].ToString();
                }

            }


            int counter = 0;
            FlightInformation[] tempArray = new FlightInformation[0];

            for (int i = 0; i < dataBaseFlightsArray.Length; i++)
            {
                if (dataBaseFlightsArray[i].ArrivalDateTime == time)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsArray[i]);
                }

                if (dataBaseFlightsArray[i].PortOfArrival == arrivalPort)
                {
                    if (dataBaseFlightsArray[i].ArrivalDateTime.Date == time.Date)
                    {
                        int value = Math.Abs((dataBaseFlightsArray[i].ArrivalDateTime.Hour * 60 + dataBaseFlightsArray[i].ArrivalDateTime.Minute) - (time.Hour * 60 + time.Minute));
                        //Console.WriteLine(value);

                        if (value <= 60)
                        {
                            counter++;
                            AddElementToArray(ref tempArray, counter, dataBaseFlightsArray[i]);
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
        #endregion
    }
}
