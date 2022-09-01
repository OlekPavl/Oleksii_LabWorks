using System;
using System.Threading;

namespace Console_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        #region ToFromBinary
        static void My_Binary()
        {
            //Implement positive integer variable input
            uint a;
            

            Console.Write("Enter positive integer: ");
            a = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();

            //Present it like binary string
            //   For example, 4 as 100

            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop
            string aString = null;
            uint a2 = a;

            while (a2 > 0)
            {
                aString += a2 % 2;
                a2 = a2 / 2;
            }

            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method
            char[] charArray = aString.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine($"Decimal format: {a}");
            Console.Write("Binary format: ");
            foreach (var item in charArray)
            {
                Console.Write(item);
            }

        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            //Declare int and string variables for decimal and binary presentations
            uint a;
            uint b;
            string aString = null;
            string bString = null;

            //Implement two positive integer variables input
            Console.Write("Enter the 1st positive integer: ");
            a = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter the 2nd positive integer: ");
            b = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();

            //To present each of them in the form of unary string use for loop
            for (int i = 0; i < a; i++)
            {
                aString += 1;
            }

            for (int i = 0; i < b; i++)
            {
                bString += 1;
            }

            //Use concatenation of these two strings 
            //Note it is necessary to use some symbol ( for example “#”) to separate
            string concatString = aString + "#" + bString;
            Console.Write(concatString);
            Console.WriteLine();

            //Check the numbers on the equality 0
            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 
            //Delete the '#' from algorithm result
            if (a == 0)
            {
                Console.WriteLine("The 1st number = 0");
            }
            else if (b == 0)
            {
                Console.WriteLine("The 2nd number = 0");
            }

            for ( ; concatString[0] != '#' && concatString[concatString.Length - 1] != '#'; )
            {
               
                string newString = null;
                for (int i = 1; i < concatString.Length - 1; i++)
                {
                    newString += concatString[i];
                }
                concatString = newString;
            }

            string algorithmResult = null;
            for (int i = 0; i < concatString.Length; i++)
            {
                if (concatString[i] == '#')
                {
                    continue;
                }
                else
                {
                    algorithmResult += concatString[i];
                }
            }

            //Output the result 
            Console.WriteLine($"String after reducing: {concatString}");
            Console.WriteLine($"Decimal number: {algorithmResult.Length}");
            Console.WriteLine($"Unary number: {algorithmResult}");
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            //Create string variable for 'sos'      
            string sos = "sos";
            //Use string array for Morse code
            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};

            string[] sosMorseArray = new string[sos.Length];

            for (int i = 0; i < sos.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < Dictionary_arr.GetLength(1); k++)
                    {
                        if (Dictionary_arr[j, k].Contains(sos[i]))
                        {
                            sosMorseArray[i] = Dictionary_arr[j + 1, k];
                        }

                    }
                }
            }

            for (int i = 0; i < sosMorseArray.Length; i++)
            {
                sosMorseArray[i] = sosMorseArray[i].Trim();
            }


            //Use ToCharArray() method for string to copy charecters to Unicode character array
            //Use foreach loop for character array in which
            char[][] charSigns = new char[sos.Length][];

            for (int i = 0; i < sosMorseArray.Length; i++)
            {
                for (int j = 0; j < sosMorseArray[i].Length; j++)
                {
                    charSigns[i] = sosMorseArray[i].ToCharArray();
                }
            }

            for (int i = 0; i < sos.Length; i++)
            {
                Console.Write($"{sos[i]} - ");
                for (int j = 0; j < charSigns[i].Length; j++)
                {
                    Console.Write(charSigns[i][j]);
                }
                Console.WriteLine();
            }

            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'

            //Use Thread.Sleep(50) to separate sounds
            //
            //
            Thread.Sleep(500);

            foreach (var item in charSigns)
            {
                foreach (var sign in item)
                {
                    if (sign == '.')
                    {
                        Console.Beep(1000, 250);
                    }
                    else if (sign == '-')
                    {
                        Console.Beep(1000, 750);
                    }
                }
                Thread.Sleep(700);

            }



        }

        #endregion
    }
}
