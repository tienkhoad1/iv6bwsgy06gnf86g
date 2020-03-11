using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bai1
    {
        static void printTwoElements(int[] arr, int size)
        {
            int i;

            for (i = 0; i < size; i++)
            {
                int abs_val = Math.Abs(arr[i]);
                if (arr[abs_val - 1] > 0)
                    arr[abs_val - 1] = -arr[abs_val - 1];
            }

            Console.Write("the missing element is ");
            for (i = 0; i < size; i++)
            {
                if (arr[i] > 0)
                    Console.WriteLine(i + 1);
            }
        }

        // Driver program 
        public static void Main()
        {
            int[] arr = { 2, 3, 1, 4, 6, 9, 5, 8, 10, 5 };
            int n = arr.Length;
            printTwoElements(arr, n);
        }
    }
}
