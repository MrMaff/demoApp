using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int[] NumberArray = { 77, 5, 3, 78, 9, 90, 34, 36, 500, 79, 1, 7, 66, 21, 92, 455, 46 };
                int searchNo;

                Console.Write("What number do you want to find: ");
                int.TryParse(Console.ReadLine(), out searchNo);

                BinaryTree myTree = new BinaryTree(NumberArray, false);

                Console.WriteLine(myTree.Contains(searchNo));

                Console.ReadKey();

        }
    }
}
