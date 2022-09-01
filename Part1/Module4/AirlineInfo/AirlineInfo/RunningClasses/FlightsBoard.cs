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
        Price[] priceList;
        Passenger[] passengerList;
        FlightPassengerList[] flightPassengerList;

        public FlightsBoard(FlightInformation[] schd)
        {
            schedule = schd;

        }
        public FlightsBoard(FlightStatus[] flghSt)
        {
            statusOfFlight = flghSt;
        }
        public FlightsBoard(Price[] priceListArray)
        {
            priceList = priceListArray;
        }
        public FlightsBoard(Passenger[] passengList )
        {
            passengerList = passengList;
        }
        public FlightsBoard(FlightPassengerList[] flightPassList)
        {
            flightPassengerList = flightPassList;
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
                            for (int k = 0; k < (20 - header[j].Length); k++)
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
                            for (int k = 0; k < (20 - header[j].Length); k++)
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
                            for (int k = 0; k < (20 - header[j].Length); k++)
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
                            for (int k = 0; k < (20 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
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
                            for (int k = 0; k < (20 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
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
                            for (int k = 0; k < (20 - schedule[i - 1].arrayFlightInformation[j].Length); k++)
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
            string[] header = { "FlighNumb", "Gate", "CheckIn", "GateClosed", "Cancelled", "InFlight", "DepartedAt", "ExpectedAt", "ArrivedAt" };


            StringBuilder[,] flightsStatusBoard = new StringBuilder[statusOfFlight.Length + 1, 9];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightsStatusBoard.GetLength(1); j++)
                {
                    flightsStatusBoard[i, j] = new StringBuilder();
                    flightsStatusBoard[i, j].Append(header[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (10 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (5 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (13 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (9 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (21 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (21 - header[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 8:
                            for (int k = 0; k < (21 - header[j].Length); k++)
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
                            for (int k = 0; k < (10 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (5 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (12 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (12 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (13 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (9 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (21 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (21 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
                            {
                                flightsStatusBoard[i, j].Append(" ");
                            }
                            break;
                        case 8:
                            for (int k = 0; k < (21 - statusOfFlight[i - 1].arrayFlightStatus[j].Length); k++)
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
            string[] header = { "FlightNumb", "EuroPrice", "Currency", "USDPrice", "Currency" };


            StringBuilder[,] flightsPrices = new StringBuilder[priceList.Length + 1, 5];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightsPrices.GetLength(1); j++)
                {
                    flightsPrices[i, j] = new StringBuilder();
                    flightsPrices[i, j].Append(header[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (11 - header[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (10 - header[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (9 - header[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (9 - header[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (9 - header[j].Length); k++)
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
                    if (priceList[i - 1].arrayPrice[j] == null)
                    {
                        priceList[i - 1].arrayPrice[j] = "";
                    }
                    flightsPrices[i, j].Append(priceList[i - 1].arrayPrice[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (11 - priceList[i - 1].arrayPrice[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (10 - priceList[i - 1].arrayPrice[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (9 - priceList[i - 1].arrayPrice[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (9 - priceList[i - 1].arrayPrice[j].Length); k++)
                            {
                                flightsPrices[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (9 - priceList[i - 1].arrayPrice[j].Length); k++)
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
        public void DisplayFlightPassengerList()
        {
            string[] header = { "FlightNumb", "FirstName", "SecondName", "Nationality", "Passport", "DateOfBirthday", "Sex", "Class" };


            StringBuilder[,] flightPassengers = new StringBuilder[passengerList.Length + 1, 8];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightPassengers.GetLength(1); j++)
                {
                    flightPassengers[i, j] = new StringBuilder();
                    flightPassengers[i, j].Append(header[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (11 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (14 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (9 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (8 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (8 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }

                }
            }

            for (int i = 1; i < flightPassengers.GetLength(0); i++)
            {
                for (int j = 0; j < flightPassengers.GetLength(1); j++)
                {
                    flightPassengers[i, j] = new StringBuilder();
                    if (passengerList[i - 1].arrayPassenger[j] == null)
                    {
                        passengerList[i - 1].arrayPassenger[j] = "";
                    }
                    flightPassengers[i, j].Append(passengerList[i - 1].arrayPassenger[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (11 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (12 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (12 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (14 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (9 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (15 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (8 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (8 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            for (int i = 0; i < flightPassengers.GetLength(0); i++)
            {
                for (int j = 0; j < flightPassengers.GetLength(1); j++)
                {
                    Console.Write(flightPassengers[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void DisplayFlightPassengerListWithoutHeader(Passenger[] passengerList)
        {

            StringBuilder[,] flightPassengers = new StringBuilder[passengerList.Length, 8];

            for (int i = 1; i < flightPassengers.GetLength(0); i++)
            {
                for (int j = 0; j < flightPassengers.GetLength(1); j++)
                {
                    flightPassengers[i, j] = new StringBuilder();
                    if (passengerList[i - 1].arrayPassenger[j] == null)
                    {
                        passengerList[i - 1].arrayPassenger[j] = "";
                    }
                    flightPassengers[i, j].Append(passengerList[i - 1].arrayPassenger[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (11 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (12 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (12 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (14 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (9 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (15 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (8 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (8 - passengerList[i - 1].arrayPassenger[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            int counter = 0;
            for (int i  = 0; i < flightPassengers.GetLength(0); i++)
            {
                for (int j = 0; j < flightPassengers.GetLength(1); j++)
                {
                    Console.Write(flightPassengers[i, j]);
                }
                counter++;
                if (counter != flightPassengers.GetLength(0))
                {
                    Console.WriteLine();
                }
                
            }
        }
        public void DisplaySchedulePassengerList()
        {
            string[] header = { "FlightNumb", "FirstName", "SecondName", "Nationality", "Passport", "DateOfBirthday", "Sex", "Class" };

            //int numberOfPassengers = 0;
            //for (int i = 0; i < flightPassengerList.Length; i++)
            //{
            //    for (int j = 0; j < flightPassengerList[i].flightPassengersArrayList.Length; j++)
            //    {
            //        numberOfPassengers++;
            //    }
            //}

            StringBuilder[,] flightPassengers = new StringBuilder[1, 8];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < flightPassengers.GetLength(1); j++)
                {
                    flightPassengers[i, j] = new StringBuilder();
                    flightPassengers[i, j].Append(header[j]);
                    switch (j)
                    {
                        case 0:
                            for (int k = 0; k < (11 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 1:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 2:
                            for (int k = 0; k < (12 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 3:
                            for (int k = 0; k < (14 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 4:
                            for (int k = 0; k < (9 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 5:
                            for (int k = 0; k < (15 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 6:
                            for (int k = 0; k < (8 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        case 7:
                            for (int k = 0; k < (8 - header[j].Length); k++)
                            {
                                flightPassengers[i, j].Append(" ");
                            }
                            break;
                        default:
                            break;
                    }

                }
            }

            for (int i = 0; i < flightPassengers.GetLength(0); i++)
            {
                for (int j = 0; j < flightPassengers.GetLength(1); j++)
                {
                    Console.Write(flightPassengers[i, j]);
                }
            }

            for (int i = 0; i < flightPassengerList.Length; i++)
            {
                DisplayFlightPassengerListWithoutHeader(flightPassengerList[i].flightPassengersArrayList);
            }
            
        }

        public void MethodDisplay()
        {
            Console.WriteLine("Flight departed");
        }
    }
}
