﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AirlineInfo
{
    internal class SchedulePassengerList
    {
        int counter = 0;
        public FlightPassengerList[] schedulePassengersArray = new FlightPassengerList[0];
        public FlightPassengerList[] dataBaseSchedulePassengersArray;

        #region Methods to work with program arrays
        public void AddPassengersToSchedulesPassengersList(FlightPassengerList flightPassengers)
        {
            counter++;
            FlightPassengerList[] tempArray = new FlightPassengerList[counter];

            for (int j = 0; j < schedulePassengersArray.Length; j++)
            {
                tempArray[j] = schedulePassengersArray[j];
            }
            schedulePassengersArray = tempArray;

            for (int j = 0; j < schedulePassengersArray.Length; j++)
            {
                if (schedulePassengersArray[j] == null)
                {
                    schedulePassengersArray[j] = flightPassengers;

                    //for (int i = 0; i < flightPassengers.flightPassengersArrayList.Length; i++)
                    //{
                    //    flightPassengers.flightPassengersArrayList[i].Passport = GeneratePassportNumber();
                    //    schedulePassengersArray[j].flightPassengersArrayList[j].Passport = flightPassengers.flightPassengersArrayList[i].Passport;
                    //}
                                   
                    //int number = GeneratePassportNumber();
                    //schedulePassengersArrayList[i].Passport = number;
                    //schedulePassengersArray[i].arrayPassenger[4] = number.ToString();
                    break;
                }
            }

            int GeneratePassportNumber()
            {
                Random random = new Random();

                int number;

                while (true)
                {
                    number = random.Next(1000, 9999);
                    bool status = false;
                    foreach (var flight in schedulePassengersArray)
                    {
                        foreach (var passenger in flight.flightPassengersArrayList)
                        {
                            if (number == passenger.Passport)
                            {
                                status = true;
                            }
                        }
                    }
                    if (status == false)
                    {
                        return number;
                    }
                }

            }


            //int GeneratePassportNumber()
            //{
            //    Random random = new Random();

            //    int number;

            //    while (true)
            //    {
            //        number = random.Next(1000, 9999);
            //        bool status = false;
            //        foreach (var item in flightPassengersArrayList)
            //        {
            //            if (number == item.Passport)
            //            {
            //                status = true;
            //            }
            //        }
            //        if (status == false)
            //        {
            //            return number;
            //        }
            //    }

            //}

        }
        public void DisplaySchedulePassengerArray()
        {
            new FlightsBoard(schedulePassengersArray).DisplaySchedulePassengerList();
        }
        #endregion

        #region Methods to work with database
        public void AddFlightPassengersToSchedulesPassengersList(int[] numberOfPassengers, int[] uniqueNumberOfFlights)
        {
            dataBaseSchedulePassengersArray = new FlightPassengerList[uniqueNumberOfFlights.Length];
            int[] passengers = numberOfPassengers;



            for (int i = 0; i < dataBaseSchedulePassengersArray.Length; i++)
            {
                dataBaseSchedulePassengersArray[i] = new FlightPassengerList();

                var flightNumberOfPassengers = from p in passengers
                                               where p == uniqueNumberOfFlights[i]
                                               select p;
                
                int number = flightNumberOfPassengers.Count();

                dataBaseSchedulePassengersArray[i].AddEmptyPassengersToFlight(number);
            }
        }
        public void CreateEmptyFlighPassengersArray(DataTable dt)
        {
            int[] array = new int[dt.Rows.Count];
            int[] uniqueArray = new int[0];
            int uniqueCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (!uniqueArray.Contains(array[i]))
                {
                    uniqueCounter++;
                    AddElementToArray(ref uniqueArray, uniqueCounter, array[i]);
                }
            }

            void AddElementToArray(ref int[] array, int counter, int number)
            {

                int[] tempArray = new int[counter];
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        array[i] = number;
                        break;
                    }
                }

            }


            AddFlightPassengersToSchedulesPassengersList(array, uniqueArray);
        }
        public void DisplayDataBaseSchedulePassengerArray()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM PassengerList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //foreach (DataColumn column in dt.Columns)
                //    Console.Write($"{column.ColumnName}\t");
                //Console.WriteLine();
                //// перебор всех строк таблицы
                //foreach (DataRow row in dt.Rows)
                //{
                //    // получаем все ячейки строки
                //    var cells = row.ItemArray;
                //    foreach (object cell in cells)
                //        Console.Write($"{cell}\t");
                //    Console.WriteLine();
                //}

                CreateEmptyFlighPassengersArray(dt);

                int counter = 0;

                for (int i = 0; i < dataBaseSchedulePassengersArray.Length; i++)
                {
                    for (int j = 0; j < dataBaseSchedulePassengersArray[i].flightPassengersArrayList.Length; j++)
                    {
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[0] = dt.Rows[counter].ItemArray[0].ToString();
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[1] = dt.Rows[counter].ItemArray[1].ToString();
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[2] = dt.Rows[counter].ItemArray[2].ToString();
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[3] = dt.Rows[counter].ItemArray[3].ToString();
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[4] = dt.Rows[counter].ItemArray[4].ToString();
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[5] = dt.Rows[counter].ItemArray[5].ToString();
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[6] = dt.Rows[counter].ItemArray[6].ToString();
                        dataBaseSchedulePassengersArray[i].flightPassengersArrayList[j].arrayPassenger[7] = dt.Rows[counter].ItemArray[7].ToString();

                        counter++;
                    }

                }

            }


            new FlightsBoard(dataBaseSchedulePassengersArray).DisplaySchedulePassengerList();
        }
        #endregion
    }
}
