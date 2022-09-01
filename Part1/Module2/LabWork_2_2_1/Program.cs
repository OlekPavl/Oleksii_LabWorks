using System;

namespace LabWork_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate
            Console.Write("Enter number for calculation: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {number} = {Factorial(number)}");

            //Create fact() method  with parameter to calculate factorial
            //Use ternary operator
            int Factorial(int number)
            {
                if (number == 1)
                {
                    return 1;
                }
                else
                {
                    return number * Factorial(number - 1);
                }
            }

            Console.ReadKey();
        }


    }
}
