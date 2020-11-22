// https://codeforces.com/contest/791/problem/A

using System;
using System.ComponentModel.DataAnnotations;

namespace CF_791A_Bear_BigBrother
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ');

            var lW = int.Parse(input[0]);
            var bW = int.Parse(input[1]);
            var count = 0;

            while (lW <= bW)
            {
                lW = lW * 3;
                bW = bW * 2;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
