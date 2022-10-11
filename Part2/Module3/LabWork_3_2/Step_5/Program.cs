using System;
using System.Security;
using System.Reflection;
using System.Security.Permissions;
using Microsoft.Win32;


namespace Step_5
{
    public class Program : MarshalByRefObject
    {
        static void Main()
        {
            try
            {

                Type_Assemblies_info();

                AppDomainSetup setup = new AppDomainSetup { ApplicationBase = Environment.CurrentDirectory };

                PermissionSet prmts = new PermissionSet(null);
                prmts.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
                prmts.AddPermission(new RegistryPermission(RegistryPermissionAccess.Read, Registry.CurrentConfig.Name));

                AppDomain appDomain = AppDomain.CreateDomain(
                        "SANDBOX domain",
                        null,
                        setup,
                        prmts);

                Program p = (Program)(Activator.CreateInstance(appDomain, "Step_5", "Step_5.Program").Unwrap());

                p.Dll_in_SndBox();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        void Dll_in_SndBox()
        {
            Step5_dll.St5_dll.GetKeyName();
        }

        static void Type_Assemblies_info()
        {
            Console.WriteLine("***");
            AppDomain cur_appD = AppDomain.CurrentDomain;
            Console.WriteLine("MAIN domain info.  IsFullTrusted: {0}", cur_appD.IsFullyTrusted);
            Assembly[] assems = cur_appD.GetAssemblies();
            if (assems.Length == 0) Console.WriteLine("No assemblies in this domain");
            else
            {
                Console.WriteLine("{0} assemblies loaded in this domain. Info about:", assems.Length.ToString());
                foreach (Assembly a in assems)
                {
                    string assem_SimpleName = new AssemblyName(a.FullName).Name;
                    Console.WriteLine("Simple Name: " + assem_SimpleName);
                    Console.WriteLine("\t This assembly IsFullTrusted: {0}", a.IsFullyTrusted);
                }
            }
            string codeLayer = typeof(Program).IsSecurityTransparent ? "Transparent" : "Critical";
            Console.WriteLine("Code in this domain belong to {0} layer", codeLayer);
        }
    }
}