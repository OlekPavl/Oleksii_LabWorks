using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_4_3
{
    // 1) implement interface IComparable
    public class Animal : IComparable
    {
        // 2) declare properties and parameter constructor
        public string Genus { get; set; }
        public int Weight { get; set; }
        public Animal(string genus, int weight)
        {
            this.Genus = genus;
            this.Weight = weight;
        }

        // 3) implement method ComareTo()
        // it comares Genus of type string - return result of method String.Compare 
        // for this.genus and argument object
        // don't forget to cast object to Animal
        public int CompareTo(object obj)
        {
            if (obj is Animal a)
            {
                return Genus.CompareTo(a.Genus);
            }
            else
            {
                throw new ArgumentException();
            }
         
        }

        // 4) declare methods SortWeightAscending(), SortGenusDescending()
        // they are static and return IComparer
        // return type is custed from constructor of classes SortWeightAscendingHelper, 
        // SortGenusDescendingHelper calling 
        public static IComparer SortWeightAscending()
        {
            return new SortWeightAscendingHelper();
        }

        public static IComparer SortGenusDescending()
        {
            return new SortGenusDescendingHelper();
        }

        // 5) declare 2 nested private classes SortWeightAscendingHelper, SortGenusDescendingHelper 
        // they implement interface IComparer
        // every nested class has implemented method Comare with 2 parameters of object and return int
        // class SortWeightAscendingHelper sort weight by ascending
        // class SortGenusDescendingHelper sort genus by descending
        class SortWeightAscendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x is Animal a1 && y is Animal a2)
                {
                    return a1.Weight.CompareTo(a2.Weight);
                }
                else
                {
                    throw new System.NotImplementedException();
                }

            }

        }
        class SortGenusDescendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x is Animal a1 && y is Animal a2)
                {
                    return a1.Genus.CompareTo(a2.Genus);
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
        }

    }
}
