using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportPanel
{
    class FlightsBoard
    {
        FlightInformation[] schedule;
        //string[] flights = new string[9];
        public FlightsBoard(FlightInformation[] schd)
        {
            schedule = schd;

            //for (int i = 0; i < 9; i++)
            //{
            //    flights[i] = schedule[0].arrayFlightInformation[i];
            //}
        }

        public void DisplaySchedule()
        {
            string[] header = { "FlightNumb", "Airline", "DepartureTime", "ArrivalTime", "CityDepart", "PortDepart", "CityArriv", "PortArriv", "Terminal" };


            StringBuilder[,] flightsBoard = new StringBuilder[schedule.Length + 1, 9];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightsBoard.GetLength(1); j++)
                {
                    flightsBoard[i, j] = new StringBuilder();
                    flightsBoard[i, j].Append(header[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (22 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (22 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (10 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 8:
                            for (int k = 0; k < (8 - header[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }

                    //for (int k = 0; k < (15 - header[j].Length); k++)
                    //{
                    //    flightsBoard[i, j].Append(" ");
                    //}
                }
            }

            for (int i = 1; i < flightsBoard.GetLength(0); i++)
            {
                for (int j = 0; j < flightsBoard.GetLength(1); j++)
                {
                    flightsBoard[i, j] = new StringBuilder();
                    if (schedule[i - 1].arrayFlightInformation[j] == null)
                    {
                        schedule[i - 1].arrayFlightInformation[j] = "";
                    }
                    flightsBoard[i, j].Append(schedule[i - 1].arrayFlightInformation[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (12 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (15 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (22 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (22 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (15 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (12 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (15 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (10 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        case 8:
                            for (int k = 0; k < (8 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsBoard[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
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
        }
    }
}
