using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Security;

[assembly: SecurityTransparent]

namespace Step_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fp1 = @"c:\Test_dir1";
            string fp2 = @"c:\Test_dir2";
            string fn = @"c:\Test_file.txt";
            if (!Directory.Exists(fp1)) Directory.CreateDirectory(fp1);
            if (!Directory.Exists(fp2)) Directory.CreateDirectory(fp2);
            Console.WriteLine("2 directories  were created");
            try
            {
                if (!File.Exists(fn)) using (FileStream fs = File.Create(fn)) { }
                Console.WriteLine("File was created");
                if (!Directory.Exists(fp1)) Directory.CreateDirectory(fp1);
                if (!Directory.Exists(fp2)) Directory.CreateDirectory(fp2);
                Console.WriteLine("2 Folders  were created.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            
            Console.WriteLine("Clear ...");
            if (Directory.Exists(fp1)) Directory.Delete(fp1);
            if (Directory.Exists(fp2)) Directory.Delete(fp2);
            if (File.Exists(fn)) File.Delete(fn);
            Console.ReadKey(true);
        }
    }
}
