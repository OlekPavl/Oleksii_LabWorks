using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            int input = Console.ReadLine().ToString();

            bool result = int.TryParse(input, out var number);
            if (result == true)
                Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
            else
                Console.WriteLine("Преобразование завершилось неудачно");


            Console.ReadKey();
        }
    }
}
