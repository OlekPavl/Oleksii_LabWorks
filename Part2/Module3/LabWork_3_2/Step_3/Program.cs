using System;
using System.Security.Policy;
using System.Reflection;

namespace Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Zone zn = asm.Evidence.GetHostEvidence<Zone>();
            Console.WriteLine("Zone Evidence: " + zn.SecurityZone.ToString());
            Console.WriteLine("\r\nIsFullyTrusted: {0}", asm.IsFullyTrusted);
            Console.ReadKey();
        }
    }
}
