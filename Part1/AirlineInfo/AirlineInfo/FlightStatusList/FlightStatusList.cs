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
        public FlightStatus[] dataBaseTempDepartExpectArr;

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
                    dataBaseFlightStatus[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightStatus[i].arrayFlightStatus[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightStatus[i].Gate = Convert.ToInt32(dt.Rows[i].ItemArray[1]);

                    dataBaseFlightStatus[i].arrayFlightStatus[2] = dt.Rows[i].ItemArray[2].ToString();
                    if (dt.Rows[i].ItemArray[2].ToString() == "Finished")
                    {
                        dataBaseFlightStatus[i].CheckIn = CheckInStatus.Finished;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].CheckIn = CheckInStatus.NotFinished;
                    }

                    dataBaseFlightStatus[i].arrayFlightStatus[3] = dt.Rows[i].ItemArray[3].ToString();
                    if (dt.Rows[i].ItemArray[3].ToString() == "Closed")
                    {
                        dataBaseFlightStatus[i].GateClosed = GateClosedStatus.Closed;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].GateClosed = GateClosedStatus.NotClosed;
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[4] = dt.Rows[i].ItemArray[4].ToString();
                    if (dt.Rows[i].ItemArray[4].ToString() == "Cancelled")
                    {
                        dataBaseFlightStatus[i].Cancelled = CancelledStatus.Cancelled;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].Cancelled = CancelledStatus.NotCancelled;
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[5] = dt.Rows[i].ItemArray[5].ToString();
                    if (dt.Rows[i].ItemArray[5].ToString() == "InFlight")
                    {
                        dataBaseFlightStatus[i].InFlight = InFlightStatus.InFlight;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].InFlight = InFlightStatus.OnGround;
                    }

                    dataBaseFlightStatus[i].arrayFlightStatus[6] = dt.Rows[i].ItemArray[6].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[6] == "")
                    {
                        dataBaseFlightStatus[i].DepartedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].DepartedAt = Convert.ToDateTime(dt.Rows[i].ItemArray[6]);
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[7] = dt.Rows[i].ItemArray[7].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[7] == "")
                    {
                        dataBaseFlightStatus[i].ExpectedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].ExpectedAt = Convert.ToDateTime(dataBaseFlightStatus[i].arrayFlightStatus[7]);
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[8] = dt.Rows[i].ItemArray[8].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[8] == "")
                    {
                        dataBaseFlightStatus[i].ArrivedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].ArrivedAt = Convert.ToDateTime(dataBaseFlightStatus[i].arrayFlightStatus[8]);
                    }


                }

            }



            new FlightsBoard(dataBaseFlightStatus).DisplayFlightStatus();
        }
        public void DisplayDataBaseTemporaryDepartExpectArrivData()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM TemporaryDepartExpectArrivData";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseTempDepartExpectArr = new FlightStatus[dt.Rows.Count];

                for (int i = 0; i < dataBaseTempDepartExpectArr.Length; i++)
                {
                    dataBaseTempDepartExpectArr[i] = new FlightStatus();
                }

                for (int i = 0; i < dataBaseTempDepartExpectArr.Length; i++)
                {
                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseTempDepartExpectArr[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseTempDepartExpectArr[i].tempDeprAt = Convert.ToDateTime(dt.Rows[i].ItemArray[1]);

                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseTempDepartExpectArr[i].tempExpectedAt = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseTempDepartExpectArr[i].tempArrAt = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                }

            }




            new FlightsBoard(dataBaseTempDepartExpectArr).DisplayTempDepartExpectArrFlightStatus();
        }
        public void DataBaseFlightStatuSerachByFlightNumber(int number)
        {
            int counter = 0;
            FlightStatus[] tempArray = new FlightStatus[0];

            for (int i = 0; i < dataBaseFlightStatus.Length; i++)
            {
                if (dataBaseFlightStatus[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightStatus[i]);
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
        public void DataBaseSerachByFlightNumberFlightStatus(int number)
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
                    dataBaseFlightStatus[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightStatus[i].arrayFlightStatus[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightStatus[i].Gate = Convert.ToInt32(dt.Rows[i].ItemArray[1]);

                    dataBaseFlightStatus[i].arrayFlightStatus[2] = dt.Rows[i].ItemArray[2].ToString();
                    if (dt.Rows[i].ItemArray[2].ToString() == "Finished")
                    {
                        dataBaseFlightStatus[i].CheckIn = CheckInStatus.Finished;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].CheckIn = CheckInStatus.NotFinished;
                    }

                    dataBaseFlightStatus[i].arrayFlightStatus[3] = dt.Rows[i].ItemArray[3].ToString();
                    if (dt.Rows[i].ItemArray[3].ToString() == "Closed")
                    {
                        dataBaseFlightStatus[i].GateClosed = GateClosedStatus.Closed;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].GateClosed = GateClosedStatus.NotClosed;
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[4] = dt.Rows[i].ItemArray[4].ToString();
                    if (dt.Rows[i].ItemArray[4].ToString() == "Cancelled")
                    {
                        dataBaseFlightStatus[i].Cancelled = CancelledStatus.Cancelled;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].Cancelled = CancelledStatus.NotCancelled;
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[5] = dt.Rows[i].ItemArray[5].ToString();
                    if (dt.Rows[i].ItemArray[5].ToString() == "InFlight")
                    {
                        dataBaseFlightStatus[i].InFlight = InFlightStatus.InFlight;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].InFlight = InFlightStatus.OnGround;
                    }

                    dataBaseFlightStatus[i].arrayFlightStatus[6] = dt.Rows[i].ItemArray[6].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[6] == "")
                    {
                        dataBaseFlightStatus[i].DepartedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].DepartedAt = Convert.ToDateTime(dt.Rows[i].ItemArray[6]);
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[7] = dt.Rows[i].ItemArray[7].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[7] == "")
                    {
                        dataBaseFlightStatus[i].ExpectedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].ExpectedAt = Convert.ToDateTime(dataBaseFlightStatus[i].arrayFlightStatus[7]);
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[8] = dt.Rows[i].ItemArray[8].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[8] == "")
                    {
                        dataBaseFlightStatus[i].ArrivedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].ArrivedAt = Convert.ToDateTime(dataBaseFlightStatus[i].arrayFlightStatus[8]);
                    }


                }

            }



            int counter = 0;
            FlightStatus[] tempArray = new FlightStatus[0];

            for (int i = 0; i < dataBaseFlightStatus.Length; i++)
            {
                if (dataBaseFlightStatus[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBaseFlightStatus[i]);
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
        public void DataBaseCheckUpdateFlightStatusArray(FlightStatusHandler callback)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM TemporaryDepartExpectArrivData";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBaseTempDepartExpectArr = new FlightStatus[dt.Rows.Count];

                for (int i = 0; i < dataBaseTempDepartExpectArr.Length; i++)
                {
                    dataBaseTempDepartExpectArr[i] = new FlightStatus();
                }

                for (int i = 0; i < dataBaseTempDepartExpectArr.Length; i++)
                {
                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBaseTempDepartExpectArr[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseTempDepartExpectArr[i].tempDeprAt = Convert.ToDateTime(dt.Rows[i].ItemArray[1]);

                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[2] = dt.Rows[i].ItemArray[2].ToString();
                    dataBaseTempDepartExpectArr[i].tempExpectedAt = Convert.ToDateTime(dt.Rows[i].ItemArray[2]);

                    dataBaseTempDepartExpectArr[i].arrayTempDepartExpecArr[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBaseTempDepartExpectArr[i].tempArrAt = Convert.ToDateTime(dt.Rows[i].ItemArray[3]);

                }

            }

            string connectionString2 = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql2 = "SELECT * FROM FlightStatusList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql2, connection);

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
                    dataBaseFlightStatus[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBaseFlightStatus[i].arrayFlightStatus[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBaseFlightStatus[i].Gate = Convert.ToInt32(dt.Rows[i].ItemArray[1]);

                    dataBaseFlightStatus[i].arrayFlightStatus[2] = dt.Rows[i].ItemArray[2].ToString();
                    if (dt.Rows[i].ItemArray[2].ToString() == "Finished")
                    {
                        dataBaseFlightStatus[i].CheckIn = CheckInStatus.Finished;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].CheckIn = CheckInStatus.NotFinished;
                    }

                    dataBaseFlightStatus[i].arrayFlightStatus[3] = dt.Rows[i].ItemArray[3].ToString();
                    if (dt.Rows[i].ItemArray[3].ToString() == "Closed")
                    {
                        dataBaseFlightStatus[i].GateClosed = GateClosedStatus.Closed;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].GateClosed = GateClosedStatus.NotClosed;
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[4] = dt.Rows[i].ItemArray[4].ToString();
                    if (dt.Rows[i].ItemArray[4].ToString() == "Cancelled")
                    {
                        dataBaseFlightStatus[i].Cancelled = CancelledStatus.Cancelled;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].Cancelled = CancelledStatus.NotCancelled;
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[5] = dt.Rows[i].ItemArray[5].ToString();
                    if (dt.Rows[i].ItemArray[5].ToString() == "InFlight")
                    {
                        dataBaseFlightStatus[i].InFlight = InFlightStatus.InFlight;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].InFlight = InFlightStatus.OnGround;
                    }

                    dataBaseFlightStatus[i].arrayFlightStatus[6] = dt.Rows[i].ItemArray[6].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[6] == "")
                    {
                        dataBaseFlightStatus[i].DepartedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].DepartedAt = Convert.ToDateTime(dt.Rows[i].ItemArray[6]);
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[7] = dt.Rows[i].ItemArray[7].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[7] == "")
                    {
                        dataBaseFlightStatus[i].ExpectedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].ExpectedAt = Convert.ToDateTime(dataBaseFlightStatus[i].arrayFlightStatus[7]);
                    }


                    dataBaseFlightStatus[i].arrayFlightStatus[8] = dt.Rows[i].ItemArray[8].ToString();
                    if (dataBaseFlightStatus[i].arrayFlightStatus[8] == "")
                    {
                        dataBaseFlightStatus[i].ArrivedAt = null;
                    }
                    else
                    {
                        dataBaseFlightStatus[i].ArrivedAt = Convert.ToDateTime(dataBaseFlightStatus[i].arrayFlightStatus[8]);
                    }

                    dataBaseFlightStatus[i].Notify += callback;
                }

            }


            for (int i = 0; i < dataBaseFlightStatus.Length; i++)
            {
                //dataBaseFlightStatus[i].CheckUpdateStatus();
                dataBaseFlightStatus[i].DataBaseCheckUpdateStatus(dataBaseTempDepartExpectArr[i]);
            }



        }
        public void DataBaseFlightStatusListUpdateDepartArr(int number)
        {
            DateTime departDate = new DateTime();
            
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM TemporaryDepartExpectArrivData";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dt.PrimaryKey = new DataColumn[] { dt.Columns["FlighNumb"] };

                DataRow rowObject = dt.Rows.Find(number);
                int rowIndex = dt.Rows.IndexOf(rowObject);
                int cellIndex = dt.Columns.IndexOf("TempDepartedAt");

                DataRow dr = dt.Rows[rowIndex];
                departDate = Convert.ToDateTime(dr[cellIndex]);


            }

            string connectionString2 = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql2 = "SELECT * FROM FlightStatusList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql2, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dt.PrimaryKey = new DataColumn[] { dt.Columns["FlighNumb"] };

                DataRow rowObject = dt.Rows.Find(number);
                int rowIndex = dt.Rows.IndexOf(rowObject);
                int cellIndex = dt.Columns.IndexOf("DepartedAt");

                DataRow dr = dt.Rows[rowIndex];
                dr[cellIndex] = departDate;

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dt);

            }
            #endregion
        }
    }
}