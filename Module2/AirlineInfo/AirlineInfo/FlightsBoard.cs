using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    class FlightsBoard
    {
        FlightInformation[] schedule;
        FlightStatus[] statusOfFlight;
        public FlightsBoard(FlightInformation[] schd)
        {
            schedule = schd;

        }
        public FlightsBoard(FlightStatus[] flghSt)
        {
            statusOfFlight = flghSt;
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
        public void DisplayFlightStatus()
        {
            string[] header = { "FlighNumb", "Gate", "CheckIn", "GateClosed", "InFlight", "Cancelled", "DepartedAt", "ExpectedAt", "ArrivedAt" };


            StringBuilder[,] flightsStatusBoard = new StringBuilder[schedule.Length + 1, 9];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightsStatusBoard.GetLength(1); j++)
                {
                    flightsStatusBoard[i, j] = new StringBuilder();
                    flightsStatusBoard[i, j].Append(header[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (22 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (22 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (10 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 8:
                            for (int k = 0; k < (8 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }

                }
            }

            for (int i = 1; i < flightsStatusBoard.GetLength(0); i++)
            {
                for (int j = 0; j < flightsStatusBoard.GetLength(1); j++)
                {
                    flightsStatusBoard[i, j] = new StringBuilder();
                    if (statusOfFlight[i - 1].arrayFlightStatus[j] == null)
                    {
                        statusOfFlight[i - 1].arrayFlightStatus[j] = "";
                    }
                    flightsStatusBoard[i, j].Append(statusOfFlight[i - 1].arrayFlightStatus[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (12 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (15 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (22 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (22 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (15 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (12 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (15 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (10 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 8:
                            for (int k = 0; k < (8 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }


            for (int i = 0; i < flightsStatusBoard.GetLength(0); i++)
            {
                for (int j = 0; j < flightsStatusBoard.GetLength(1); j++)
                {
                    Console.Write(flightsStatusBoard[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void DisplayPriceList()
        {
            string[] header = { "FlightNumb", "Price", "Currency"};


            StringBuilder[,] flightsPrices = new StringBuilder[schedule.Length + 1, 3];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightsPrices.GetLength(1); j++)
                {
                    flightsPrices[i, j] = new StringBuilder();
                    flightsPrices[i, j].Append(header[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (8 - header[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (5 - header[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }

                }
            }

            for (int i = 1; i < flightsPrices.GetLength(0); i++)
            {
                for (int j = 0; j < flightsPrices.GetLength(1); j++)
                {
                    flightsPrices[i, j] = new StringBuilder();
                    if (schedule[i - 1].arrayFlightInformation[j] == null)
                    {
                        schedule[i - 1].arrayFlightInformation[j] = "";
                    }
                    flightsPrices[i, j].Append(schedule[i - 1].arrayFlightInformation[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (12 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (8 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (5 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }


            for (int i = 0; i < flightsPrices.GetLength(0); i++)
            {
                for (int j = 0; j < flightsPrices.GetLength(1); j++)
                {
                    Console.Write(flightsPrices[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
