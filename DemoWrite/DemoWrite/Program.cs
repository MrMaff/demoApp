using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoWrite
{
    class Program
    {

        public static void Main(string[] args)
        {
            string fileName = @"tenLines.txt";
            string[] lines = new string[10];

            try
            {

                using (StreamReader currentFile = new StreamReader(fileName))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        //lines[i] = currentFile.ReadLine();
                        Console.WriteLine(currentFile.ReadLine());
                    }
                }
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Uh oh!, " + ex.Message);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(lines[i]);
            //}
            Console.ReadKey();
        }

    }

}

