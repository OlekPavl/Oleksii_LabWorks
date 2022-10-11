using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AirlineInfo
{
    internal class PriceList
    {
        public int counter = 0;
        public Price[] priceArrayList = new Price[0];
        public Price[] dataBasePriceList;

        #region Methods to work with arrays from the program
        public void AddPrice(FlightInformation flight)
        {

            counter++;

            Price[] tempArray = new Price[counter];
            for (int i = 0; i < priceArrayList.Length; i++)
            {
                tempArray[i] = priceArrayList[i];
            }
            priceArrayList = tempArray;

            for (int i = 0; i < priceArrayList.Length; i++)
            {
                if (priceArrayList[i] == null)
                {
                    priceArrayList[i] = new Price(flight);
                    break;
                }
            }

        }
        public void DisplayPriceArray()
        {
            new FlightsBoard(priceArrayList).DisplayPriceList();
        }
        public void AddElementToArray(ref Price[] array, int count, Price flight)
        {

            Price[] tempArray = new Price[count];
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
            Price[] tempArray = new Price[0];

            for (int i = 0; i < priceArrayList.Length; i++)
            {
                if (priceArrayList[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, priceArrayList[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplayPriceList();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }
        #endregion

        #region Methods to work with database
        public void DataBaseDisplayPriceArray()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM PriceList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBasePriceList = new Price[dt.Rows.Count];

                for (int i = 0; i < dataBasePriceList.Length; i++)
                {
                    dataBasePriceList[i] = new Price();
                }

                for (int i = 0; i < dataBasePriceList.Length; i++)
                {
                    dataBasePriceList[i].arrayPrice[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBasePriceList[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBasePriceList[i].arrayPrice[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBasePriceList[i].EuroPrice = Convert.ToInt32(dt.Rows[i].ItemArray[1]);

                    dataBasePriceList[i].arrayPrice[2] = dt.Rows[i].ItemArray[2].ToString();

                    dataBasePriceList[i].arrayPrice[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBasePriceList[i].USDPrice = Convert.ToInt32(dt.Rows[i].ItemArray[3]);

                    dataBasePriceList[i].arrayPrice[4] = dt.Rows[i].ItemArray[4].ToString();


                }

            }

            new FlightsBoard(dataBasePriceList).DisplayPriceList();
        }
        public void DataBaseSearchByFlightNumberPriceArray(int number)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = AirlineInfo;Integrated Security=True;";
            string sql = "SELECT * FROM PriceList";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);



                dataBasePriceList = new Price[dt.Rows.Count];

                for (int i = 0; i < dataBasePriceList.Length; i++)
                {
                    dataBasePriceList[i] = new Price();
                }

                for (int i = 0; i < dataBasePriceList.Length; i++)
                {
                    dataBasePriceList[i].arrayPrice[0] = dt.Rows[i].ItemArray[0].ToString();
                    dataBasePriceList[i].FlightNumber = Convert.ToInt32(dt.Rows[i].ItemArray[0]);

                    dataBasePriceList[i].arrayPrice[1] = dt.Rows[i].ItemArray[1].ToString();
                    dataBasePriceList[i].EuroPrice = Convert.ToInt32(dt.Rows[i].ItemArray[1]);

                    dataBasePriceList[i].arrayPrice[2] = dt.Rows[i].ItemArray[2].ToString();

                    dataBasePriceList[i].arrayPrice[3] = dt.Rows[i].ItemArray[3].ToString();
                    dataBasePriceList[i].USDPrice = Convert.ToInt32(dt.Rows[i].ItemArray[3]);

                    dataBasePriceList[i].arrayPrice[4] = dt.Rows[i].ItemArray[4].ToString();
                }

            }

            int counter = 0;
            Price[] tempArray = new Price[0];

            for (int i = 0; i < dataBasePriceList.Length; i++)
            {
                if (dataBasePriceList[i].FlightNumber == number)
                {
                    counter++;
                    AddElementToArray(ref tempArray, counter, dataBasePriceList[i]);
                }
            }
            if (tempArray.Length > 0)
            {
                new FlightsBoard(tempArray).DisplayPriceList();
            }
            else
            {
                Console.WriteLine("The inforamtion not found");
            }
        }

        #endregion
    }
}
