using System;

namespace ProgramCode_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition
            int userNumber;
            bool cycle = true;

            while (cycle == true)
            {
                Console.Write("Enter your guess: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < Guess_number)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0} - Too low!", userNumber);
                }
                else if (userNumber > Guess_number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} - Too high!", userNumber);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0} - is right! Congratulations!", userNumber);
                    cycle = false;
                }
            }

            Console.ReadLine();
        }
    }
}
