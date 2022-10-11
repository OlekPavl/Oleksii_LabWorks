using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_4_3
{
    //6) implement interface IEnumerable
    class Animals : IEnumerable
    {
        // 7) declare private array of Animal
        private Animal[] animals;

        // 8) declare parameter constructor to initialize array   
        public Animals(Animal[] array)
        {
            animals = array;
        }

        // 9) implement method GetEnumerator(), which returns IEnumerator
        // use foreach on array of Animal
        // and yield return for every animal
        public IEnumerator GetEnumerator()
        {
            foreach (Animal animal in animals)
            {
                yield return animal;
            }
        }

    }
}
