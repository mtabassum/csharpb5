using System;

namespace CF_155A_I_loveusername
{
    class Program
    {

        // Problem Link - https://codeforces.com/contest/155/problem/A
        static void Main(string[] args)
        {
           
            var count = 0;
            var length = Convert.ToInt32(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');

            var arr = new int[length];

            for (int i = 0; i < length; i++)
            {
              arr[i] = int.Parse(input[i]);
            }

            var max = arr[0];
            var min = arr[0];

            for (int i = 1; i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    count++;
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
