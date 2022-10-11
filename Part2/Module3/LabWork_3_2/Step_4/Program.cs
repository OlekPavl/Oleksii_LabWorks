using System;
using System.Collections.Generic;
using System.Security;

[assembly: SecurityTransparent]
namespace Step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Step4_dll.St4_dll.GetKeyName();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
