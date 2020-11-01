using System;
using System.Globalization;

namespace QuestionNo3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("No of Elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int j=0; j<n/2; j++)
            {
                swap(arr, j, n - j - 1);
            }

            Console.Write("Reverse Array- ");
            Console.Write(string.Join(',', arr));

            splitOddEven(arr, n);

            Console.WriteLine("\nSplit reverse array-");
            Console.WriteLine(String.Join(" ", arr));

        }

        private static void splitOddEven(int[] arr, int limit)
        { 

            int l = 0, r = limit - 1;
            // Count of odd numbers
            int k = 0;

            while (l < r)
            {
                // Find first even number from left side.
                while (arr[l] % 2 != 0)
                {
                    l++;
                    k++;
                }

                // Find first odd number from right side.
                while (arr[r] % 2 == 0 && l < r)
                    r--;

                // Swap even number on left and odd number right.
                if (l < r)
                {
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                }
            }
            Array.Reverse(arr, 0, k);       
        }

        private static void swap(int[] arr, int j, int i)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
