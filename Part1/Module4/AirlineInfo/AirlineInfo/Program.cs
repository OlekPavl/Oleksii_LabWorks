using System;

namespace AirlineInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFlight flight = new CreateFlight();
            Menu menu = new Menu(flight);
            //RunProgram program = new RunProgram(menu);
            


            Console.ReadKey();
        }



    }   
}
