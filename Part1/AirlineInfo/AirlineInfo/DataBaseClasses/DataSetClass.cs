using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AirlineInfo
{
    internal class DataSetClass
    {
        public DataSet flightDataSet;
        public DataTable flightSchedule;
        public DataTable flightStatusList;
        public DataTable priceList;
        public DataTable passengersList;
        public DataSetClass()
        {
            flightDataSet = new DataSet("FlightDataSet");
            flightSchedule = new DataTable("FlightSchedule");
            flightStatusList = new DataTable("FlightStatusList");
            priceList = new DataTable("FlightPriceList");
            passengersList = new DataTable("PassengersList");
            flightDataSet.Tables.Add(flightSchedule);
            flightDataSet.Tables.Add(flightStatusList);
            flightDataSet.Tables.Add(priceList);
            flightDataSet.Tables.Add(passengersList);
        }

        #region FlightSchedule
        public void FillScheduleTable(FlightSchedule flSchede)
        {
            DataColumn flightNumber = new DataColumn("FlightNumber", Type.GetType("System.Int32"));
            flightNumber.Unique = true;
            flightNumber.AllowDBNull = false;
            DataColumn airLine = new DataColumn("Airline", Type.GetType("System.String"));
            DataColumn departureTime = new DataColumn("DepartureTime", Type.GetType("System.DateTime"));
            DataColumn arrivalTime = new DataColumn("ArrivalTime", Type.GetType("System.DateTime"));
            DataColumn cityOfDeparture = new DataColumn("CityDepart", Type.GetType("System.String"));
            DataColumn portOfDeparture = new DataColumn("PortDepart", Type.GetType("System.String"));
            DataColumn cityOfArrival = new DataColumn("CityArriv", Type.GetType("System.String"));
            DataColumn portOfArrival = new DataColumn("PortArriv", Type.GetType("System.String"));
            DataColumn terminal = new DataColumn("Terminal", Type.GetType("System.String"));

            flightSchedule.Columns.Add(flightNumber);        
            flightSchedule.Columns.Add(airLine);        
            flightSchedule.Columns.Add(departureTime);        
            flightSchedule.Columns.Add(arrivalTime);        
            flightSchedule.Columns.Add(cityOfDeparture);        
            flightSchedule.Columns.Add(portOfDeparture);        
            flightSchedule.Columns.Add(cityOfArrival);        
            flightSchedule.Columns.Add(portOfArrival);        
            flightSchedule.Columns.Add(terminal);

            flightSchedule.PrimaryKey = new DataColumn[] { flightSchedule.Columns["FlightNumb"] };

            for (int i = 0; i < flSchede.flightsArray.Length; i++)
            {
                DataRow row = flightSchedule.NewRow();
                row.ItemArray = new object[]
                {
                    flSchede.flightsArray[i].FlightNumber,
                    flSchede.flightsArray[i].Airline,
                    flSchede.flightsArray[i].DepartureDateTime,
                    flSchede.flightsArray[i].ArrivalDateTime,
                    flSchede.flightsArray[i].CityOfDeparture,
                    flSchede.flightsArray[i].PortOfDeparture,
                    flSchede.flightsArray[i].CityOfArrival,
                    flSchede.flightsArray[i].PortOfArrival,
                    flSchede.flightsArray[i].Terminal
                };
                flightSchedule.Rows.Add(row);
            }
        
        }
        public void DisplayScheduleTable()
        {
            string[] header = { "FlightNumb", "Airline", "DepartureTime", "ArrivalTime", "CityDepart", "PortDepart", "CityArriv", "PortArriv", "Terminal" };

            Console.Write("FlightNumb\t Airline\t DepartureTime\t ArrivalTime\t CityDepart\t PortDepart\t CityArriv\t PortArriv\t Terminal\t");
            Console.WriteLine();

            foreach (DataRow r in flightSchedule.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("{0}\t", cell);
                Console.WriteLine();
            }
        }
        #endregion

        #region FlightStatusList
        public void FillFlightStatusListTable(FlightStatusList fsl)
        {
            DataColumn flightNumber = new DataColumn("FlighNumb", Type.GetType("System.Int32"));
            DataColumn gate = new DataColumn("Gate", Type.GetType("System.Int32"));
            DataColumn checkIn = new DataColumn("CheckIn", Type.GetType("System.String"));
            DataColumn gateClosed = new DataColumn("GateClosed", Type.GetType("System.String"));
            DataColumn cancelled = new DataColumn("Cancelled", Type.GetType("System.String"));
            DataColumn inFlight = new DataColumn("InFlight", Type.GetType("System.String"));
            DataColumn departedAt = new DataColumn("DepartedAt", Type.GetType("System.DateTime"));
            DataColumn expectedAt = new DataColumn("ExpectedAt", Type.GetType("System.DateTime"));
            DataColumn arrivedAt = new DataColumn("ArrivedAt", Type.GetType("System.DateTime"));

            flightStatusList.Columns.Add(flightNumber);
            flightStatusList.Columns.Add(gate);
            flightStatusList.Columns.Add(checkIn);
            flightStatusList.Columns.Add(gateClosed);
            flightStatusList.Columns.Add(cancelled);
            flightStatusList.Columns.Add(inFlight);
            flightStatusList.Columns.Add(departedAt);
            flightStatusList.Columns.Add(expectedAt);
            flightStatusList.Columns.Add(arrivedAt);

            flightStatusList.PrimaryKey = new DataColumn[] { flightStatusList.Columns["FlightNumb"] };

            for (int i = 0; i < fsl.flightsStatusArray.Length; i++)
            {
                DataRow row = flightStatusList.NewRow();
                row.ItemArray = new object[]
                {
                    fsl.flightsStatusArray[i].FlightNumber,
                    fsl.flightsStatusArray[i].Gate,
                    fsl.flightsStatusArray[i].CheckIn,
                    fsl.flightsStatusArray[i].GateClosed,
                    fsl.flightsStatusArray[i].Cancelled,
                    fsl.flightsStatusArray[i].InFlight,
                    fsl.flightsStatusArray[i].DepartedAt,
                    fsl.flightsStatusArray[i].ExpectedAt,
                    fsl.flightsStatusArray[i].ArrivedAt
                };
                flightStatusList.Rows.Add(row);
            }

        }
        public void DisplayFlightStatusListTable()
        {
            string[] header = { "FlighNumb", "Gate", "CheckIn", "GateClosed", "Cancelled", "InFlight", "DepartedAt", "ExpectedAt", "ArrivedAt" };

            Console.Write("FlighNumb\t Gate\t CheckIn\t GateClosed\t Cancelled\t InFlight\t DepartedAt\t ExpectedAt\t ArrivedAt\t");
            Console.WriteLine();

            foreach (DataRow r in flightStatusList.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("{0}\t", cell);
                Console.WriteLine();
            }
        }
        #endregion

        #region PriceList
        public void FillFlightPriceListTable(PriceList pl)
        {
            DataColumn flightNumb = new DataColumn("FlightNumb", Type.GetType("System.Int32"));
            DataColumn euroPrice = new DataColumn("EuroPrice", Type.GetType("System.Int32"));
            DataColumn currencyEUR = new DataColumn("CurrencyEURO", Type.GetType("System.String"));
            DataColumn usdPrice = new DataColumn("UsdPrice", Type.GetType("System.Int32"));
            DataColumn currencyUSD = new DataColumn("CurrencyUSD", Type.GetType("System.String"));


            priceList.Columns.Add(flightNumb);
            priceList.Columns.Add(euroPrice);
            priceList.Columns.Add(currencyEUR);
            priceList.Columns.Add(usdPrice);
            priceList.Columns.Add(currencyUSD);


            priceList.PrimaryKey = new DataColumn[] { priceList.Columns["FlightNumb"] };

            for (int i = 0; i < pl.priceArrayList.Length; i++)
            {
                DataRow row = priceList.NewRow();
                row.ItemArray = new object[]
                {
                    pl.priceArrayList[i].FlightNumber,
                    pl.priceArrayList[i].EuroPrice,
                    "Euro",
                    pl.priceArrayList[i].USDPrice,
                    "Usd",                  
                };
                priceList.Rows.Add(row);
            }

        }
        public void DisplayFlightPriceListTable()
        {
            string[] header = { "FlightNumb", "EuroPrice", "Currency", "UsdPrice", "Currency" };

            Console.Write("FlightNumb\t EuroPrice\t Currency\t UsdPrice\t Currency\t");
            Console.WriteLine();

            foreach (DataRow r in priceList.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("{0}\t", cell);
                Console.WriteLine();
            }
        }
        #endregion

        #region PassengersList
        public void FillPassengerListTable(SchedulePassengerList spl)
        {
       
            DataColumn flightNumb = new DataColumn("FlightNumb", Type.GetType("System.Int32"));
            DataColumn firstName = new DataColumn("FirstName", Type.GetType("System.String"));
            DataColumn secondName = new DataColumn("SecondName", Type.GetType("System.String"));
            DataColumn nationality = new DataColumn("Nationality", Type.GetType("System.String"));
            DataColumn passport = new DataColumn("Passport", Type.GetType("System.String"));
            DataColumn dateOfBirth = new DataColumn("DateOfBirthday", Type.GetType("System.String"));
            DataColumn sex = new DataColumn("Sex", Type.GetType("System.String"));
            DataColumn  _class = new DataColumn("Class", Type.GetType("System.String"));


            passengersList.Columns.Add(flightNumb);
            passengersList.Columns.Add(firstName);
            passengersList.Columns.Add(secondName);
            passengersList.Columns.Add(nationality);
            passengersList.Columns.Add(passport);
            passengersList.Columns.Add(dateOfBirth);
            passengersList.Columns.Add(sex);
            passengersList.Columns.Add(_class);


            passengersList.PrimaryKey = new DataColumn[] { passengersList.Columns["FlightNumb"], passengersList.Columns["Passport"] };

            for (int i = 0; i < spl.schedulePassengersArray.Length; i++)
            {
                for (int j = 0; j < spl.schedulePassengersArray[i].flightPassengersArrayList.Length; j++)
                {
                    DataRow row = passengersList.NewRow();
                    row.ItemArray = new object[]
                    {
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].FlightNumber,
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].FirstName,
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].SecondName,
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].Nationality,
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].Passport,
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].DateOfBirthday,
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].Sex,
                        spl.schedulePassengersArray[i].flightPassengersArrayList[j].Class,

                    };
                    passengersList.Rows.Add(row);
                }

            }

        }
        public void DisplayPassengerListTable()
        {
            string[] header = { "FlightNumb", "FirstName", "SecondName", "Nationality", "Passport", "DateOfBirthday", "Sex", "Class" };

            Console.Write("FlightNumb\t FirstName\t SecondName\t Nationality\t Passport\t DateOfBirthday\t Sex\t Class\t");
            Console.WriteLine();

            foreach (DataRow r in passengersList.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write("{0}\t", cell);
                Console.WriteLine();
            }
        }
        #endregion
    }
}
