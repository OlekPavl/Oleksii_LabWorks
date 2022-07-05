using System;

namespace LabWork_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp1 = new Computer(4, 3.5, 8, 256);

            InOutOperation obj1 = new InOutOperation();
            obj1.ChangeLocation(@"D:\");
            //obj1.WriteData(comp1, "Computer");
            //obj1.ReadData("Computer");
            //obj1.WriteZip("Computer");
            obj1.ReadZip("Computer");

            // 3) create collection of computers;
            // set path to file and file name

            // 4) save data and read it in the seamplest way (with WriteData() and ReadData() methods)

            // 5) save data and read it with WriteZip() and ReadZip() methods
            // Note: create another file for these operations

            // 6) read info about computers asynchronously (from the 1st file)
            // While asynchronous method will be running, Main() method must print ‘*’ 

            // use 
            // collection of Task with info about computers as type to get returned data from method ReadAsync()
            // use property Result of collection of Task to get access to info about computers

            // Note:
            // print all info about computers after reading from files


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
