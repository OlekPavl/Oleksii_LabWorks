using System;


namespace ProgramCode_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables

            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
            int number6;
            int number7;

            int[] array = new int[7];

            int status;
            bool cycle = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please,  type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

            //Key sequence: 3817283 or 3827183

            while (cycle == true)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter the 1st number");
                Console.ForegroundColor = ConsoleColor.Blue;
                number1 = Convert.ToInt32(Console.ReadLine());

                if (number1 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter the 2nd number");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    number2 = Convert.ToInt32(Console.ReadLine());
                    if (number2 == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter the 3rd number");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        number3 = Convert.ToInt32(Console.ReadLine());
                        if (number3 == 1 || number3 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Enter the 4th number");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            number4 = Convert.ToInt32(Console.ReadLine());
                            if (number4 == 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter the 5th number");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                number5 = Convert.ToInt32(Console.ReadLine());
                                if (number5 == 2 || number5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Enter the 6th number");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    number6 = Convert.ToInt32(Console.ReadLine());
                                    if (number6 == 8)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Enter the 7th number");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        number7 = Convert.ToInt32(Console.ReadLine());
                                        if (number7 == 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Winner. The sequence is correct");
                                            Console.WriteLine();
                                            Console.WriteLine("Play again - 1 / Exit - 2");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            status = Convert.ToInt32(Console.ReadLine());
                                            if (status == 1)
                                            {
                                                continue;
                                            }
                                            else if(status == 2)
                                            {
                                                cycle = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("The sequence is not correct");
                                            Console.WriteLine();
                                            Console.WriteLine("Play again - 1 / Exit - 2");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            status = Convert.ToInt32(Console.ReadLine());
                                            if (status == 1)
                                            {
                                                continue;
                                            }
                                            else if (status == 2)
                                            {
                                                cycle = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("The sequence is not correct");
                                        Console.WriteLine();
                                        Console.WriteLine("Play again - 1 / Exit - 2");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        status = Convert.ToInt32(Console.ReadLine());
                                        if (status == 1)
                                        {
                                            continue;
                                        }
                                        else if (status == 2)
                                        {
                                            cycle = false;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("The sequence is not correct");
                                    Console.WriteLine();
                                    Console.WriteLine("Play again - 1 / Exit - 2");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    status = Convert.ToInt32(Console.ReadLine());
                                    if (status == 1)
                                    {
                                        continue;
                                    }
                                    else if (status == 2)
                                    {
                                        cycle = false;
                                    }
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("The sequence is not correct");
                                Console.WriteLine();
                                Console.WriteLine("Play again - 1 / Exit - 2");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                status = Convert.ToInt32(Console.ReadLine());
                                if (status == 1)
                                {
                                    continue;
                                }
                                else if (status == 2)
                                {
                                    cycle = false;
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The sequence is not correct");
                            Console.WriteLine();
                            Console.WriteLine("Play again - 1 / Exit - 2");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            status = Convert.ToInt32(Console.ReadLine());
                            if (status == 1)
                            {
                                continue;
                            }
                            else if (status == 2)
                            {
                                cycle = false;
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The sequence is not correct");
                        Console.WriteLine();
                        Console.WriteLine("Play again - 1 / Exit - 2");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        status = Convert.ToInt32(Console.ReadLine());
                        if (status == 1)
                        {
                            continue;
                        }
                        else if (status == 2)
                        {
                            cycle = false;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The sequence is not correct");
                    Console.WriteLine();
                    Console.WriteLine("Play again - 1 / Exit - 2");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    status = Convert.ToInt32(Console.ReadLine());
                    if (status == 1)
                    {
                        continue;
                    }
                    else if (status == 2)
                    {
                        cycle = false;
                    }
                }
            }

            



        }
        #endregion
        #region calculator
        enum OperationType
        {
            Multiplication,
            Divide,
            Addition,
            Substraction,
            Exponentiation
        }
        
        static void Calculator()
        {
            bool cycle = true;
            int status;

            while (cycle == true)
            {
                // Set Console.ForegroundColor  value
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
                // Implement option input (1,2,3,4,5)
                //     and input of  two or one numbers
                //  Perform calculations and output the result
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                int operationNumber = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please enter the 1st operand");
                Console.ForegroundColor = ConsoleColor.Green;
                int operand1 = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please enter the 2nd operand");
                Console.ForegroundColor = ConsoleColor.Green;
                int operand2 = Convert.ToInt32(Console.ReadLine());


                switch (operationNumber)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}: {1} * {2} = {3} ", OperationType.Multiplication, operand1, operand2, operand1 * operand2);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}: {1} / {2} = {3} ", OperationType.Divide, operand1, operand2, operand1 / operand2);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}: {1} + {2} = {3} ", OperationType.Addition, operand1, operand2, operand1 + operand2);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}: {1} - {2} = {3} ", OperationType.Substraction, operand1, operand2, operand1 - operand2);
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}: {1} ^ {2} = {3} ", OperationType.Exponentiation, operand1, operand2, Math.Pow(operand1, operand2));
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Again - 1 / Exit - 2");
                Console.ForegroundColor = ConsoleColor.Green;
                status = Convert.ToInt32(Console.ReadLine());
                if (status == 1)
                {
                    continue;
                }
                else if (status == 2)
                {
                    cycle = false;
                }
            }



        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result

            bool cycle = true;
            int status;

            while (cycle == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter number for calculation:");
                Console.ForegroundColor = ConsoleColor.Green;
                long number = Convert.ToInt32(Console.ReadLine());
                long factorial = 1;
                
                for (long i = number; i > 0; i--)
                {
                    factorial *= i;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Factorial {0} = {1}", number, factorial);

                Console.WriteLine();
                Console.WriteLine("Again - 1 / Exit - 2");
                Console.ForegroundColor = ConsoleColor.Green;
                status = Convert.ToInt32(Console.ReadLine());
                if (status == 1)
                {
                    continue;
                }
                else if (status == 2)
                {
                    cycle = false;
                }
            }
            


        }
        #endregion
    }
}
