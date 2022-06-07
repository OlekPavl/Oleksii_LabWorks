using System;

namespace LabWork_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            CatchExceptionClass cec = new CatchExceptionClass();
            cec.CatchExceptionMethod();

            // 11) Make some unhandled exception and study Visual Studio debugger report – 
            // read description and find the reason of exception
            int[] array = new int[10];
            int b = array[10];


            Console.ReadKey();
        }
    }
}
