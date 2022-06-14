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
        public int LeftPosition { get; set; }
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
            LeftPosition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Top: ");
            TopPosition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            Height = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Write("Enter symbol (*,+,.): ");
                Symbol = Console.ReadLine();
                if (Symbol == "*" || Symbol == "+" || Symbol == ".")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The symbol is not acceptable.");
                }
            }
            Console.Write("Enter message: ");
            Message = Console.ReadLine();
            Console.Clear();

            //LeftPosition = 1;
            //TopPosition = 2;
            //Width = 10;
            //Height = 8;
            //Message = "Peace";

            if (Width - Message.Length >= 4)
            {
                draw(this.LeftPosition, this.TopPosition, this.Width, this.Height, this.Symbol, this.Message);
            }
            else
            {
                Width = Message.Length + 4;
                draw(this.LeftPosition, this.TopPosition, this.Width, this.Height, this.Symbol, this.Message);
            }
            


            

        }

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary
        private void draw(int leftPosition, int topPosition, int width, int height, string symbol, string message)
        {
            for (int j = 0; j < width; j++)
            {
                Console.SetCursorPosition(leftPosition + j, topPosition + 0);
                Console.Write(symbol);
            }
            for (int j = 0; j < width; j++)
            {
                Console.SetCursorPosition(leftPosition + j, topPosition + height - 1);
                Console.Write(symbol);
            }
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(leftPosition + 0, topPosition + i);
                Console.Write(symbol);
            }
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(leftPosition + width - 1, topPosition + i);
                Console.Write(symbol);
            }
            Console.SetCursorPosition(leftPosition + 2, topPosition + height/2 - 1);
            Console.Write(message);

            Console.SetCursorPosition(1, topPosition + height + 2);

        }
    }
}
