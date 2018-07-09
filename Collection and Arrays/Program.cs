using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a collection that is a list of strings

            var dogs = new List<string>();

            dogs.Add("Rock Wilder");
            dogs.Add("Bulldog");
            dogs.Add("Retriever");

            // move through the list

            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog+ " ");
            //}

            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };

            foreach (int num in a1)
            {
                Console.WriteLine(num + " ");
            }
            
        }
    }
}
