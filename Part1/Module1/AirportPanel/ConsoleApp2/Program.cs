using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] flightsBoard = new string[2, 9]
            //{ { "FlightNumber", "Airline", "DepartureDateTime", "ArrivalDateTime", "CityOfDeparture", "PortOfDeparture", "CityOfArrival", "PortOfArrival", "Terminal"},
            //  { "125", "sfsdfs", "sdfdfsfd", "sdfsdf", "fsdfs", "dsfsdf", "fsdfs", "sdfsfs", "dsfsdfsdf"}
            //};

            //for (int i = 0; i < flightsBoard.GetLength(0); i++)
            //{
            //    for (int j = 0; j < flightsBoard.GetLength(1); j++)
            //    {
            //        Console.Write($"{flightsBoard[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            string[] header = { "FlightNumber", "Airline", "DepartureTime", "ArrivalTime", "CityDepart", "PortDeparture", "CityArriv", "PortArriv", "Terminal" };
            string[] flight1 = { "125", "sfsdfs", "sdfdfsfd", "sdfsdf", "fsdfs", "dsfsdf", "fsdfs", "sdfsfs", "dsfsdfsdf" };

            StringBuilder[,] flightsBoard = new StringBuilder[2, 9];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightsBoard.GetLength(1); j++)
                {
                    flightsBoard[i, j] = new StringBuilder();
                    //flightsBoard[i, j].Length = 16;
                    flightsBoard[i, j].Append(header[j]);
                    for (int k = 0; k < (15 - header[j].Length); k++)
                    {
                        flightsBoard[i, j].Append(" ");
                    }
                }
            }

            for (int i = 1; i < flightsBoard.GetLength(0); i++)
            {
                for (int j = 0; j < flightsBoard.GetLength(1); j++)
                {
                    flightsBoard[i, j] = new StringBuilder();
                    //flightsBoard[i, j].Length = 16;
                    flightsBoard[i, j].Append(flight1[j]);
                    for (int k = 0; k < (15 - flight1[j].Length); k++)
                    {
                        flightsBoard[i, j].Append(" ");
                    }
                }
            }


            for (int i = 0; i < flightsBoard.GetLength(0); i++)
            {
                for (int j = 0; j < flightsBoard.GetLength(1); j++)
                {
                    Console.Write(flightsBoard[i, j]);
                }
                Console.WriteLine();
            }


            //string[,] flightsBoard = new string[1, 17]
            //{ { "FlightNumber", "Airline", "DepartureDateTime", "ArrivalDateTime", "CityOfDeparture", "PortOfDeparture", "CityOfArrival", "PortOfArrival", "Terminal", "Gate", "CheckIn", "GateClosed", "InFlight", "Cancelled", "DepartedAt", "ExpectedAt", "ArrivedAt"} };

            //for (int i = 0; i < flightsBoard.GetLength(0); i++)
            //{
            //    for (int j = 0; j < flightsBoard.GetLength(1); j++)
            //    {
            //        Console.Write(flightsBoard[i, j]);

            //    }
            //}


            Console.ReadKey();
        }
    }
}
