
//problem link: https://codeforces.com/problemset/problem/4/A

using System;

namespace CF_Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());

            if (w >= 1 && w<=100)
            {
                if (w % 2 == 0 && w>2)
                {
                    Console.WriteLine("YES");
                }
                else
                    Console.WriteLine("NO");
            }

        }
    }
}
