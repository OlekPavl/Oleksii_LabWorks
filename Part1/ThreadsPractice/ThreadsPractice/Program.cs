﻿using System.Threading;
using System.Threading.Tasks;


namespace ThreadsPractice
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var square5 = SquareAsync(5);
            var square6 = SquareAsync(6);

            Console.WriteLine($"Остальные действия в методе Main - [{Thread.CurrentThread.ManagedThreadId}]");

            int n1 = await square5;
            int n2 = await square6;
            Console.WriteLine($"n1={n1} n2={n2}");

            async Task<int> SquareAsync(int n)
            {
                await Task.Delay(0);
                var result = n * n;
                Console.WriteLine($"Квадрат числа {n} равен {result} - [{Thread.CurrentThread.ManagedThreadId}]");
                return result;
            }

            Console.ReadKey();
        }

    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }

}