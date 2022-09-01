using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AirlineInfo
{
    internal class SQLServerDataBaseClass
    {
        DataSet ds;
        DataTable dtFlightSchedule;
        DataTable dtFlightStatusList;
        DataTable dtPriceList;
        DataTable dtPassengerList;
        public SQLServerDataBaseClass(DataSetClass dsc)
        {
            this.ds = dsc.flightDataSet;
            dtFlightSchedule = dsc.flightSchedule;
            dtFlightStatusList = dsc.flightStatusList;
            dtPriceList = dsc.priceList;
            dtPassengerList = dsc.passengersList;
        }

        #region FlightSchedule
        public void CreateTableFlightScheduleInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "CREATE TABLE FlightSсhedule" +
                "(" +
                    "FlightNumber INT, " +
                    "AirLine NVARCHAR(30)," +
                    "DepartureTime DATETIME," +
                    "ArrivalTime DATETIME," +
                    "CityDepart NVARCHAR(30)," +
                    "PortDepart NVARCHAR(30)," +
                    "CityArriv NVARCHAR(30)," +
                    "PortArriv NVARCHAR(30)," +
                    "Terminal NVARCHAR(30)," +
                    "CONSTRAINT PK_FlightSchedule_FlightNumber PRIMARY KEY (FlightNumber)" +
           
                ")";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Таблица создана");

            }

        }
        public void UpdateTableFlightScheduleInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                SqlCommandBuilder commandBiulder = new SqlCommandBuilder(adapter);

                adapter.Update(dtFlightSchedule);

                Console.WriteLine("Table updated");

            }

        }
        public void ClearTableFlightScheduleInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "DELETE FlightSсhedule";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Table FlightSchedule cleared");

            }

        }
        #endregion

        #region FlightStatusList
        public void CreateTableFlightStatusListInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "CREATE TABLE FlightStatusList " +
                "(" +
                    "FlighNumb INT, " +
                    "Gate INT," +
                    "CheckIn NVARCHAR(30)," +
                    "GateClosed NVARCHAR(30)," +
                    "Cancelled NVARCHAR(30)," +
                    "InFlight NVARCHAR(30)," +
                    "DepartedAt DATETIME," +
                    "ExpectedAt DATETIME," +
                    "ArrivedAt DATETIME," +
                    "CONSTRAINT PK_FlightStatusList_FlightNumber PRIMARY KEY (FlighNumb)," +
                    "CONSTRAINT FK_FlightStatusList_To_FlightSchedule FOREIGN KEY (FlighNumb) REFERENCES FlightSchedule(FlightNumber)" +
                ")";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Таблица создана");

            }

        }
        public void UpdateTableStatusListInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightStatusList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                SqlCommandBuilder commandBiulder = new SqlCommandBuilder(adapter);

                adapter.Update(dtFlightStatusList);

                Console.WriteLine("Table updated");

            }

        }
        public void ClearTableFlightStatusListInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "DELETE FlightStatusList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Table FlightStatusList cleared");

            }

        }
        #endregion

        #region PriceList
        public void CreateTablePriceListInDatabase()
        {
            string[] header = { "FlightNumb", "EuroPrice", "Currency", "UsdPrice", "Currency" };

            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "CREATE TABLE PriceList " +
                "(" +
                    "FlightNumb INT, " +
                    "EuroPrice INT," +
                    "CurrencyEURO NVARCHAR(30)," +
                    "UsdPrice INT," +
                    "CurrencyUSD NVARCHAR(30)," +
                    "CONSTRAINT PK_PriceList_FlightNumb PRIMARY KEY (FlightNumb)," +
                    "CONSTRAINT FK_PriceList_To_FlightSchedule FOREIGN KEY (FlightNumb) REFERENCES FlightSchedule(FlightNumber)" +
                ")";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Таблица создана");

            }

        }
        public void UpdateTablePriceListInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM PriceList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                SqlCommandBuilder commandBiulder = new SqlCommandBuilder(adapter);

                adapter.Update(dtPriceList);

                Console.WriteLine("Table updated");

            }

        }
        public void ClearTablePriceListInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "DELETE PriceList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Table PriceList cleared");

            }

        }
        #endregion

        #region PassengerList
        public void CreateTablePassengerListInDatabase()
        {
            string[] header = { "FlightNumb", "FirstName", "SecondName", "Nationality", "Passport", "DateOfBirthday", "Sex", "Class" };

            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "CREATE TABLE PassengerList" +
                "(" +
                    "FlightNumb INT, " +
                    "FirstName NVARCHAR(30)," +
                    "SecondName NVARCHAR(30)," +
                    "Nationality NVARCHAR(30)," +
                    "Passport INT," +
                    "DateOfBirthday NVARCHAR(30)," +
                    "Sex NVARCHAR(30)," +
                    "Class NVARCHAR(30)," +
                    "CONSTRAINT PK_PassengerList_FlightNumb_Passport PRIMARY KEY (FlightNumb, Passport)," +
                    "CONSTRAINT FK_PassengerList_To_FlightSchedule FOREIGN KEY (FlightNumb) REFERENCES FlightSсhedule(FlightNumber)" +
                ")";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Таблица создана");

            }

        }
        public void UpdateTablePassengerListInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM PassengerList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                SqlCommandBuilder commandBiulder = new SqlCommandBuilder(adapter);

                adapter.Update(dtPassengerList);

                Console.WriteLine("Table updated");

            }

        }
        public void ClearTablePassengerListInDatabase()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "DELETE PassengerList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Table PassengerList cleared");

            }

        }
        #endregion
    }
}
