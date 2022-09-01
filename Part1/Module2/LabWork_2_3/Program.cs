using System;

namespace LabWork_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money obj1 = new Money(100, CurrencyTypes.EU);
            Money obj2 = new Money(80, CurrencyTypes.EU);
            Console.WriteLine($"obj1:  {obj1.Amount} {obj1.CurrencyType}");
            Console.WriteLine($"obj2:  {obj2.Amount} {obj2.CurrencyType}");
            Console.WriteLine();

            // 11) do operations
            // add 2 objects of Money
            Console.WriteLine($"Sum of obj1 and obj2 = {(obj1 + obj2).Amount} {(obj1 + obj2).CurrencyType}");
            Console.WriteLine();

            // add 1st object of Money and double
            Console.WriteLine($"obj1 + 7.77: {(obj1 + 7.77).Amount} {(obj1 + 7.77).CurrencyType}");
            Console.WriteLine();

            // decrease 2nd object of Money by 1 
            Console.WriteLine($"Decrease obj2: {(--obj2).Amount} {(--obj2).CurrencyType}");
            Console.WriteLine();

            // increase 1st object of Money
            Console.WriteLine($"Increase obj1 3 times: {(obj1 * 3).Amount} {(obj1 * 3).CurrencyType}");
            Console.WriteLine();

            // compare 2 objects of Money
            Console.WriteLine($"obj1 > obj2? {obj1 > obj2}");
            Console.WriteLine();

            // compare 2nd object of Money and string
            Console.WriteLine($"obj2 > 97? {obj2 > "97"}");
            Console.WriteLine();

            // check CurrencyType of every object
            Console.Write($"Is obj1 currency = EU/USD/UAH?: ");
            if (obj1) 
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
            Console.WriteLine();
            Console.Write($"Is obj2 currency = EU/USD/UAH?: ");
            if (obj2)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
            Console.WriteLine();
            Console.WriteLine();

            // convert 1st object of Money to string
            string a = (string)obj1;
            Console.WriteLine($"Convert obj1 to string: {a}");


            Console.ReadKey();
        }
    }
}
