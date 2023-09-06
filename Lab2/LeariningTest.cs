using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class LeariningTest
    {
        private int[] dataArray;

        public LeariningTest()
        {
            Random random = new Random();
            dataArray = new int[10];
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = random.Next(0, 101);
            }
        }

        public void Print()
        {
            Console.WriteLine("Массив:");
            foreach (int number in dataArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public void SortArray()
        {
            Array.Sort(dataArray);
            Console.WriteLine("Отсортированный массив:");
            foreach (int number in dataArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public int FindElementBinary(int target)
        {
            int left = 0;
            int right = dataArray.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (dataArray[middle] == target)
                {
                    return middle;
                }
                else if (dataArray[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}