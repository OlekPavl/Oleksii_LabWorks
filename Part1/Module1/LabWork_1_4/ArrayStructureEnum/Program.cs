using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStructureEnum
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType
        {
            Desktop,
            Laptop,
            Server
        }

        // 2) declare struct Computer
        struct Computer
        {
            public int CPU { get; set; }
            public double HGz { get; set; }
            public int Memory { get; set; }
            public int HDD { get; set; }

            public ComputerType compType;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] arrayOfComputers = new Computer[4][];


            // 4) set the size of every array in jagged array (number of computers)
            arrayOfComputers[0] = new Computer[5];
            arrayOfComputers[1] = new Computer[3];
            arrayOfComputers[2] = new Computer[5];
            arrayOfComputers[3] = new Computer[4];

            // 5) initialize array
            // Note: use loops and if-else statements
            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0 || j == 1)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Desktop;
                            arrayOfComputers[i][j].CPU = 4;
                            arrayOfComputers[i][j].HGz = 2.5;
                            arrayOfComputers[i][j].Memory = 6;
                            arrayOfComputers[i][j].HDD = 500;
                        }
                        else if (j == 2 || j == 3)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Laptop;
                            arrayOfComputers[i][j].CPU = 2;
                            arrayOfComputers[i][j].HGz = 1.7;
                            arrayOfComputers[i][j].Memory = 4;
                            arrayOfComputers[i][j].HDD = 250;
                        }
                        else if (j == 4)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Server;
                            arrayOfComputers[i][j].CPU = 8;
                            arrayOfComputers[i][j].HGz = 3;
                            arrayOfComputers[i][j].Memory = 16;
                            arrayOfComputers[i][j].HDD = 2048;
                        }
                    }
                    else if (i == 1)
                    {
                        arrayOfComputers[i][j].compType = ComputerType.Laptop;
                        arrayOfComputers[i][j].CPU = 2;
                        arrayOfComputers[i][j].HGz = 1.7;
                        arrayOfComputers[i][j].Memory = 4;
                        arrayOfComputers[i][j].HDD = 250;
                    }
                    else if (i == 2)
                    {
                        if (j == 0 || j == 1 || j == 2)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Desktop;
                            arrayOfComputers[i][j].CPU = 4;
                            arrayOfComputers[i][j].HGz = 2.5;
                            arrayOfComputers[i][j].Memory = 6;
                            arrayOfComputers[i][j].HDD = 500;
                        }
                        else if (j == 3 || j == 4)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Laptop;
                            arrayOfComputers[i][j].CPU = 2;
                            arrayOfComputers[i][j].HGz = 1.7;
                            arrayOfComputers[i][j].Memory = 4;
                            arrayOfComputers[i][j].HDD = 250;
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 0)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Desktop;
                            arrayOfComputers[i][j].CPU = 4;
                            arrayOfComputers[i][j].HGz = 2.5;
                            arrayOfComputers[i][j].Memory = 6;
                            arrayOfComputers[i][j].HDD = 500;
                        }
                        else if (j == 1)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Laptop;
                            arrayOfComputers[i][j].CPU = 2;
                            arrayOfComputers[i][j].HGz = 1.7;
                            arrayOfComputers[i][j].Memory = 4;
                            arrayOfComputers[i][j].HDD = 250;
                        }
                        else if (j == 2 || j == 3)
                        {
                            arrayOfComputers[i][j].compType = ComputerType.Server;
                            arrayOfComputers[i][j].CPU = 8;
                            arrayOfComputers[i][j].HGz = 3;
                            arrayOfComputers[i][j].Memory = 16;
                            arrayOfComputers[i][j].HDD = 2048;
                        }
                    }

                }
            }

            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    Console.Write($"{arrayOfComputers[i][j].compType}\t");
                }
                Console.WriteLine();
            }

            // 6) count total number of every type of computers
            int numberOfDesktops = 0;
            int numberOfLaptops = 0;
            int numberOfServers = 0;
            foreach (Computer[] row in arrayOfComputers)
            {
                foreach (Computer item in row)
                {
                    if (item.compType == ComputerType.Desktop)
                    {
                        numberOfDesktops++;
                    }
                    else if (item.compType == ComputerType.Laptop)
                    {
                        numberOfLaptops++;
                    }
                    else
                    {
                        numberOfServers++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Number of desktops - {numberOfDesktops}");
            Console.WriteLine($"Number of laptops - {numberOfLaptops}");
            Console.WriteLine($"Number of servers - {numberOfServers}");

            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            int totalNumberOfComputers = 0;
            foreach (Computer[] row in arrayOfComputers)
            {
                foreach (Computer item in row)
                {
                    totalNumberOfComputers++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Total number of computers - {totalNumberOfComputers}");
            Console.WriteLine();



            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            int maxHDDValue = arrayOfComputers[0][0].HDD;
            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    if (arrayOfComputers[i][j].HDD > maxHDDValue)
                    {
                        maxHDDValue = arrayOfComputers[i][j].HDD;
                    }
                }
            }
            Console.WriteLine($"The largest storage (HDD) - {maxHDDValue}");
            Console.WriteLine();
            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    if (arrayOfComputers[i][j].HDD == maxHDDValue)
                    {
                        Console.WriteLine($"Computer[{i}][{j}] with the largest storage (HDD)");
                    }
                }
            }
            Console.WriteLine();

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            int minCPUValue = arrayOfComputers[0][0].CPU;
            int minMemory = arrayOfComputers[0][0].Memory;
            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    if (arrayOfComputers[i][j].CPU < minCPUValue)
                    {
                        minCPUValue = arrayOfComputers[i][j].CPU;
                    }
                    else if (arrayOfComputers[i][j].Memory < minMemory)
                    {
                        minMemory = arrayOfComputers[i][j].Memory;
                    }
                }
            }
            Console.WriteLine($"The lowest productivity (CPU and memory): CPU - {minCPUValue} and Memory - {minMemory}");
            Console.WriteLine();
            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    if (arrayOfComputers[i][j].CPU == minCPUValue && arrayOfComputers[i][j].Memory == minMemory)
                    {
                        Console.WriteLine($"Computer[{i}][{j}] has the lowest productivity (CPU and memory)");
                    }
                }
            }
            Console.WriteLine();

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    if (arrayOfComputers[i][j].compType == ComputerType.Desktop)
                    {
                        arrayOfComputers[i][j].Memory = 8;
                    }
                }
            }
            for (int i = 0; i < arrayOfComputers.Length; i++)
            {
                for (int j = 0; j < arrayOfComputers[i].Length; j++)
                {
                    Console.Write($"Memory of {arrayOfComputers[i][j].compType}-{arrayOfComputers[i][j].Memory}\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

    }
}
