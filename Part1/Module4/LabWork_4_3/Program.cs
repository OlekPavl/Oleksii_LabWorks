using System;
using System.Collections;
using System.Collections.Generic;

namespace LabWork_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) Create an array of Animal objects and object of Animals    
            // print animals with foreach operator for object of Animals 
            Animal[] animalsArray =
            {
                new Animal("genus2", 500),
                new Animal("genus1", 75),
                new Animal("genus3", 200)
            };

            Animals animalsObject = new Animals(animalsArray);

            foreach (Animal animal in animalsObject)
            {
                Console.WriteLine($"Genus - {animal.Genus} weight - {animal.Weight}");
            }
            Console.WriteLine();
            // 11) Invoke 3 types of sorting 
            // and print results with foreach operator for array of Animal objects  

            Array.Sort(animalsArray);

            foreach (Animal animal in animalsObject)
            {
                Console.WriteLine($"Genus - {animal.Genus} weight - {animal.Weight}");
            }
            Console.WriteLine();

            Array.Sort(animalsArray, new Animal.SortWeightAscendingHelper());
            foreach (Animal animal in animalsObject)
            {
                Console.WriteLine($"Genus - {animal.Genus} weight - {animal.Weight}");
            }
            Console.WriteLine();

            Array.Sort(animalsArray, new Animal.SortGenusDescendingHelper());
            foreach (Animal animal in animalsObject)
            {
                Console.WriteLine($"Genus - {animal.Genus} weight - {animal.Weight}");
            }

            Console.ReadLine();
        }
    }
}
