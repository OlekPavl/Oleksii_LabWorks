using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2_2_2
{
    class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box
        public int LeftPoition { get; set; }
        public int TopPosition { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Symbol { get; set; }
        public string Message { get; set; }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message
        public void Draw()
        {
            Console.WriteLine("Enter start position. ");
            Console.Write("Left: ");
            LeftPoition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Top: ");
            TopPosition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height");
            Height = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Write("Enter symbol (*,+,.): ");
                if (Console.ReadLine().Contains('*') || Console.ReadLine().Contains('+') || Console.ReadLine().Contains('.'))
                {
                    Symbol = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("The symbol is not acceptable.");
                }
            }
            Console.Write("Enter message");
            Message = Console.ReadLine();

        }

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary
    }
}
