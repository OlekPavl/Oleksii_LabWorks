using System;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Length = 5;

            Console.WriteLine(str.Length);

            str.Append("123456");

            Console.WriteLine(str.Length);


            Console.ReadKey();
        }
    }
}
