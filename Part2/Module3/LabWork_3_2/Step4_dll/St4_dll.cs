using System;
using Microsoft.Win32;
using System.Security;

//[assembly: SecurityTransparent]

namespace Step4_dll
{
    public static class St4_dll
    {
        [SecurityCritical]
        public static void GetKeyName()
        {
            Console.WriteLine("Read the registry keys");
            RegistryKey regk = Registry.CurrentConfig;
            string[] nm_strarr = regk.GetSubKeyNames();
            Console.WriteLine("Length of array: " + nm_strarr.Length.ToString());
        }
    }
}
