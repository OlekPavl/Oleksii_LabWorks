using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AirlineInfo
{
    internal class FlightStatusList
    {
        public int counter = 0;
        public FlightStatus[] flightsStatusArray = new FlightStatus[0];
        public FlightStatus[] dataBaseFlightStatus;

        #region Methods to work with arrays from the program
        public void AddFlightStatus(FlightInformation flight, FlightStatusHandler callback)
        {

            counter++;

            FlightStatus[] tempArray = new FlightStatus[counter];
            for (int i = 0; i < flightsStatusArray.Length; i++)
            {
                tempArray[i] = flightsStatusArray[i];
            }
            flightsStatusArray = tempArray;

            for (int i = 0; i < flightsStatusArray.Length; i++)
            {
                if (flightsStatusArray[i] == null)
                {
                    flightsStatusArray[i] = new FlightStatus(flight);
                    flightsStatusArray[i].Notify += callback;
                    break;
                }
            }

        }
        public void CheckUpdateFlightStatusArray()
        {
            foreach (var item in flightsStatusArray)
            {
                item.CheckUpdateStatus();
            }
        }
        public void DisplayFlightsStatusArray()
        {
            new FlightsBoard(flightsStatusArray).DisplayFlightStatus();
        }
        public void AddElementToArray(ref FlightStatus[] array, int count, FlightStatus flight)
        {

            FlightStatus[] tempArray = new FlightStatus[count];
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
            FlightStatus[] tempArray = new FlightStatus[0];

            for (int i = 0; i < flightsStatusArray.Length; i++)
            {
                if (flightsStatusArray[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, flightsStatusArray[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplayFlightStatus();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        #endregion

        #region Methods to work with database
        public void DisplayDataBaseFlightsStatusArray()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM FlightStatusList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseFlightStatus = new FlightStatus[dt.Rows.Count];

                for (int i = 0; i < dataBaseFlightStatus.Length; i++)
                {
                    dataBaseFlightStatus[i] = new FlightStatus("empty");
                }

                for (int i = 0; i < dataBaseFlightStatus.Length; i++)
                {
                    dataBaseFlightStatus[i].arrayFlightStatus[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[4] = dt.Rows[i].ItemArray[4].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[5] = dt.Rows[i].ItemArray[5].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[6] = dt.Rows[i].ItemArray[6].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[7] = dt.Rows[i].ItemArray[7].ToString();
                    dataBaseFlightStatus[i].arrayFlightStatus[8] = dt.Rows[i].ItemArray[8].ToString();
                }

            }




            new FlightsBoard(dataBaseFlightStatus).DisplayFlightStatus();
        }
        #endregion
    }
}
