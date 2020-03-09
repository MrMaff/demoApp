using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FebTestSectB
{
    class Program
    {
        static void Main(string[] args)
        {
            string Prime;
            int Count1;
            int Count2;
            Console.WriteLine("The first few prime numbers are:");
            for (Count1 = 2; Count1 <= 50; Count1++)
            {
                Count2 = 2;
                Prime = "Yes";
                while (Count2 * Count2 <= Count1)
                {
                    if (Count1 % Count2 == 0)
                    {
                        Prime = "No";
                    }
                    Count2 = Count2 + 1;
                }

                if (Prime == "Yes")
                {
                    Console.WriteLine(Count1);
                }
            }
            Console.ReadLine();

        }
    }
}
