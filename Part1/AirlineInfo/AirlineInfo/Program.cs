using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AirlineInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFlight flight = new CreateFlight();
            Menu menu = new Menu(flight);
            //RunProgram program = new RunProgram(menu);

            //SQLServerDataBaseClass db = new SQLServerDataBaseClass(dataSetClass);
            //db.CreateTableFlightScheduleInDatabase();
            //db.UpdateTableFlightScheduleInDatabase();



            Console.ReadKey();
        }


    }   
}
