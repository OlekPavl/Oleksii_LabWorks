using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Management;


[assembly: SecurityCritical]
//[assembly: SecurityTransparent]
namespace Step_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                try
                {
                    Cl1 cl = new Cl1();
                    cl.GetCompName();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                uint ver = GetVersion();
                Console.WriteLine("Ver " + ver);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        [DllImport("kernel32.dll")]
        static extern uint GetVersion();

       

        
    }
}
