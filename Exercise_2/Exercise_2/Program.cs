using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose List size");
            int listSize = Convert.ToInt32(Console.ReadLine());

            List<int> collection = new List<int>();

            for (int i = 0; i < listSize; i++)
            {
                Console.WriteLine("Add next element to list");
                collection.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine($"Your elements in old list:");

            foreach (var item in collection)
            {
                Console.WriteLine( item);
            }

            var newCollection = RemoveNonPrime.Remove(collection);

            Console.WriteLine($"Your elements in new list without Prime");
            foreach (var item in newCollection) 
            {
                Console.WriteLine(item);
            }



        }
    }
}
