using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHash
{
    class Program
    {
        struct student
        {
            public string examNo;
            public string surname;
            public string firstName;
            public string house;
            public string tutor;
        }

        static void Main(string[] args)
        {
            student[] hashTable = new student[100];
            int choice;
            bool flag = true;

            while (flag)
            {
                DisplayMenu();
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        addRecord(EnterDetails(), hashTable);
                        break;
                    case 2:
                        DisplayRecord(hashTable);
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
           

        }

        static int hashFunction(string key)
        {
            int index;
            int a = int.Parse(key[0].ToString());
            int b = int.Parse(key[1].ToString());
            int c = int.Parse(key[2].ToString());
            int d = int.Parse(key[3].ToString());
            index = ((a * 1 + b * 2 + c * 3 + d * 4) % 50) * 2;

            return index;
        }

        static void addRecord(student newRecord, student[] hashTable)
        {
            int key = hashFunction(newRecord.examNo);

            while (hashTable[key].examNo != null)
            {
                key = key + 1;
                if (key == 100)
                {
                    key = 0;
                }
            }

            hashTable[key] = newRecord;
        }

        static student getRecord(string examNo, student[] hashTable)
        {
            int key = hashFunction(examNo);
            student oldRecord;
            if (hashTable[key].examNo == null)
            {
                Console.Beep();
                Console.WriteLine("Data not in file");
            }
            else {
                while (hashTable[key].examNo != examNo)
                {
                    key = key + 1;
                    if (key == 100)
                    {
                        key = 0;
                    }
                }
            } 

            oldRecord = hashTable[key];
            return oldRecord;
        }

        static student EnterDetails()
        {
            student newRecord = new student();

            Console.Clear();
            Console.WriteLine("Enter New Student Details");

            Console.Write("Exam Number: ");
            newRecord.examNo = Console.ReadLine();
            while (newRecord.examNo.Length != 4)
            {
                Console.Beep();
                Console.WriteLine("Enter a 4 digit number!");
                Console.Write("Exam Number: ");
                newRecord.examNo = Console.ReadLine();
            }
            Console.Write("FirstName: ");
            newRecord.firstName = Console.ReadLine();
            Console.Write("Surname: ");
            newRecord.surname = Console.ReadLine();
            Console.Write("House: ");
            newRecord.house = Console.ReadLine();
            Console.Write("Tutor: ");
            newRecord.tutor = Console.ReadLine();

            return newRecord;
        }

        static void DisplayRecord(student[] hashTable)
        {
            string examNo;
            student oldRecord;
            Console.Clear();
            Console.WriteLine("Display Record");
            Console.WriteLine();
            Console.Write("Enter the Exam Number of the student you wish to view: ");
            examNo = Console.ReadLine();
            while (examNo.Length != 4)
            {
                Console.Beep();
                Console.WriteLine("Enter a 4 digit number!");
                Console.Write("Exam Number: ");
                examNo = Console.ReadLine();
            }

            oldRecord = getRecord(examNo, hashTable);

            Console.Write("Exam Number:");
            Console.WriteLine(oldRecord.examNo);
            Console.Write("FirstName: ");
            Console.WriteLine(oldRecord.firstName);
            Console.Write("Surname: ");
            Console.WriteLine(oldRecord.surname);
            Console.Write("House: ");
            Console.WriteLine(oldRecord.house);
            Console.Write("Tutor: ");
            Console.WriteLine(oldRecord.tutor);

            anykey();
            
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("My Hashing Program/n");
            Console.WriteLine("Options");
            Console.WriteLine("1. Add New Record");
            Console.WriteLine("2. View Existing Record");
        }
        static void anykey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
