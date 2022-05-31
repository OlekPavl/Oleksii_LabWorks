using System;

namespace LabWork_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box rectangle = new Box();
            rectangle.Draw();
            
            Console.SetCursorPosition(rectangle.LeftPoition, rectangle.TopPosition);

            //try
            //{
            //    //Implement start position, width and height, symbol, message input

            //    //Create Box class instance

            //    //Use  Box.Draw() method

            //    Console.WriteLine("Press any key...");
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error!");
            //}


            Console.ReadKey();
        }
    }
}
