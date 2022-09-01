using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    internal class PriceList
    {
        public int counter = 0;
        public Price[] priceArrayList = new Price[0];
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
    }
}
