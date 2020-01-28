using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Array
            int[] elephant = CreateNumberArray(30);

            //Display Array
            Console.WriteLine("Unsorted Array:\n");
            OutputArray(elephant);

            //Sort the array
            Console.WriteLine("==============");
            Console.WriteLine("The Merge Sort");
            Console.WriteLine("==============\n");
            MergeSort(elephant, 0, elephant.Length - 1);

            //Display Array
            Console.WriteLine("Sorted Array:\n");
            OutputArray(elephant);

            Console.ReadKey();
        }

        static int[] CreateNumberArray(int numberRqd)
        {
            Random rnd = new Random();
            int[] tempArray = new int[numberRqd];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = rnd.Next(1, 51);
            }
            return tempArray;
        }

        static void OutputArray(int[] tempArray)
        {
            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.Write(tempArray[i].ToString().PadLeft(3));
            }
            Console.WriteLine("\n");
        }

        static public void MergeSort(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid); //recursive call 1
                MergeSort(numbers, (mid + 1), right); //recursive call 2

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                Console.Write(numbers[right].ToString().PadLeft(3)); //delete me
                right--;
            }
            Console.WriteLine();
        }

    }
}
