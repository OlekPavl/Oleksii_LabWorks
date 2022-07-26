using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace LabWork_5_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Computer comp1 = new Computer(4, 3.5, 8, 256);
            Computer comp2 = new Computer(4, 3.5, 8, 512);
            Computer comp3 = new Computer(8, 3.5, 32, 1024);
            Computer comp4 = new Computer(8, 3.7, 32, 1024);


            // 3) create collection of computers;
            // set path to file and file name
            List<Computer> collection = new List<Computer>();
            collection.Add(comp1);
            collection.Add(comp2);
            collection.Add(comp3);
            collection.Add(comp4);

            InOutOperation obj1 = new InOutOperation();
            obj1.ChangeLocation(@"D:\");

            // 4) save data and read it in the seamplest way (with WriteData() and ReadData() methods)

            foreach (Computer item in collection)
            {
                await obj1.WriteData(item, "Computer");
            }

            await obj1.ReadData("Computer");


            // 5) save data and read it with WriteZip() and ReadZip() methods
            // Note: create another file for these operations
            await obj1.WriteZip("Computer");
            await obj1.ReadZip("Computer");
            await obj1.ReadData("Computer_Decompressed");

            // 6) read info about computers asynchronously (from the 1st file)
            // While asynchronous method will be running, Main() method must print ‘*’ 
            await obj1.ReadData("Computer");
            Console.WriteLine("*");

            // use 
            // collection of Task with info about computers as type to get returned data from method ReadAsync()
            // use property Result of collection of Task to get access to info about computers

            // Note:
            // print all info about computers after reading from files
            //Task<Computer> taskCollection = new Task<Computer>(() => ReadAsynchronously());



            // ADVANCED:
            // 8) save data to memory stream and from memory to file
            // declare file stream and set it to null
            // call method WriteToMemory() with info about computers as parameter
            // save returned stream to file stream

        // call method WriteToFileFromMemory() with parameter of file stream
        // open file with saved data and compare it with input info


            Console.ReadKey();
        }
    }
}
