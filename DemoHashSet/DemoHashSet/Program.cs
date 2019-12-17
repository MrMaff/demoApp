using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> somenumbers = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(somenumbers.Count);
            Console.WriteLine("Adding the number 12!");
            somenumbers.Add(12);
            Console.WriteLine(somenumbers.Count);
            Console.WriteLine("Adding the numbers 4 and 5!");
            somenumbers.Add(4);
            somenumbers.Add(5);
            Console.WriteLine("Adding the numbers -1");
            somenumbers.Add(-1);
            Console.WriteLine(somenumbers.Count);
            Console.WriteLine("Outputting contents of hashset....");
            foreach (int number in somenumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();

        }
    }
}
