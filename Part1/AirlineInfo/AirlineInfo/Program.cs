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
            Flight flight = new Flight();
            Menu menu = new Menu(flight);





            Console.ReadKey();
        }


    }   
}
