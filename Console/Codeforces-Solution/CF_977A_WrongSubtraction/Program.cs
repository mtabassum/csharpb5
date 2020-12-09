// https://codeforces.com/problemset/problem/977/A

using System;

namespace CF_977A_WrongSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var n = int.Parse(input[0]);
            var k = int.Parse(input[1]);


            for (int i = 1; i <= k; i++)
            {
                if (n % 10 == 0)
                {
                    n /= 10;
                }
                else
                    n--;
            }

            Console.WriteLine(n);
        }
    }
}
