using System;
using Microsoft.Win32;
using System.Reflection;
using System.Security;

//[assembly: SecurityCritical]

namespace Step5_dll
{
    public class St5_dll
    {

        public static void GetKeyName()
        {
            WriteAssInfo();
            Console.WriteLine("Read the registry keys");
            RegistryKey regk = Registry.CurrentConfig;
            string[] nm_strarr = regk.GetSubKeyNames();
            Console.WriteLine("Length of array: " + nm_strarr.Length.ToString());
        }
        static void WriteAssInfo()
        {
            Console.WriteLine("***");
            AppDomain cur_aDom = AppDomain.CurrentDomain;
            Console.WriteLine("SANDBOX domain info. IsFullTrusted: {0}", cur_aDom.IsFullyTrusted);
            Assembly[] asm = cur_aDom.GetAssemblies();
            if (asm.Length == 0) Console.WriteLine("No assemblies");
            else
            {
                Console.WriteLine("{0} assemblies.  Info :", asm.Length.ToString());
                foreach (Assembly item in asm)
                {
                    string asmName = new AssemblyName(item.FullName).Name;
                    Console.WriteLine(" Simple Name: " + asmName);
                    Console.WriteLine("\t IsFullTrusted: {0}", item.IsFullyTrusted);
                }
                string codeLayer = typeof(St5_dll).IsSecurityTransparent ? "Transparent" : "Critical";
                Console.WriteLine(" This domain code: {0} ", codeLayer);
            }
        }
    }
}
